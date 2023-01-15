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
                Console.WriteLine((i+1) + "!=" +fakt+"*"+(i+1)+"="+ fakt*(i+1));

            }

            Console.WriteLine("_________________________");
            Console.WriteLine(girilenSay+"!=" + fakt);
            Console.ReadLine();
            
        }
    }
}
