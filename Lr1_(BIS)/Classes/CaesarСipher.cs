using System;

namespace Lr1__BIS_.Classes
{
    class CaesarСipher
    {
        private static string CCC (string message, int key) 
        {
            string result = "";
            
            for (int i = 0; i < message.Length; i++)
            {
                result += Char.ConvertFromUtf32(((int)message[i]) + key);
            }

            return result;
        }

        public string Encryption(string message, int key)
            => CCC(message, key);

        public string Decryption(string message, int key)
            => CCC(message, -key);
        
    }
}
