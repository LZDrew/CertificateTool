using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public static class PfxInspector
{
    public static string InspectPfx(string pfxPath, string password)
    {
        try
        {
            var collection = new X509Certificate2Collection();
            collection.Import(pfxPath, password, X509KeyStorageFlags.Exportable);

            var sb = new StringBuilder();
            sb.AppendLine($"共載入 {collection.Count} 張憑證：");

            int certIndex = 1;
            foreach (var cert in collection)
            {
                sb.AppendLine($"--- 憑證 {certIndex++} ---");
                sb.AppendLine($"主旨 Subject：{cert.Subject}");
                sb.AppendLine($"簽發者 Issuer：{cert.Issuer}");
                sb.AppendLine($"有效期限：{cert.NotBefore} ~ {cert.NotAfter}");
                sb.AppendLine($"是否過期：{(DateTime.Now > cert.NotAfter ? "是" : "否")}");
                sb.AppendLine($"SHA-1 指紋：{cert.Thumbprint}");
                sb.AppendLine($"SHA-256 指紋：{GetSha256Thumbprint(cert)}");
                sb.AppendLine($"用途 (Key Usage)：{GetKeyUsages(cert)}");
                sb.AppendLine();
            }

            return sb.ToString();
        }
        catch (Exception ex)
        {
            return $"解析失敗：{ex.Message}";
        }
    }

    private static string GetSha256Thumbprint(X509Certificate2 cert)
    {
        using var sha256 = System.Security.Cryptography.SHA256.Create();
        byte[] hash = sha256.ComputeHash(cert.RawData);
        return BitConverter.ToString(hash).Replace("-", "");
    }

    private static string GetKeyUsages(X509Certificate2 cert)
    {
        var usages = new StringBuilder();
        foreach (var extension in cert.Extensions)
        {
            if (extension is X509EnhancedKeyUsageExtension eku)
            {
                foreach (var oid in eku.EnhancedKeyUsages)
                    usages.AppendLine($"- {oid.FriendlyName} ({oid.Value})");
            }
        }

        return usages.Length == 0 ? "無特殊用途" : usages.ToString().Trim();
    }
}
