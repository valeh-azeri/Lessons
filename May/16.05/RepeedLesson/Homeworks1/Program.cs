using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;



namespace Homeworks1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Homework 1:
             FakeData'dan istifadə edib 3 XML faylı üzərində iş görəcəksiniz. Students, 
             Teachers və Stuffs adında 3 XML faylına dinamik
             olaraq məlumat əlavə edəcəksiniz. Proqramı run edəndə, hər faylın içinə 1000 nəfər insan məlumatı 
             əlavə edilməlidir. Student,
             Teacher və Stuff property'lərini özünüz seçə bilərsiniz. Ancaq hər birində ən az 5 property olsun.
            */
            List<Teachers> teachers = new List<Teachers>();
            List<Students> students = new List<Students>();
            List<Stuffs> stuffs = new List<Stuffs>();

            string directory = "C:\\Homework1";

            bool checkDirectory = Directory.Exists(directory);
            if (!checkDirectory)
            {
                Directory.CreateDirectory(directory);
            }

            string filenameTeacher = "Teachers.xml";
            string filenameStudent = "Students.xml";
            string filenameStuffs = "Stuffs.xml";

            string pathTeacher = directory + "\\" + filenameTeacher;
            string pathStudent = directory + "\\" + filenameStudent;
            string pathStuffName = directory + "\\" + filenameStuffs;

            


            #region Add Techers

            for (int i = 1; i < 1000; i++)
            {
                Teachers tempTeacher = new Teachers()
                {
                    Id = Guid.NewGuid(),
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    Email =FakeData.NetworkData.GetEmail(),
                    PhoneNumbe=FakeData.PhoneNumberData.GetInternationalPhoneNumber()
                };

                teachers.Add(tempTeacher);
            }

            bool checkFileTeacher = File.Exists(pathTeacher);
            if (!checkFileTeacher)
            {
                var fileTeacher=File.Create(pathTeacher);
                fileTeacher.Close();
            }
            
            XDocument doc = new XDocument(
                new XDeclaration("1.0","UTF-8","yes"),
                new XElement("Teachers",
                teachers.Select(m=>
                    new XElement("Teacher",
                    new XElement("Id", m.Id),
                    new XElement("Name", m.Name),
                    new XElement("Surname",m.Surname),
                    new XElement("Email", m.Email),
                    new XElement("PhoneNumber",m.PhoneNumbe))))

                );

            doc.Save(pathTeacher);

            #endregion\

            #region Add Students

            for (int i = 1; i < 1000; i++)
            {
                Students tempStudent = new Students()
                {
                    Id=Guid.NewGuid(),
                    Name=FakeData.NameData.GetFirstName(),
                    Surname=FakeData.NameData.GetSurname(),
                    Email=FakeData.NetworkData.GetEmail(),
                    PhoneNumbe=FakeData.PhoneNumberData.GetInternationalPhoneNumber()
                };
                students.Add(tempStudent);
            }

            bool checkStudent = File.Exists(pathStudent);
            if (!checkStudent)
            {
                var fileStudent=File.Create(pathStudent);
                fileStudent.Close();
            }
            XDocument docStudent = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("Students",
                students.Select(m =>
                    new XElement("Students",
                    new XElement("Id", m.Id),
                    new XElement("Name", m.Name),
                    new XElement("Surname",m.Surname),
                    new XElement("Email", m.Email),
                    new XElement("PhoneNubber", m.PhoneNumbe)))

                    ));

            docStudent.Save(pathStudent);
            #endregion

            #region Add Stuffs

            bool checkFileStuffs = File.Exists(pathStuffName);
            if (!checkFileStuffs)
            {
                var fileStuffs=File.Create(pathStuffName);
                fileStuffs.Close();
            }

            for (int i = 1; i < 1000; i++)
            {
                Stuffs tempstuffs = new Stuffs()
                {
                    Id = Guid.NewGuid(),
                    StuffName=FakeData.NameData.GetCompanyName(),
                    StuffColor=FakeData.PlaceData.GetStreetName(),
                    StuffMark=FakeData.NumberData.GetNumber(),
                    StaffStock=FakeData.NumberData.GetNumber().ToString()
                };

                stuffs.Add(tempstuffs);
            }

            XDocument docStuffs = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("Stuffs",
                stuffs.Select(m =>
                    new XElement("Stuffs",
                    new XElement("Id", m.Id),
                    new XElement("Name", m.StuffName),
                    new XElement("Color", m.StuffColor),
                    new XElement("Mark", m.StuffMark),
                    new XElement("Stok", m.StaffStock))))

                );

            docStuffs.Save(pathStuffName);


            #endregion\



        }
    }
}
