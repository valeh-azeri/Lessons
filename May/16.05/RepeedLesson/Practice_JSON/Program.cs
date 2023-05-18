using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace Practice_JSON
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Customers> customerss = new List<Customers>();
            for (int i = 1; i < 100; i++)
            {
                Customers tempCustomer = new Customers();


                tempCustomer.Id = Guid.NewGuid();
                tempCustomer.Name = FakeData.NameData.GetFirstName();
                tempCustomer.Surname = FakeData.NameData.GetSurname();
                tempCustomer.Email = $"{tempCustomer.Name}.{tempCustomer.Surname}@{FakeData.NetworkData.GetDomain()}";
                tempCustomer.PhoneNumber = FakeData.PhoneNumberData.GetInternationalPhoneNumber();
                tempCustomer.Country = FakeData.PlaceData.GetCountry();

                customerss.Add(tempCustomer);
            }

            bool checkDirectory = Directory.Exists(@"C:\\JSON");
            if (!checkDirectory)
            {
                Directory.CreateDirectory(@"C:\\JSON");
            }

            bool checkFile = File.Exists(@"C:\\JSON\\Customers.json");
            if (!checkDirectory)
            {
                File.Create(@"C:\\JSON\\Customers.json");
            }

            string jsonCustomers = JsonConvert.SerializeObject(customerss);

            File.WriteAllText(@"C:\\JSON\\Customers.json", jsonCustomers);

            string readJson = File.ReadAllText(@"C:\\JSON\\Customers.json");

            List<XObject> data = JsonConvert.DeserializeObject<List<XObject>>(readJson);

            foreach (var item in data)
            {
                Console.WriteLine("Id :"+item.Id);
                Console.WriteLine("Name :"+item.Name);
                Console.WriteLine("Surname :"+item.Surname);
                Console.WriteLine("Email :"+item.Email);
                Console.WriteLine("Phone Number :"+item.PhoneNumber);
                Console.WriteLine("Country :"+item.Country);
                Console.WriteLine("________________________");
                
            }
            Console.ReadLine();
        }

    }
}
