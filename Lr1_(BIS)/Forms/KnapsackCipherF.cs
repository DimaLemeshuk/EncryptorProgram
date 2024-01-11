using Lr1__BIS_.Forms;
using Lr1_BIS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr1__BIS_.Classes
{
    public partial class KnapsackCipherF : Form
    {
        public KnapsackCipherF()
        {
            InitializeComponent();
        }

        private void Encryption_Click(object sender, EventArgs e)
        {
            string message = TextBox1.Text;
            string key = KeyBox.Text;
            int[] publicKey = key.Split(' ').Select(int.Parse).ToArray();//{ 31, 62, 124, 310, 290, 250, 170, 10 }{ 1, 2, 4, 10, 20, 40, 80, 160 }
          
            if (publicKey.Length == 2 || publicKey.Length == 4 || publicKey.Length == 8)
            {
                TextBox2.Text = KnapsackCipher.Encryption(message, publicKey);
                ErrorLabel.Text = "";
            }
            else 
            {
                ErrorLabel.Text = "Довжина ключа повинна бути рівною: 2, 4, 8 ";
            }

        }

        private void Decryption_Click(object sender, EventArgs e)
        {
            string message = TextBox1.Text;
            string key = KeyBox.Text;
            int multiplier, module;
            try 
            {
                int[] privateKey = key.Split(' ').Select(int.Parse).ToArray();

                if (privateKey.Length == 2 || privateKey.Length == 4 || privateKey.Length == 8)
                {
                    if (int.TryParse(multiplierBox.Text, out multiplier) && int.TryParse(moduleBox.Text, out module))
                    {
                        TextBox2.Text = KnapsackCipher.Decryption(message, privateKey, multiplier, module);
                        ErrorLabel.Text = "";
                    }
                    else
                    {
                        ErrorLabel.Text = "Значення множника або модуля некоректні";
                    }
                }
                else
                {
                    ErrorLabel.Text = "Довжина ключа повинна бути рівною: 2, 4, 8 ";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        private void En_De_cryption_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // menu

        private void GoMenu_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form MenuForm = new StartForm();
            MenuForm.ShowDialog();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            string path = FileWork.GetFilePathMenu();
            TextBox1.Text = FileWork.ReadFile(path);
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            string path = FileWork.SaveFileMenu();
            FileWork.WriteToFile(path, TextBox2.Text);
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версія програми: 280223\nРозробник: Лемешук Дмитро");
        }

        private void CaesarCipher_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new CaesarCiperF();
            form.ShowDialog();
        }

        private void TrithemiusCipher_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new TrithemiusCipherF();
            form.ShowDialog();
        }

        private void GammaCipher_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new GammaCipherF();
            form.ShowDialog();
        }

        private void BookCipher_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new BookCipherF();
            form.ShowDialog();
        }

        private void DESCipher_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new DESCipherF();
            form.ShowDialog();
        }

        private void keyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new KeyKnapsackCipherF();
            form.Show();
        }


    }
}

