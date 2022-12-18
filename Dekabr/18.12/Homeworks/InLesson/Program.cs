using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal d;

            Console.WriteLine("Birinci Sayini  girin");
            decimal a = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ikinci Sayini  girin");
            decimal c = Convert.ToDecimal(Console.ReadLine());

            d = a;
            c = d;
            d = c;
            c = a;
            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.ReadLine();

        }
    }
}
