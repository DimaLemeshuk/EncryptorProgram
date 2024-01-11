using System;

namespace Lr1__BIS_.Classes
{
    class TrithemiusCipher
    {
        private static string TrithemiusCipherSystem(string message, long A, long B, long C)
        {

            string result = "";

            for (int i = 0; i < message.Length; i++)
            {

                long key = (A * i * i + B * i + C) % 55296;
                int index = ((int)message[i] + (int)key) % 55296;
                result += Char.ConvertFromUtf32(index > 0 ? index : index + 55296);

            }
            return result;
        }

        private static string TrithemiusCipherSystem(string message, string key, int sign)
        {

            string result = "";
            try
            {
                for (int i = 0; i < message.Length; i++)
                {
                    int k = ((int)key[i % key.Length]) * sign;
                    result += Char.ConvertFromUtf32((((int)message[i]) + k) % 55296);
                }
                return result;
            }
            catch (Exception ex)
            {             
                Console.WriteLine("Сталася помилка: " + ex.Message);
                return "";
            }
        }

        public static string Encryption(string message, long A, long B, long C)
            => TrithemiusCipherSystem(message, A, B, C);

        public static string Decryption(string message, long A, long B, long C)
            => TrithemiusCipherSystem(message, -A, -B, -C);

        public static string Encryption(string message, string key)
            => TrithemiusCipherSystem(message, key, 1);

        public static string Decryption(string message, string key)
            => TrithemiusCipherSystem(message, key, -1 );
    }
}
