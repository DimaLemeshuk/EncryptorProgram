using System;
using System.Security.Cryptography;
using System.Text;

namespace Lr1__BIS_.Classes
{
    class RSACipher
    {
        public static string Encryption(string dataToEncrypt, string publicKey)
        {
            string res = "";
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(publicKey);

            byte[] byteToEncrypt = Encoding.Unicode.GetBytes(dataToEncrypt);
            byte[] encryptedBytes = rsa.Encrypt(byteToEncrypt, false);
            res = Convert.ToBase64String(encryptedBytes);

            return res;
        }


        public static string Decryption(string encryptedData, string privateKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(privateKey);

            byte[] encryptedBytes = Convert.FromBase64String(encryptedData);
            byte[] decryptedBytes = rsa.Decrypt(encryptedBytes, false);

            return Encoding.Unicode.GetString(decryptedBytes);
        }

        public static void GenerateKeys(out string publicKey, out string privateKey)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                publicKey = rsa.ToXmlString(false);
                privateKey = rsa.ToXmlString(true);
            }
        }

    }
}
