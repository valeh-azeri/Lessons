using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int AddNewCustomers(Customer customers)
        {
            VirtualDatabase.Customers.Add(customers);
            return 1;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer()
            {
                Id = Guid.NewGuid(),
                Name = txtName.Text,
                Surname = txtSurname.Text,
                FatherName = txtFatherName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhone.Text
            };

            int result = AddNewCustomers(newCustomer);
            if (result>0)
            {
                DialogResult answer = MessageBox.Show("Müştəri əlavə edildi. Basqa müştəri əlavə ediləcək ?",
                                                                                        "Məlumat",
                                                                                        MessageBoxButtons.YesNo,
                                                                                        MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    winNotif = new NotifyIcon();
                    winNotif.BalloonTipText = "Toplam müştəri sayısı" + VirtualDatabase.Customers.Count.ToString();
                    winNotif.BalloonTipTitle = "Müştəri məlumatı";
                    winNotif.Visible = true;
                    winNotif.ShowBalloonTip(4000);
                    winNotif.Icon = SystemIcons.Information;
                }
                else
                {
                    FillCustomersList();
                }
                Clearİnputs();
            }

        }
        private void Clearİnputs()
        {
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtFatherName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }

        private void FillCustomersList()
        {
            lstCustomer.DataSource = VirtualDatabase.Customers;
        }
    }
}
