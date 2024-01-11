using Lr1__BIS_.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr1__BIS_.Forms
{
    public partial class DESCipherF : Form
    {
        public DESCipherF()
        {
            InitializeComponent();
        }

        public static CipherMode cMode = CipherMode.CBC;

        private void Encryption_Click(object sender, EventArgs e)
        {
            string message = TextBox1.Text; 
            string key = KeyBox.Text;
            if (validate()) 
            {
                TextBox2.Text = DESCipher.Encryption(message, cMode, key.Substring(0, 8), "12345678");
            }
        }

        private void Decryption_Click(object sender, EventArgs e)
        {
            string message = TextBox1.Text;
            string key = KeyBox.Text;
            if (validate())
            {
                TextBox2.Text = DESCipher.Decryption(message, cMode, key.Substring(0, 8), "12345678");
            }         
        }

        private bool validate()
        {
            return KeyBox.Text.Length >= 8;
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

        private void CaesarCipher_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new CaesarCiperF();
            form.ShowDialog();
        }

        private void eCBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelMode.Text = "ECB";
            cMode = CipherMode.ECB;
        }

        private void cBCToolStripMenuItem_Click(object sender, EventArgs e)
        {        
            labelMode.Text = "CBC";
            cMode = CipherMode.CBC;
        }

        private void cFBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelMode.Text = "CFB";
            cMode = CipherMode.CFB;
        }

        private void DESCipherF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void рюкзачнийШифрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new KnapsackCipherF();
            form.ShowDialog();
        }
    }

}
