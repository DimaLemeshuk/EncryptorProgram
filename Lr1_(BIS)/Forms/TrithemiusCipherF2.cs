using Lr1__BIS_.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lr1__BIS_.Forms
{
    public partial class TrithemiusCipherF2 : Form
    {
        public TrithemiusCipherF2()
        {
            InitializeComponent();
        }

        private void Encryption_Click(object sender, EventArgs e)
        {
            string key = textBox3.Text;
            string message = TextBox1.Text ;
            TextBox2.Text = TrithemiusCipher.Encryption(message, key);


        }
        private void Decryption_Click(object sender, EventArgs e)
        {
            string key = textBox3.Text;
            string message = TextBox1.Text;
            TextBox2.Text = TrithemiusCipher.Decryption(message, key);

        }
        // menu

        private void CaesarCipher_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new CaesarCiperF();
            form.ShowDialog();
        }

        private void equation1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new TrithemiusCipherF();
            form.ShowDialog();
        }

        private void equation2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new TrithemiusCipherF();
            form.ShowDialog();
        }

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

        private void TrithemiusCipherF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void motto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new TrithemiusCipherF2();
            form.ShowDialog();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            string path = FileWork.GetFilePathMenu();
            textBox3.Text = FileWork.ReadFile(path);
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
    }
    
}
