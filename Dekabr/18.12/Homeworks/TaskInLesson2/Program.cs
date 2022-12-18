using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a, b, top, cix,vur, bol;
            int secim;
            Console.WriteLine("Aparacağınız işləmi seçin :");
            Console.WriteLine("1. Topla");
            Console.WriteLine("2. Çıx");
            Console.WriteLine("3. Vur");
            Console.WriteLine("4. Bol");

            secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1 || secim == 2 || secim==3 || secim==4)
                
                
            {
                Console.WriteLine("Birinci sayini girin :");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("İkinci sayini girin :");
                b = Convert.ToInt32(Console.ReadLine());

                if (secim==1)
                {
                    top = a + b;
                    Console.WriteLine(top);
                }

                else if (secim == 2)
                {
                    cix= a - b;
                    Console.WriteLine(cix);
                }

                else if (secim == 3)
                {
                    vur = a * b;
                    Console.WriteLine(vur);
                }

                else if (secim == 4)
                {
                    if (b<=0)
                    {
                        Console.WriteLine("0 a  bölmə  boş çoxluqdur");
                    } else {
                        bol = a / b;
                        Console.WriteLine(bol);
                    }
                    

                }
                Console.ReadLine();


            }

        }
    }
}
