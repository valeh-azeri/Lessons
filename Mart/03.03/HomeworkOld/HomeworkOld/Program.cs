using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOld
{
    class Program
    {
        static void Main(string[] args)
        {
            Custommer customer1 = new Custommer();

            customer1.Id = 1;
            customer1.Name = "Valeh";
            customer1.Surname = "Suleymanov";
            customer1.Email = "sadiqkor@hotmaill.com";
            customer1.Username = "Valeh";
            customer1.Password = "1";

            Custommer.AddCustomer(customer1);

            Custommer customer2 = new Custommer();

            customer2.Id = 2;
            customer2.Name = "Valeh";
            customer2.Surname = "Suleymanov";
            customer2.Email = "sadiqkor@hotmaill.com";
            customer2.Username = "Valeh";
            customer2.Password = "1sdfkTaksd";

            Custommer.AddCustomer(customer1);

            Custommer Dublicatecustomer2 = new Custommer();

            Dublicatecustomer2.Id = 2;
            Dublicatecustomer2.Name = "Valeh";
            Dublicatecustomer2.Surname = "Suleymanov";
            Dublicatecustomer2.Email = "sadiqkor@hotmaill.com";
            Dublicatecustomer2.Username = "Valeh";
            Dublicatecustomer2.Password = "1sdfkTaksd";

            Custommer.AddCustomer(customer1);


        }
    }
}
