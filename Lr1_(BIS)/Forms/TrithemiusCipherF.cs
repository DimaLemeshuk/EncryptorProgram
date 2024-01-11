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
    public partial class TrithemiusCipherF : Form
    {
        public TrithemiusCipherF()
        {
            InitializeComponent();
        }

        public bool ValidateNum ()
        {         

            if (!long.TryParse(textBoxA.Text, out _) || !long.TryParse(textBoxB.Text, out _) || (textBoxC.Visible && !long.TryParse(textBoxC.Text, out _)) )
            {
                ErrorLabel1.Text = "Ключі не вказано, або вказано невірно";
                return false;
            }

            ErrorLabel1.Text = "";
            return true;
        }

        private void Encryption_Click(object sender, EventArgs e)
        {
            string message;
            long A, B, C;
            
            if (ValidateNum())
            {
                A = textBoxC.Visible ? long.Parse(textBoxC.Text) : 0;
                B = long.Parse(textBoxA.Text);
                C = long.Parse(textBoxB.Text);

                message = TextBox1.Text;
                TextBox2.Text = TrithemiusCipher.Encryption(message, A , B , C );
            }
        }
        private void Decryption_Click(object sender, EventArgs e)
        {
            string message;
            long A, B, C;

            if (ValidateNum())
            {
                A = textBoxC.Visible ? long.Parse(textBoxC.Text) : 0;
                B = long.Parse(textBoxA.Text);
                C = long.Parse(textBoxB.Text);

                message = TextBox1.Text;
                TextBox2.Text = TrithemiusCipher.Decryption(message, A, B , C );
            }
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
            K.Text = "k = A p + B";
            labelC.Visible = false;
            textBoxC.Visible = false;
            equation1.Checked = true;
            equation2.Checked = false;
            motto.Checked = false;
        }

        private void equation2_Click(object sender, EventArgs e)
        {
            K.Text = "k = Ap^2 + Bp + C";
            labelC.Visible = true;
            textBoxC.Visible = true;
            equation1.Checked = false;
            equation2.Checked = true;
            motto.Checked = false;
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
