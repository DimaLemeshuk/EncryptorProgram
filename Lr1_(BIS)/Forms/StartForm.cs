using Lr1__BIS_.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr1__BIS_
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void GoWorkButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form EDCForm = new CaesarCiperF();
            EDCForm.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GoDevelopersButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Розробником є Лемешук Дмитро");
        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
