using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class VirtualDatabase
    {
        public static List<Customer> CustomerTable = new List<Customer>
        {
            new Customer()
            {
                Id=1,
                Name="Valeh",
                Surname="Suleymanov",
                Gender=0,
                Country="Azerbaycan",
                City="Mingəçevir",
                Adress="C. Əliyev 26 mən 41",
                PhoneNumber="+994772717540",
                Email="kimyagersual@gmail.com",
            },
            new Customer()
             {
                Id=2,
                Name="Tural",
                Surname="Suleymanov",
                Gender=0,
                Country="Azerbaycan",
                City="Bakı",
                Adress="C. Əliyev 26 mən 41",
                PhoneNumber="+994772717541",
                Email="sadiqkor@gmail.com",
            },
            new Customer()
              {
                Id=3,
                Name="Reyhan",
                Surname="Suleymanı",
                Gender=1,
                Country="Azerbaycan",
                City="Sumqayıt",
                Adress="C. Əliyev 26 mən 41",
                PhoneNumber="+994772717543",
                Email="sadiqkor@hotmail.com",
            },
        };
    }
}
