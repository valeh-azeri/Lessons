using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeworkForInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Homework 1: c# inheritance mövzusunu araşdırın.

            Homework 2:
            Aşağıda yazdığım class'ların property'lərini base class'a çıxardıb inherit almaq lazımdır. 
            Nəyi necə edəcəyinizə qarışmıram özünüz qərar verin...
            Employee: Id, ReferanceNumber, DocumentNumber, Name, Surname, Gender, DateOfStartWorking, DateOfEndWorking, RestDays, RegUser, RegDate, EditUser, EditDate, Deleted
            Teacher: Id, ReferanceNumber, DocumentNumber, Name, Surname, Gender, DateOfStartWorking, DateOfEndWorking, RestDays, Branch, Level, RegUser, RegDate, EditUser, EditDate, Deleted
            Student: Id, ReferanceNumber, DocumentNumber, Name, Surname, Gender, Department, Level, RegUser, RegDate, EditUser, EditDate, Deleted
            */

            Teacher teacher = new Teacher();
            teacher.Id = 1;
            teacher.ReferanceNumber = 25;
            teacher.DocumentNumber = 111222;
            teacher.Name = "Valeh";
            teacher.Suname = "Suleymanov";
            teacher.Gender = "Man";
            teacher.DateOfStartWorking = new DateTime(23,10,2020);
            teacher.DateOfEndWorking = new DateTime(23, 10, 2023);
            Student student = new Student();
            Employer employer = new Employer();
        }
    }
}
