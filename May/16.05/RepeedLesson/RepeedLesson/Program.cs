using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace RepeedLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();

            for (int i = 0; i < 100; i++)
            {
                Students tempStudent = new Students()
                {
                    Id = Guid.NewGuid(),
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    PhoneNumber = FakeData.PhoneNumberData.GetPhoneNumber(),

                 };

                students.Add(tempStudent);

            }

            XDocument doc = new XDocument(
                new XDeclaration("1.0","UTF-8", "yes"),
                new XElement("Students",
                    students.Select(m=>
                        new XElement("Student",
                            new XElement("Id",m.Id),
                            new XElement("Name", m.Name),
                            new XElement("Surname",m.Surname),
                            new XElement("PhoneNumber",m.PhoneNumber))))

                );

            doc.Save(@"C:\\XML\Studentss.xml");


        }
    }
}
