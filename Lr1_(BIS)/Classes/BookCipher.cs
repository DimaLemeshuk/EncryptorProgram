using System;

namespace Lr1__BIS_.Classes
{
    class BookCipher
    {
        public static string Decryption(string message, int l, string poem)
        {
            string result = "";

            int j = 0;
            for (int i = 0; i < message.Length; i++)
            {
                int n = 0;
                while (message[i] != poem[j] && n++ < poem.Length)
                {
                    j = (j + 1) % (poem.Length);
                }
                result += n >= poem.Length ? "" : (((j % l)+1) + " " + (Math.Ceiling(((float)(j+1)/l))) + " ");
            }
            return result;
        }

        public static string Encryption(string message, int l, string poem)
        {
            string result = "";
            string[] numbers = message.Split(' ');

            for (int i = 0; i < (numbers.Length-2); i += 2)
            {
                try
                {
                    int l2 = int.Parse(numbers[i]);
                    int h2 = int.Parse(numbers[i + 1]);
                    result += poem[(h2 - 1) * l + l2 - 1];
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
            return result;
        }
    }
}
