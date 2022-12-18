using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInLesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1 

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Ayları rəqəmlə  girin :");
            int ayReqemle = Convert.ToInt32(Console.ReadLine());
            switch (ayReqemle)
            {
                case 1:Console.WriteLine("Yanvar"); break;
                case 2: Console.WriteLine("Fevral"); break;
                case 3: Console.WriteLine("Mart"); break;
                case 4: Console.WriteLine("Aprel"); break;
                case 5: Console.WriteLine("May"); break;
                case 6: Console.WriteLine("Iyun"); break;
                case 7: Console.WriteLine("Iyul"); break;
                case 8: Console.WriteLine("Avqust"); break;
                case 9: Console.WriteLine("Sentyabr"); break;
                case 10: Console.WriteLine("Oktyabr"); break;
                case 11: Console.WriteLine("Noyabr"); break;
                case 12: Console.WriteLine("Dekabr"); break;
                default: break;
                   

            }
            #endregion
            #region task 2

            Console.WriteLine("Paytaxtını bilmək istədiyiniz şəhər  adını girin");
            string city = Console.ReadLine();
            switch (city)
            {
                case "Azərbaycan": Console.WriteLine("Bakı"); break;
                case "Türkiyə": Console.WriteLine("Ankara"); break;
                case "Yaponiya": Console.WriteLine("Tokyo"); break;
                default: break;
            }
            #endregion

        }
    }
}
