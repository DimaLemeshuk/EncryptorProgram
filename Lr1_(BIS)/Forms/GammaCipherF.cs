using Lr1__BIS_.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr1__BIS_.Forms
{
    public partial class GammaCipherF : Form
    {
        public static string Gama { private get; set; }

        public GammaCipherF()
        {
            InitializeComponent();
        }


        private void Encryptio_Decryption_Click(object sender, EventArgs e)
        {
            int seed;
            Int32.TryParse(textBox3.Text,out seed);
            string message = TextBox1.Text;
            TextBox2.Text = GammaCipher.GammaCipherSystem(message, seed);


        }
        // menu

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

        private void saveGama_Click(object sender, EventArgs e)
        {

        }

        private void About_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Версія програми: 190323\nРозробник: Лемешук Дмитро");
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

        private void GammaCipher_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new GammaCipherF();
            form.ShowDialog();
        }

        private void GammaCipherF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
    }
    
    
}
