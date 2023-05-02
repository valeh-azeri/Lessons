using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            txtID.Text = rnd.Next(4,20).ToString();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            VirtualDatabase.CustomerTable.Add(
                new Customer {
                Id = Convert.ToInt32(txtID.Text),
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Gender = 0,
                Country = "Azerbaycan",
                City = "Mingəçevir",
                Adress = "C. Əliyev 26 mən 41",
                PhoneNumber = "+994772717540",
                Email = "kimyagersual@gmail.com",
            });


            //add.Name = txtName.Text;
            //add.Surname = txtSurname.Text;
            //add.Gender = Convert.ToInt32(txtGender.Text);
            //add.Adress = txtAddress.Text;
            //add.Email = txtEmail.Text;


        }
    }
}
