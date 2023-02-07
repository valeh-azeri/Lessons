using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            int fakt=1, girilenSay ;
            Console.Write("Faktorialını tapmaq istədiyiniz sayi  girin : ");
            girilenSay = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=girilenSay; i++)
            {
                fakt = fakt * i;
                

            }

            for (int i = 1; i <= girilenSay; i++)
            {
                Console.Write(i);
                Console.Write("*");
            }
            
            Console.WriteLine("=" + fakt);
            Console.ReadLine();
            
        }
    }
}
