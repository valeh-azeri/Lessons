using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TaskInLesson1

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int examPoint = 0;
            string examPointString;
            Console.WriteLine("Bir dəyər girin");
            examPointString = Console.ReadLine();
            examPoint = Convert.ToInt32(Console.ReadLine());
            bool parsPoint = int.TryParse(examPointString, out examPoint);
            if (!parsPoint)
            {
                Console.WriteLine("Xahş edirik reqem daxil edin");
            }
            else if (parsPoint)
            {

            }


        }
    }
}
