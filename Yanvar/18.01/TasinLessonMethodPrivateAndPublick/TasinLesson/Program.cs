using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasinLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Student instStud = new Student();
            instStud.SaySalam();
            instStud.SayNece();
            Console.ReadLine();
        }
    }
}
