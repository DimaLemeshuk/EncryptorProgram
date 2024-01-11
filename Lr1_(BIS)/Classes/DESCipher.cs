using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lr1__BIS_.Classes
{
    class DESCipher
    {

        public static string Encryption(string message, CipherMode mode, string key, string iv)
        {
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);

            using (var des = new DESCryptoServiceProvider())
            {
                try
                {
                    des.Mode = mode;
                    des.Key = Encoding.UTF8.GetBytes(key);
                    des.IV = Encoding.UTF8.GetBytes(iv);

                    using (var memoryStream = new MemoryStream())
                    {
                        using (var cryptoStream = new CryptoStream(memoryStream, des.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(messageBytes, 0, messageBytes.Length);
                            cryptoStream.FlushFinalBlock();
                            return Convert.ToBase64String(memoryStream.ToArray());
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }

                return null;
            }
        }

        public static string Decryption(string message, CipherMode mode, string key, string iv)
        {
            using (var des = new DESCryptoServiceProvider())
            {
                try
                {
                    byte[] messageBytes = Convert.FromBase64String(message);

                    des.Mode = mode;
                    des.Padding = PaddingMode.PKCS7;
                    des.Key = Encoding.UTF8.GetBytes(key);
                    des.IV = Encoding.UTF8.GetBytes(iv);

                    using (var memoryStream = new MemoryStream(messageBytes))
                    {
                        using (var cryptoStream = new CryptoStream(memoryStream, des.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            using (var streamReader = new StreamReader(cryptoStream))
                            {
                                return streamReader.ReadToEnd();
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }

                return null;
            }
        }

    }
}
