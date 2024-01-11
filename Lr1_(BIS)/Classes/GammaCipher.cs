using Lr1__BIS_.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1__BIS_.Classes
{
    class GammaCipher
    {
        public static string GammaCipherSystem(string message, int seed)
        {
            string result = "";
            string gama = RandomGama(message.Length, seed);

            for (int i = 0; i < message.Length; i++)
            {
                result += (char)(message[i] ^ gama[i]);
            }
            return result;
        }

        public static string RandomGama(int lenth, int seed)
        {
            string gama = "";
            if (lenth > 0)
            {
                Random rnd = new Random(seed);
                for (int i = 0; i < lenth; i++)
                {
                    gama += (char)rnd.Next();
                }           
            }
            return gama;
        }


        /*public static string Decryption(string message, string gamma)
        {
            string result = "";

            for (int i = 0; i < message.Length; i++)
            {
                result += (char)(((int)message[i] + (int)gamma[i % (gamma.Length - 1)]) % 0xffff);
            }
            return result;
        }

        public static string Encryption(string message, string gamma)
        {
            string result = "";

            for (int i = 0; i < message.Length; i++)
            {
                result += (char)(((int)message[i] + 0xffff - ((int)gamma[i%(gamma.Length-1)] % 0xffff)) % 0xffff);
            }
            return result;
        }*/

    }

}