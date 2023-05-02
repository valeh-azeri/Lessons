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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginMethod(object sender, EventArgs e)
        {
            //if (txtUserName.Text == "admin" && txtPassword.Text == "123")
            //{
            //    HomePage homePage = new HomePage(txtUserName.Text);
            //    homePage.Show();
            //    picLoginIcon.ImageLocation = "padlock.png";
            //}
            //else MessageBox.Show("Istifadəçi  adı və ya şifrə yalnışdır", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Error);
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            User FoundUser = VirtualDatabase.Users.Find(m => m.Username == username && m.Password == password);
            if (FoundUser != null)
            {
                HomePage homePage = new HomePage(FoundUser);
                homePage.Show();
            }
            else
            {
                MessageBox.Show("Istifadəçi  adı və ya şifrə yalnışdır", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnterEventColor(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            textbox.BackColor = Color.Green;
        }

        private void TextBoxLeaveEventColor(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            textbox.BackColor = Color.White;
        }

    }
}
