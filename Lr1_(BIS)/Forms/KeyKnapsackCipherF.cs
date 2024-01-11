using Lr1_BIS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr1__BIS_.Forms
{
    public partial class KeyKnapsackCipherF : Form
    {
        public KeyKnapsackCipherF()
        {
            InitializeComponent();
        }

        private void GetKey_Click(object sender, EventArgs e)
        {        
            int seed, lenght, multiplier, module;

            if (int.TryParse(seedTextBox.Text, out seed) && int.TryParse(lenghtTextBox.Text, out lenght))
            {
                ErrorLabel.Text = "";
                if (!(lenght  == 2 || lenght == 4 || lenght == 8))
                {
                    ErrorLabel.Text = "Довжина ключа повинна бути рівною: 2, 4, 8 ";
                }

                int[] privateKey = KnapsackCipher.GeneratePrivateKey(seed, lenght);

                module = (seed % 20) + lenght;
                foreach (int el in privateKey)
                {
                    module += el;
                }

                multiplier = KnapsackCipher.GenerateMultiplier(seed, module);

                publicKeyTextBox.Text = string.Join(" ", KnapsackCipher.GeneratePublicKey(privateKey, multiplier, module));
                privateKeyTextBox.Text = string.Join(" ", privateKey);
                moduleTextBox.Text = module.ToString();
                multiplierTextBox.Text = multiplier.ToString();
            }
            else
            {
                ErrorLabel.Text = "Дані введені невірно"; 
            }
        }
    }
}
