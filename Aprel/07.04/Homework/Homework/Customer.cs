﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Customer
    {
        //Ad, Soyad, Cinsiyyət, Ölkə, Şəhər, Ünvan, Telefon, Email

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Gender { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            string FullName = Name + " " + Surname;
            return FullName;
        }


        

      
    }
    
}
