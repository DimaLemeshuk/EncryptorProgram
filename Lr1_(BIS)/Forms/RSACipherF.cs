using Lr1__BIS_.Classes;
using System;
using System.Windows.Forms;

namespace Lr1__BIS_.Forms
{
    public partial class RSACipherF : Form
    {
        public RSACipherF()
        {
            InitializeComponent();
        }

        private void Encryption_Click(object sender, EventArgs e)
        { 
            string message = TextBox1.Text;
            string key = KeyBox.Text;
            string res = "";
            int chunkSize = 33;

            for (int i = 0; i < message.Length; i += chunkSize)
            {
                int remainingLength = message.Length - i;
                int currentChunkSize = Math.Min(chunkSize, remainingLength);

                string text = message.Substring(i, currentChunkSize);
                try
                {
                    res += RSACipher.Encryption(text, key);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }
            }
            TextBox2.Text = res;

        }

        private void Decryption_Click(object sender, EventArgs e)
        {
            string message = TextBox1.Text;
            string key = KeyBox.Text;
            string res = "";

            string[] substrings = message.Split('=');
            for (int i = 0; i < substrings.Length; i++)
            {
                try
                {
                    res += RSACipher.Decryption(substrings[i] + '=', key);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }
            }
            TextBox2.Text = res;
        }



        private void En_De_cryption_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private static int GetIntD( int lenth)
        {
           //int k = lenth/59
            return 23;
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
            Form form = new KeyRSACipherF();
            form.Show();
        }

        private void KnapsackCipher_Click(object sender, EventArgs e)
        {
            Form form = new KnapsackCipherF();
            form.Show();
        }
    }
}

