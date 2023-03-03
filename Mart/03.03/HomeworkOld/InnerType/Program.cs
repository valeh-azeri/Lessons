using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customer = new Customers()
            {
                Id = 1,
                Name = "Valeh",
                Surname = "Suleymanov",
                DocumentNo = 123123,
                CreatDate = DateTime.Now,
                EditDate = null

            };

            Country country = new Country()
            {
                Id=1,
                Name="Azərbaycan",
                CreatDate = DateTime.Now,
                
            };

            City city = new City()
            {
                Id = 1,
                Name = "Baku",
                Country = country,
                CreatDate = DateTime.Now,
                
            };

            Order LaptopTap = new Order()
            {
                Id=1,
                OrderDetails="Asus Tuf, 3500AZN",
                CreatDate = DateTime.Now
            };

            customer.Adress[0] = new Adress()
            {
                Id = 1,
                No = 15,
                Building = "My building",
                Street = "My street",
                Distinct = "My Distinct",
                City = city,
                CreatDate =DateTime.Now,
            };

            customer.Adress[1] = new Adress()
            {
                Id = 1,
                No = 15,
                Building = "My Residance",
                Street = "Work street",
                Distinct = "Work Distinct",
                City = city,
                CreatDate = DateTime.Now,
            };

            customer.Contacts[0] = new Contact()
            {
                Id=1,
                Email="qaqashqaqash@gmail.com",
                PhoneNumber="+994772717540",
                CreatDate=DateTime.Now
            };

            customer.Orders[0] = new Order()
            {
                Id=2,
                OrderDetails="Samsung Galaxy S9+, 6000AZN",
                ShippingAdress=customer.Adress[1],
                CreatDate=DateTime.Now

            };
            customer.Orders[1]=LaptopTap;

           customer.ShowAdress();
        }
    }
}
