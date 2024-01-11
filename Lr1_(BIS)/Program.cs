using Lr1__BIS_.Classes;
using Lr1__BIS_.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr1__BIS_
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            /*string publicKey, privateKey;
            RSACipher.GenerateKeys(out publicKey, out privateKey);

            string originalData = "Hello, world!";
            string encryptedData = RSACipher.Encryption(originalData, publicKey);
            string decryptedData = RSACipher.Decryption(encryptedData, privateKey);

            Console.WriteLine("Original Data: " + originalData);
            Console.WriteLine("Encrypted Data: " + encryptedData);
            Console.WriteLine("Decrypted Data: " + decryptedData);*/


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CaesarCiperF());
        }
    }
}
