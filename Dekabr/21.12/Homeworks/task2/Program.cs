using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i <= 100; i+=2)
            {
                sum = sum + i;

            }
            Console.WriteLine("Sum =" + sum);
            Console.ReadLine();
        }
    }
}
