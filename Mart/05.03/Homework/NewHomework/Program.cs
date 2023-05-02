using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Homework:
              Person class'ında Id, Name, Surname, Age property'ləriniz olsun. Student class'ında da 
              ClassName (yəni sinif adı) TeacherName property'ləri olacaq. Student class'ı da Person class'ından miras alacaq.

              Person class'ında Id, Name, Surname property'lərinin dəyərini ekrana yazdıran ShowInfo() 
              adlı virtual void method'unuz  olsun. Student class'ında da bu method'u override edib, 
              ClassName və TeacherName property'lərini də ekrana yazdırın.
             */

            Person pr = new Person();
            pr.Id = 1;
            pr.Name = "Valeh";
            pr.Surname = "Suleymanov";
            pr.ShowInfo();

            Student st = new Student();
            st.Id = 2;
            st.Name = "Maral";
            st.Surname = "Ismailova";
            st.ClassName = "11B";
            st.TeacherName = "Akif m ";

            st.ShowInfo();
            
        }
    }
}
