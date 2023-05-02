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
    public partial class AddPerson : Form
    {
        public AddPerson()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            VerifyPersonData form = new VerifyPersonData();
            ((TextBox)form.Controls["txtDisName"]).Text = txtName.Text;
            ((TextBox)form.Controls["txtDisSurname"]).Text = txtSurname.Text;
            ((TextBox)form.Controls["txtDisDocSerial"]).Text = txtDocSerial.Text;
            ((TextBox)form.Controls["txtDisDocNumber"]).Text = txtDocNumber.Text;

            form.ShowDialog();
        }
    }
}
