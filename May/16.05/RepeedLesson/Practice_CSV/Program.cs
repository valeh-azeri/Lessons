using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace Practice_CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customers> customer = new List<Customers>();

            for (int i = 0; i < 200; i++)
            {
                Customers tempCustomer = new Customers();
                tempCustomer.Id = Guid.NewGuid();
                tempCustomer.Name = FakeData.NameData.GetFirstName();
                tempCustomer.Surname = FakeData.NameData.GetSurname();
                tempCustomer.Email = $"{tempCustomer.Name}.{tempCustomer.Surname}@{FakeData.NetworkData.GetDomain()}";
                tempCustomer.PhoneNumber = FakeData.PhoneNumberData.GetInternationalPhoneNumber();
                tempCustomer.Country = FakeData.PlaceData.GetCounty();

                customer.Add(tempCustomer);
                
            }

            bool checkDirectory = Directory.Exists(@"C:\\CSV");
            if (!checkDirectory)
            {
                Directory.CreateDirectory(@"C:\\CSV");
            }

            bool checkFile = File.Exists(@"C:\\CSV\\Customers.csv");
            if (!checkFile)
            {
                var file=File.Create(@"C:\\CSV\\Customers.csv");
                file.Close();
            }

            StreamWriter writeCSV = new StreamWriter(@"C:\\CSV\\Customers.csv");
            CsvHelper.CsvWriter write = new CsvWriter(writeCSV);

            write.WriteHeader(typeof(Customers));

            foreach (var item in customer)
            {
                write.WriteRecord(item);
            }

            writeCSV.Close();


            //API den data  gelmis olsaydi 

            StreamReader readCSV = new StreamReader(@"C:\\CSV\\Customer.csv");
            CsvHelper.CsvReader reader = new CsvHelper.CsvReader(readCSV);

            List<Customers> readcustomer = reader.GetRecords<Customers>().ToList();

        }
    }
}
