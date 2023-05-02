using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DataGenerate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        VirtualDataBase db = new VirtualDataBase();
        private void btnGeneratePerson_Click(object sender, EventArgs e)
        {
           
            List<Persons> persons = db.GetPersons(1000);

            

            dtGridPerson.DataSource = persons;
        }
    }
}
