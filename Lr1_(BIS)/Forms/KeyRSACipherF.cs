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
using static System.Net.Mime.MediaTypeNames;

namespace Lr1__BIS_.Forms
{
    public partial class KeyRSACipherF : Form
    {
        public KeyRSACipherF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string publicKey, privateKey;
            RSACipher.GenerateKeys(out publicKey, out privateKey);

            privateKeyBox.Text = privateKey;
            publicKeyBox.Text = publicKey;
        }

        private void buttonCopy1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(publicKeyBox.Text);
        }

        private void buttonCopy2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(privateKeyBox.Text);
        }
    }
}
