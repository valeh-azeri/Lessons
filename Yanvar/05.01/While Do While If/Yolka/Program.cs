using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolka
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 20; i > 1; i--)
            {
                for (int j = i ; j > 1; j--)
                {
                  
                    Console.Write("*"); Console.WriteLine("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
