using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    
    class Customer
    {
        
        private string _username;
        private string _password;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Surname { get; set; }
        public string Username {
            get
            {
                return this._username;
            }
            set
            {

                _username = Username;       
            }
        }
        public string Password {
            get
            {
                return _password;
            }
            set
            {
                if (value !=null )
                {
                    if (value.Length>8)
                    {
                        Console.WriteLine("Sifre 8 karakterden  boyuk olmamalidir");
                    }
                    else
                    {
                           
                    }
                }
                Console.WriteLine("Sifre bos olmamalidir");
            }
        }

        public void AddNewCustomer(Customer customer)
        {
            if (DataBase.Contains(customer))
            {
                Console.WriteLine("Bu istifadeci Artiq  movcuddur");
            }
            else
            {

                DataBase.Add(customer);
                Console.WriteLine("Istifadeci Bazaya elave olundu");
            }

        }

        private static ArrayList DataBase;
        
        

    }


}
