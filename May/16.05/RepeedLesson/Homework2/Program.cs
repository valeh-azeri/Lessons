using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;


namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region  Show Teachers

            string pathTeacher = @"C:\\Homework1\Teachers.xml";

            bool chekTeacher = File.Exists(pathTeacher);
            if (!chekTeacher)
            {
                Console.WriteLine("Bu fayl  yaddasda movcud deyil");
            }

            XDocument docTecher = XDocument.Load(pathTeacher);
            List<XElement> rowsTeacher = docTecher.Descendants("Teacher").ToList();
            List<Teachers> teachers = new List<Teachers>();

            foreach (var item in rowsTeacher)
            {
                Teachers teacher = new Teachers()
                {
                    Id = Guid.Parse(item.Element("Id").Value),
                    Name = item.Element("Name").Value,
                    Surname = item.Element("Surname").Value,
                    Email = item.Element("Email").Value,
                    PhoneNumbe = item.Element("PhoneNumber").Value
                };

                teachers.Add(teacher);
            }

            Console.WriteLine("BURDA  MUELLIM ADLARIDIR");
            foreach (var item in teachers)
            {
                Console.WriteLine("Id : " + item.Id);
                Console.WriteLine("Name : " + item.Name);
                Console.WriteLine("Surname : " + item.Surname);
                Console.WriteLine("Email : " + item.Email);
                Console.WriteLine("Phone Number : " + item.PhoneNumbe);
                Console.WriteLine("_________________________________");

            }

            #endregion

            #region Show Students
            string pathStudent = @"C:\\Homework1\\Students.xml";
            XDocument docStudent = XDocument.Load(pathStudent);
            List<XElement> readStudent = docStudent.Descendants("Students").ToList();
            List<Student> students = new List<Student>();

            foreach (var item in readStudent)
            {
                Student student = new Student()
                {
                    Id = Guid.Parse(item.Element("Id").Value),
                    Name = item.Element("Name").Value,
                    Surname = item.Element("Surname").Value,
                    Email = item.Element("Email").Value,
                    PhoneNumbe = item.Element("PhoneNumber").Value
                };

                students.Add(student);
            }

            Console.WriteLine("BURDA  SAGIRD ADLARIDIR");

            foreach (var item in students)
            {
                Console.WriteLine("Id :" + item.Id);
                Console.WriteLine("Name :" + item.Name);
                Console.WriteLine("Surname :" + item.Surname);
                Console.WriteLine("Email :" + item.Email);
                Console.WriteLine("Phone Number :" + item.PhoneNumbe);
            }

            #endregion

            #region Stuffs

            string pathStuffs = @"C:\\Homework1\\Stuffs.xml";
            XDocument docStuffs = XDocument.Load(pathStuffs);
            List<XElement> readstuffs = docStuffs.Descendants("Stuffs").ToList();
            List<Stuffs> stuffs = new List<Stuffs>();

            foreach (var item in readstuffs)
            {
                Stuffs tempstuff = new Stuffs()
                {
                    Id = Guid.Parse(item.Element("Id").Value),
                    StuffName=item.Element("Name").Value,
                    StuffColor=item.Element("Color").Value,
                    StuffMark=int.Parse(item.Element("Mark").Value),
                    StaffStock=item.Element("Stock").Value

                };
                stuffs.Add(tempstuff);
            }
            Console.WriteLine("BURDA  STUFFLAR  GOSTERILECEK");


            foreach (var item in stuffs)
            {
                Console.WriteLine("Id :"+item.Id);
                Console.WriteLine("Name :"+item.StuffName);
                Console.WriteLine("Color :"+item.StuffColor);
                Console.WriteLine("Mark :"+item.StuffMark);
                Console.WriteLine("Stok :"+item.StaffStock);
    
            }
            Console.ReadLine();
            
            #endregion

        }
    }
}
