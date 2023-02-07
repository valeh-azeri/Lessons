using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Programdan çıxma  sözünü tapana qədər soz girin :");
            string key=Console.ReadLine().ToLower();
            while (key!="exit")
            {
                Console.WriteLine("Açar  söz deyil bir  de girin :");
                key = Console.ReadLine();
            }            
            Console.ReadLine();

        }
    }
}
