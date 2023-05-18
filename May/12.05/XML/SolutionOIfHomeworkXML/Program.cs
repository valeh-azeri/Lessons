using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace SolutionOIfHomeworkXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextWriter studentXml = new XmlTextWriter(@"C:\\XML\\Students.xml", UTF8Encoding.UTF8);
            studentXml.WriteComment("Tələbə məlumatları");

            studentXml.WriteStartElement("Students");

                studentXml.WriteComment("Tələbə 1");
                studentXml.WriteStartElement("Student");
                studentXml.WriteAttributeString("Id", "1");
                studentXml.WriteElementString("Name ", "Valeh");
                studentXml.WriteElementString("Surname", "Suleymanov");
                studentXml.WriteElementString("Gender", "Male");
                studentXml.WriteElementString("Birthday", "23.10.1982");
                studentXml.WriteElementString("Degree", "Master");
                studentXml.WriteComment("Address");
                    studentXml.WriteStartElement("Contact");
                        studentXml.WriteElementString("Address", "Azerbaycan? Baki? Yasamal");
                        studentXml.WriteElementString("Telefon", "077-271-75-40");
                    studentXml.WriteEndElement();
                studentXml.WriteEndElement();


            studentXml.WriteComment("Tələbə 2");
            studentXml.WriteStartElement("Student");
            studentXml.WriteAttributeString("Id", "2");
            studentXml.WriteElementString("Name", "Ehmed");
            studentXml.WriteElementString("Surname", "Suleymanov");
            studentXml.WriteElementString("Gender", "Male");
            studentXml.WriteElementString("Birthday", "23.10.1982");
            studentXml.WriteElementString("Degree", "Master");
            studentXml.WriteComment("Address");
            studentXml.WriteStartElement("Contact");
            studentXml.WriteElementString("Address", "Azerbaycan? Baki? Yasamal");
            studentXml.WriteElementString("Telefon", "077-271-75-40");
            studentXml.WriteEndElement();
            studentXml.WriteEndElement();

            studentXml.WriteComment("Tələbə 3");
            studentXml.WriteStartElement("Student");
            studentXml.WriteAttributeString("Id", "3");
            studentXml.WriteElementString("Name", "Akif");
            studentXml.WriteElementString("Surname", "Ehedov");
            studentXml.WriteElementString("Gender", "Male");
            studentXml.WriteElementString("Birthday", "23.10.1982");
            studentXml.WriteElementString("Degree", "Master");
            studentXml.WriteComment("Address");
            studentXml.WriteStartElement("Contact");
            studentXml.WriteElementString("Address", "Azerbaycan? Baki? Yasamal");
            studentXml.WriteElementString("Telefon", "077-271-75-40");
            studentXml.WriteEndElement();
            studentXml.WriteEndElement();

            studentXml.WriteEndElement();
            studentXml.Close();

            XmlReader read = XmlReader.Create(@"C:\\XML\Students.xml");
            while (read.Read())
            {
                Console.WriteLine($"{read.Name} :{read.Value}");
            }

            XDocument Xdocument = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XComment("Telebe 2"),
                new XElement("Student",
                new XAttribute("Id", "2"),
                new XElement("Name", "Tural"),
                new XElement("Birthday", "11.11.1984"),
                new XElement("Gender", "Male"),
                new XElement("Degree", "Junior"),
                    new XElement("Contacts",
                        new XElement("Address", "Mingecevir bla bla"),
                        new XElement("Phone", "077-271-75-40")
                        )
                )
                );
            Xdocument.Save(@"C:\\XML\\Customers.xml");
        } 
    } 
}
