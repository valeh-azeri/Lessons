using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    class Customers
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Surname { get; set; }
        public int DocumentNo { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime CreatDate { get; set; }
        public DateTime? EditDate { get; set; }


        #region Inner Types required fields
        public Contact[] Contacts;
        public Adress[] Adress;
        public Order[] Orders;
        #endregion

        public Customers()
        {
            Contacts = new Contact[100];
            Adress = new Adress[100];
            Orders = new Order[100];
        }

        public void ShowAdress()
        {
            foreach (var item in Adress)
            {
                if (item!=null)
                {
                    Console.WriteLine("Id" + item.Id);
                    Console.WriteLine("Street" + item.Street);
                    Console.WriteLine("City :" + item.City.Name);
                    Console.WriteLine("Coutry :" + item.City.Country.Name);
                    if (item.EditDate == null)
                    {
                        Console.WriteLine("Data is not edited");
                    }
                    else
                    {
                        Console.WriteLine("Edit Date :" + item.EditDate);
                    }
                }
               
            }
        }


    }
}
