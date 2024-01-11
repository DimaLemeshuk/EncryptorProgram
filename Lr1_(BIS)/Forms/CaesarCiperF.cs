using System;
using System.Windows.Forms;
using Lr1__BIS_.Classes;

namespace Lr1__BIS_.Forms
{
    public partial class CaesarCiperF : Form
    {
        CaesarСipher caesarСipher = new CaesarСipher();

        public CaesarCiperF()
        {
            InitializeComponent();
        }

        public bool Validate()
        {
            int key = 0 ;

            if (!int.TryParse(KeyBox.Text, out key) || key > 100000 || key < 0 )
            {
                ErrorLabel.Text = "Ключ не вказано,\n або вказано невірно";
                return false;
            }

            ErrorLabel.Text = "";
            return true;
        }

        private void Encryption_Click(object sender, EventArgs e)
        {
            string message;
            int key;

            if (Validate())
            {

                key = int.Parse(KeyBox.Text);
                message = TextBox1.Text;
                TextBox2.Text = caesarСipher.Encryption(message, key);

            }
        }

        private void Decryption_Click(object sender, EventArgs e)
        {
            string message;
            int key;

            if (Validate())
            {
                key = int.Parse(KeyBox.Text);
                message = TextBox1.Text;
                TextBox2.Text = caesarСipher.Decryption(message, key);
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

        private void рюкзачнийШифрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new KnapsackCipherF();
            form.ShowDialog();
        }

        private void RSACipher_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new RSACipherF();
            form.ShowDialog();
        }
    }
}