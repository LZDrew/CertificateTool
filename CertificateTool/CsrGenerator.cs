using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public static class CsrGenerator
{
    public static void GenerateCsrAndKey(string subjectName, int keySize, string savePath, string password = null)
    {
        using var rsa = RSA.Create(keySize);

        var request = new CertificateRequest(
            new X500DistinguishedName(subjectName),
            rsa,
            HashAlgorithmName.SHA256,
            RSASignaturePadding.Pkcs1
        );

        // CSR
        var csrBytes = request.CreateSigningRequest();
        File.WriteAllText(Path.Combine(savePath, "certificate.csr"),
            "-----BEGIN CERTIFICATE REQUEST-----\n" +
            Convert.ToBase64String(csrBytes, Base64FormattingOptions.InsertLineBreaks) +
            "\n-----END CERTIFICATE REQUEST-----");

        // 私鑰
        var privateKey = password != null && password.Length > 0
            ? rsa.ExportEncryptedPkcs8PrivateKey(Encoding.UTF8.GetBytes(password),
                new PbeParameters(PbeEncryptionAlgorithm.Aes256Cbc, HashAlgorithmName.SHA256, 100000))
            : rsa.ExportPkcs8PrivateKey();

        File.WriteAllText(Path.Combine(savePath, "private.key"),
            "-----BEGIN PRIVATE KEY-----\n" +
            Convert.ToBase64String(privateKey, Base64FormattingOptions.InsertLineBreaks) +
            "\n-----END PRIVATE KEY-----");
    }
}
