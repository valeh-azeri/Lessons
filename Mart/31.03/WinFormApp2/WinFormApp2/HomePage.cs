using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp2
{
    public partial class HomePage : Form
    {
        public HomePage(User username)
        {
            InitializeComponent();
            txtNameEdit.Text = username.Name;
            txtSurnameNedit.Text = username.Surname;
            txtİstifadeciAdi.Text = username.Username;
            txtPassWord.Text = username.Password;
            txtAbout.Text = username.AboutUser;
            btnSave.Tag = username.Id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                                   
        }
    }
}
