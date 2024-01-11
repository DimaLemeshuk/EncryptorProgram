using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Lr1_BIS.Classes
{
    class KnapsackCipher
    {
        public static string Encryption(string message, int[] publicKey)
        {

            byte[] bytes = Encoding.Unicode.GetBytes(message);
            try 
            {
                string binary = string.Join("", bytes.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));
                int[] binaryIntArr = binary.Select(c => int.Parse(c.ToString())).ToArray();
                int[] resIntArr = new int[binaryIntArr.Length / publicKey.Length];

                int n = publicKey.Length;

                for (int i = 0; i < binaryIntArr.Length; i += n)
                {
                    int sum = 0;
                    for (int j = i; j < i + n; j++)
                    {
                        sum += binaryIntArr[j] * publicKey[j % n];
                    }
                    resIntArr[i / n] = sum;
                }

                return string.Join(" ", resIntArr);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return null;
        }

        public static string Decryption(string message, int[] privateKey, int multiplier, int module)
        {
            try
            {
                int inverse = GenerateInverse(multiplier, module);
                int[] messageIntArr = message.Split(' ').Select(int.Parse).ToArray();
                int[] decryptedIntArr = new int[messageIntArr.Length * privateKey.Length];

                int n = privateKey.Length;

                for (int i = 0; i < messageIntArr.Length; i++)
                {
                    int decrypted = (messageIntArr[i] * inverse) % module;
                    for (int j = n - 1; j >= 0; j--)
                    {
                        if (decrypted >= privateKey[j])
                        {
                            decryptedIntArr[i * n + j] = 1;
                            decrypted -= privateKey[j];
                        }
                        else
                        {
                            decryptedIntArr[i * n + j] = 0;
                        }
                    }
                }

                string binary = string.Join("", decryptedIntArr.Select(b => b.ToString()));
                byte[] bytes = BitStringToByteArray(binary.PadLeft((int)Math.Ceiling(binary.Length / 8.0) * 8, '0'));
                string result = Encoding.Unicode.GetString(bytes);

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return null;
        }

        public static int GenerateInverse(int a, int mod)
        {
            int m0 = mod;
            int y = 0, x = 1;

            if (mod == 1)
                return 0;

            while (a > 1)
            {
                int q = a / mod;
                int t = mod;

                mod = a % mod;
                a = t;
                t = y;

                y = x - q * y;
                x = t;
            }

            if (x < 0)
                x += m0;

            return x;
        }

        public static byte[] BitStringToByteArray(string s)
        {
            int numberOfBytes = s.Length / 8;
            byte[] bytes = new byte[numberOfBytes];
            for (int i = 0; i < numberOfBytes; ++i)
            {
                bytes[i] = Convert.ToByte(s.Substring(8 * i, 8), 2);
            }
            return bytes;
        }

        public static int[] GeneratePrivateKey(int seed, int length)
        {
            Random rnd = new Random(seed);
            int[] superIncreasingSequence = new int[length];
            int sum = 0;

            for (int i = 0; i < length; i++)
            {
                // Генеруємо наступний елемент, що буде більший за суму попередніх
                int nextElement = rnd.Next(sum + 1, sum * 2 + 1);
                superIncreasingSequence[i] = nextElement;
                sum += nextElement;
            }

            return superIncreasingSequence;
        }

        public static int[] GeneratePublicKey(int[] privateKey, int multiplier, int module)
        {
            int[] publicKey = new int[privateKey.Length];
            for (int i = 0; i < privateKey.Length; i++)
            {
                publicKey[i] = (privateKey[i] * multiplier) % module;
            }
            return publicKey;
        }

        public static int GenerateMultiplier(int seed, int module)
        {
            int result;
            Random rand = new Random(seed);
            do
            {
                result = rand.Next(module + 1);
            } while (!AreCoprime(result, module));

            return result;
        }

        private static bool AreCoprime(int a, int b)
        {
            return Enumerable.Range(2, (int)Math.Sqrt(a)).All(n => a % n != 0 || b % n != 0);
        }
    }

}

