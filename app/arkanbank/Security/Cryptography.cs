using arkanbank.Models;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;

namespace arkanbank.Security;

public static class Cryptography {

    #region Constants

    private const string QR_CODE_SECRET = "amor";

    #endregion Constants

    #region Public Methods

    public static string Encrypt(QrCodeItem qrCodeItem) {
        var value = JsonConvert.SerializeObject(qrCodeItem);
        return Encrypt(value, QR_CODE_SECRET);
    }

    public static QrCodeItem Decrypt(string qrCodeSecret) {
        var decrypt = Decrypt(qrCodeSecret, QR_CODE_SECRET);
        if(string.IsNullOrWhiteSpace(decrypt)) { return null; }
        return JsonConvert.DeserializeObject<QrCodeItem>(decrypt);
    }

    #endregion Public Methods

    #region Private Methdos

    private static string Encrypt(string value, string password) {
        var userBytes = Encoding.UTF8.GetBytes(value); // UTF8 saves Space
        var userHash = MD5.Create().ComputeHash(userBytes);
        var crypt = Aes.Create(); // (Default: AES-CCM (Counter with CBC-MAC))
        crypt.Key = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(password)); // MD5: 128 Bit Hash
        crypt.IV = new byte[16]; // by Default. IV[] to 0.. is OK simple crypt
        using(var memoryStream = new MemoryStream()) {
            using(var cryptoStream = new CryptoStream(memoryStream, crypt.CreateEncryptor(), CryptoStreamMode.Write)) {
                cryptoStream.Write(userBytes, 0, userBytes.Length); // User Data
                cryptoStream.Write(userHash, 0, userHash.Length); // Add HASH
                cryptoStream.FlushFinalBlock();
                var resultString = Convert.ToBase64String(memoryStream.ToArray());
                return resultString;
            }
        }
    }

    private static string Decrypt(string value, string password) {
        try {
            var encryptedBytes = Convert.FromBase64String(value);
            var crypt = Aes.Create();
            crypt.Key = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(password));
            crypt.IV = new byte[16];
            using(var memoryStream = new MemoryStream()) {
                using(var cryptoStream = new CryptoStream(memoryStream, crypt.CreateDecryptor(), CryptoStreamMode.Write)) {
                    cryptoStream.Write(encryptedBytes, 0, encryptedBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    var allBytes = memoryStream.ToArray();
                    var userLen = allBytes.Length - 16;
                    if(userLen < 0) { throw new Exception("Invalid Len"); }   // No Hash?
                    var userHash = new byte[16];
                    Array.Copy(allBytes, userLen, userHash, 0, 16); // Get the 2 Hashes
                    var decryptHash = MD5.Create().ComputeHash(allBytes, 0, userLen);
                    if(userHash.SequenceEqual(decryptHash) == false) { throw new Exception("Invalid Hash"); }
                    var resultString = Encoding.UTF8.GetString(allBytes, 0, userLen);
                    return resultString;
                }
            }
        } catch {
            return string.Empty;
        }
    }

    #endregion Private Methdos
}