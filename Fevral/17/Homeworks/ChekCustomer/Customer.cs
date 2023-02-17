using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChekCustomer
{
    class Customer
    {
        public string Name;
        public string Surname;
        public string DocumentSerial;
        public string DocumentNumber;
        public string Address;

        public Customer(string documentNumber, string documentSerial, string name, string surname, string address)
        {
            DocumentNumber = documentNumber;
            DocumentSerial = documentSerial;
            Name = name;
            Surname = surname;
            Address = address;
        }

        internal bool CheckCustomerFromDb()
        {
            string[] customers = new string[] { "Orkhan", "Valeh", "Gunel" };
            return customers.Contains(Name);
        }

        internal bool CheckCustomer()
        {
            bool result = CheckCustomerFromDb();
            return result;
        }

        public void Register()
        {
            Console.WriteLine("Qeydiyyatdan kecirildi!");
        }
    }
}
