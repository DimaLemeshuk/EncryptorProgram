using Lr1__BIS_.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr1__BIS_.Forms
{
    public partial class BookCipherF : Form
    {
        public BookCipherF()
        {
            InitializeComponent();
        }

        private void Encryption_Click(object sender, EventArgs e)
        {
            string poem = textBox3.Text;
            string message = TextBox1.Text;
            int l = (int)numericUpDown1.Value;
            TextBox2.Text = Classes.BookCipher.Encryption(message, l, poem);


        }
        private void Decryption_Click(object sender, EventArgs e)
        {
            string poem = textBox3.Text;
            string message = TextBox1.Text;
            int l = (int)numericUpDown1.Value;
            TextBox2.Text = Classes.BookCipher.Decryption(message, l, poem);
        }
        // menu

        private void About_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Версія програми: 280223\nРозробник: Лемешук Дмитро");
        }

        private void GoMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form MenuForm = new StartForm();
            MenuForm.ShowDialog();
        }

        private void OpenFile_Click_1(object sender, EventArgs e)
        {
            string path = FileWork.GetFilePathMenu();
            TextBox1.Text = FileWork.ReadFile(path);
        }

        private void SaveFile_Click_1(object sender, EventArgs e)
        {
            string path = FileWork.SaveFileMenu();
            FileWork.WriteToFile(path, TextBox2.Text);
        }

        private void OpenKey_Click(object sender, EventArgs e)
        {
            string path = FileWork.GetFilePathMenu();
            textBox3.Text = FileWork.ReadFile(path);
        }

        private void SaveKey_Click(object sender, EventArgs e)
        {
            string path = FileWork.SaveFileMenu();
            FileWork.WriteToFile(path, textBox3.Text);
        }

        private void CaesarCipher_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new CaesarCiperF();
            form.ShowDialog();
        }

        private void GaammaCipher_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new GammaCipherF();
            form.ShowDialog();
        }
        private void TrithemiusCipher_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new TrithemiusCipherF();
            form.ShowDialog();
        }

        private void BookCipherF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DESCipher_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new DESCipherF();
            form.ShowDialog();
        }
    }
    
}