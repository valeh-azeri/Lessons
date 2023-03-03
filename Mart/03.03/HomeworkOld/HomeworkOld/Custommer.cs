using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOld
{
    class Custommer
    {
        #region Virtual Database
        private static ArrayList database;
        #endregion

        #region Properties  
        public int Id{ get; set; }
        public string Name{ get; set; }
        public string Surname{ get; set; }
        public string Email{ get; set; }
        #endregion

        #region Encapsualtion
        public string _username; 
        public string _password;

        public string  Username {
            get
            {
                return this._username;
            }
            set
            {
                bool isUsernameDiblicate = CheckDublicateUsername(value);
                if (isUsernameDiblicate)
                {
                    Console.WriteLine("Istifadeci artiq qeydiyyatdan kecib");
                }
                else
                {
                    this._username = value;
                }
            }
        }

        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                bool isPasswordValidd = isPasswordValid(value);
                if (!isPasswordValidd)
                {
                    Console.WriteLine("Password 8 simvoldan  və ən azı 1  böyük hərf və  rəqəmdən olmalıdır.");
                } else 
                this._password = value;
            }
        }
        #endregion

        #region Cunstructor
        static Custommer()
        {
            database = new ArrayList();
        }
        

        #endregion

        #region Static methods
        static bool CheckDublicateUsername(string username)
        {
            for (int i = 0; i < database.Count; i++)
            {
                Custommer tempCustomer = (Custommer)database[i];
                if (tempCustomer.Username==username)
                {
                    return true;
                }
                
            }
            return false;
        }

        static bool isPasswordValid(string password)
        {
            bool valid = false;
            if (password.Length>=8)
            {
                bool upperLetter = false , number=false;
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsUpper(password[i]) && char.IsLetter(password[i]) && !upperLetter)
                    {
                        upperLetter = true;
                    }

                    if (char.IsNumber(password[i]) && !number)
                    {
                        number = true;
                    }
                }
                valid = (upperLetter && number);
            }
            return valid; 
        }

        static bool CheckDublicateEmail(string email)
        {
            for (int i = 0; i < database.Count; i++)
            {
                Custommer tempCustomer = (Custommer)database[i];
                if (tempCustomer.Username == email)
                {
                    return true;
                }

            }
            return false;
        }

        public static void AddCustomer(Custommer customer)
        {
            if (customer!=null && !string.IsNullOrEmpty(customer.Username) && !string.IsNullOrEmpty(customer.Email))
            {
                bool isEmailDublicate = CheckDublicateEmail(customer.Email);

                if (isEmailDublicate)
                {
                    Console.WriteLine("Email  artıq  sistemdə mövcuddur");
                }
                else
                {
                    database.Add(customer);
                    Console.WriteLine("Yeni müştəri sistemə əlavə  olundu");
                }
            }
        }
        #endregion
    }
}
