using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform4
{
    public partial class VerifyPersonData : Form
    {
        public VerifyPersonData()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form currentForm = this;
            foreach (Control formItem in currentForm.Controls)
            {
                if (formItem is TextBox)
                {
                    ((TextBox)formItem).Text = string.Empty;
                }
            }
            currentForm.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Form currentForm = this;
            foreach (Form item in Application.OpenForms)
            {
                if (item is AddPerson)
                {
                    foreach (Control formItem in item.Controls)
                    {
                        if (formItem is TextBox)
                        {
                            ((TextBox)formItem).Text = string.Empty;
                        }
                    }
                }
            }
            Form addPersonForm = Application.OpenForms["AddPerson"];
            currentForm.Close();
        }
    }
}
