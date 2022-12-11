using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskİnLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime DateNow = DateTime.Now;
            DateTime Date2020 = DateTime.Now;
            Date2020.AddDays(13);
            Console.WriteLine(DateNow);
            Console.WriteLine(Date2020);
            Console.Read();
        }
    }
}
