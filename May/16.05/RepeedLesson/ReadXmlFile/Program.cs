using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;


namespace ReadXmlFile
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument readXml = XDocument.Load(@"C:\\XML\Studentss.xml");
            List<XElement> elements = readXml.Descendants("Students").ToList();

            List<Student> readStudents = new List<Student>();
           

            foreach (var item in elements)
            {
                Student student = new Student()
                {
                    Id = Guid.Parse(item.Element("Id").Value),
                    Name = item.Element("Name").Value,
                    Surname = item.Element("Surname").Value,
                    Email = item.Element("Email").Value,
                    PhoneNumber=item.Element("PhoneNumber").Value

                };
                readStudents.Add(student);
            }

            foreach (var item in readStudents)
            {
                Console.WriteLine("Id :"+item.Id);
                Console.WriteLine("Name :"+item.Name);
                Console.WriteLine("Surname :"+item.Surname);
                Console.WriteLine("Phone Numeber :"+item.PhoneNumber);
            }

            Console.Read();
        }


    }
}
