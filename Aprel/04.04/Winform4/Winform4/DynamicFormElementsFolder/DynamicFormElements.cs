using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform4.DynamicFormElementsFolder
{
    public partial class DynamicFormElements : Form
    {
        public DynamicFormElements()
        {
            InitializeComponent();
        }

        private void btnCreatNewButton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 50; i++)
            {
                Button btnTemp = new Button();
                btnTemp.Name = $"btn{i.ToString()}";
                btnTemp.Size = new Size(35, 35);
                btnTemp.Text = i.ToString();
                btnTemp.UseVisualStyleBackColor = true;
                btnTemp.Click += ShowButtonContents;
                buttonsPanel.Controls.Add(btnTemp);
            }
        }

        public void ShowButtonContents(object sender, EventArgs e)
        {
            string text = ((Button)sender).Text;
            MessageBox.Show("Clicked olunan button text : " + text);
        }

        private void btnCreatNewTextbox_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 20; i++)
            {
                TextBox btnTemp = new TextBox();
                btnTemp.Size = new Size(100, 35);
                btnTemp.Text = "Some Text"+i.ToString();
                textBoxPannel.Controls.Add(btnTemp);
            }
        }
    }
}
