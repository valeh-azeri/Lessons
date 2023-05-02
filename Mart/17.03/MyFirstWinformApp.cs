using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstFomrApp
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            string message = txtWrute.Text;
            MySecondForm seconfForm = new MySecondForm(message);
            seconfForm.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtWrute_Enter(object sender, EventArgs e)
        {
            TextBox txt1 = (TextBox)sender;
            txt1.Text = string.Empty;
        }
    }
}
