using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Sinifdə neçə  tələbə var");
            short studentCount = Convert.ToInt16(Console.ReadLine());

            string[] student = new string[studentCount];

            for (int i = 0; i < student.Length; i++)
            {
                Console.Write(i + 1 + " Tələbənin  adını girin :");
                string studentName = Console.ReadLine();
                student[i]=studentName;

            }

            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine(i+1+" telebe :"+student[i]);
            }
            Console.ReadLine();
        }
    }
}
