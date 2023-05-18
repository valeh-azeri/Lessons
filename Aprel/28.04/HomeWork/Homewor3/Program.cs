using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewor3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            /* Homework 3:
            Bir dənə int array'ında 1-1000 arası rəqəmləriniz olsun (for ilə edin).
            1. Array'dan cüt rəqəmləri sorğu ilə götürün.
            2. Arrayda 400-dən böyük, 550-yə bərabər və ya kiçik olan, tək rəqəmləri götürün.*/
            Random rand = new Random();
            int[] numbers = new int[1000]; 
            
            
            for (int i = 1; i < 1000; i++)
            {
                numbers[i - 1] = rand.Next(1001);
                Console.Write(numbers[i-1]+",");
            }

            Console.WriteLine();
            Console.WriteLine("___________________");
            Console.WriteLine("CÜTLƏR");

            var cut = numbers.Where(m => m%2==0);
            foreach (var item in cut)
            {
                Console.Write(item+",");
            }
            Console.WriteLine();
            Console.WriteLine("___________________");
            Console.WriteLine("TƏKLƏR");
            var tek = numbers.Where(m => m %2!= 0);

            foreach (var item in tek)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
            Console.WriteLine("___________________");
            Console.WriteLine("400 dən böyük 550 dən kiçik cütlər");
            var greaterThanFiveHundred = numbers.Where(predicate: m =>m > 400  && m <= 550 && m % 2 != 0);
            foreach (var item in greaterThanFiveHundred)
            {
                Console.Write(item + ",");
            }

            Console.ReadLine();

        }

        
    }
}
