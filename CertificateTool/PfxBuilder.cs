using Microsoft.VisualBasic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CertificateTool
{
    public static class PfxBuilder
    {
        public static void BuildPfx(string certPath, string keyPath, string outputPath, string password, string intermediatePath = null)
        {
            // 讀取主憑證
            var certPem = File.ReadAllText(certPath);
            var cert = X509Certificate2.CreateFromPem(certPem);

            // 讀取私鑰
            using var rsa = LoadPrivateKeyWithPrompt(keyPath);

            var certWithKey = cert.CopyWithPrivateKey(rsa);

            // 建立憑證鏈（包含中繼憑證）
            var chain = new X509Certificate2Collection();
            if (!string.IsNullOrEmpty(intermediatePath))
            {
                var intermediatePem = File.ReadAllText(intermediatePath);
                var intermediate = X509Certificate2.CreateFromPem(intermediatePem);
                chain.Add(intermediate);
            }

            // 匯出為 PFX
            var collection = new X509Certificate2Collection();
            collection.Add(certWithKey); // 主憑證＋私鑰
            collection.AddRange(chain);  // 加入中繼（如果有）

            var pfxBytes = collection.Export(X509ContentType.Pfx, password);
            File.WriteAllBytes(outputPath, pfxBytes);
        }

        private static RSA LoadPrivateKeyWithPrompt(string keyPath)
        {
            var pem = File.ReadAllText(keyPath);
            var base64 = ExtractBase64Block(pem, "PRIVATE KEY");

            var keyBytes = Convert.FromBase64String(base64);
            var rsa = RSA.Create();

            try
            {
                // 先試著解密（如果其實沒加密會失敗）
                string password = Interaction.InputBox("此私鑰可能已加密，請輸入密碼（可留空）：", "輸入私鑰密碼", "");
                if (!string.IsNullOrEmpty(password))
                {
                    rsa.ImportEncryptedPkcs8PrivateKey(Encoding.UTF8.GetBytes(password), keyBytes, out _);
                }
                else
                {
                    rsa.ImportPkcs8PrivateKey(keyBytes, out _); // 嘗試直接載入未加密的 PKCS#8
                }
            }
            catch (CryptographicException ex)
            {
                throw new Exception("無法載入私鑰。可能是密碼錯誤或檔案內容損毀。\n" + ex.Message);
            }

            return rsa;
        }


        private static string ExtractBase64Block(string pem, string label)
        {
            var start = $"-----BEGIN {label}-----";
            var end = $"-----END {label}-----";
            var startIndex = pem.IndexOf(start) + start.Length;
            var endIndex = pem.IndexOf(end);
            var base64 = pem.Substring(startIndex, endIndex - startIndex);
            return base64.Replace("\r", "").Replace("\n", "").Trim();
        }
    }
}