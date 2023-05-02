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
    public partial class CustomerBase : Form
    {
        public CustomerBase()
        {
            InitializeComponent();
        }

        private void CustomerBase_Load(object sender, EventArgs e)
        {
            FillCustomers();
        }

        public void FillCustomers()
        {
            foreach (var item in VirtualDatabase.CustomerTable)
            {
                
                cmBoxCustomers.Items.Add(item);
            }
        }
        int customerId;
        private void cmBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            object ob1 = cmBoxCustomers.SelectedItem;
            Customer customer = (Customer)ob1;

            txtName.Text = customer.Name;
            txtSurname.Text = customer.Surname;
            if (customer.Gender==0)
            {
                txtGender.Text = "Kişi";
            }else
            txtGender.Text = "Qadın";

            txtCountry.Text = customer.Country;
            txtCity.Text = customer.City;
            txtPhone.Text = customer.PhoneNumber;
            txtAddress.Text = customer.Adress;
            txtEmail.Text = customer.Email;

            customerId = customer.Id;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var editUser = VirtualDatabase.CustomerTable.Find(m => m.Id == customerId);

            editUser.Name = txtName.Text;
            editUser.Surname = txtSurname.Text;
            if (txtGender.Text=="Kişi")
            {
                editUser.Gender = 0;
            }else
                editUser.Gender = 1;
            editUser.Country = txtCountry.Text;
            editUser.City = txtCity.Text;
            editUser.Adress = txtAddress.Text;
            editUser.Email = txtEmail.Text;
            cmBoxCustomers.Items.Clear();
            FillCustomers();
            MessageBox.Show("Dəyişiklik qeyd edildi", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var deleteUser = VirtualDatabase.CustomerTable.Find(m => m.Id == customerId);
            DialogResult result=MessageBox.Show("Silmək istədiyinizdən əminsiniz?", "Diqqət", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                VirtualDatabase.CustomerTable.Remove(deleteUser);
                cmBoxCustomers.Items.Clear();
                FillCustomers();
            }
            
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer adCustom = new AddCustomer();
            adCustom.ShowDialog();
        }
    }
}
