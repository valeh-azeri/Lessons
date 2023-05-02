using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomework
{
    public class Student :Person
    {
        public string  ClassName { get; set; }
        public string  TeacherName { get; set; }

        public override void ShowInfo()
        {
            //base.ShowInfo();
            Console.WriteLine("ID: " + Id + "\n Name :" + Name + "\n Surname: " + Surname+"\n  Class Name :"+ClassName+"\n Teacher Name :"+TeacherName);
        }
    }
}
