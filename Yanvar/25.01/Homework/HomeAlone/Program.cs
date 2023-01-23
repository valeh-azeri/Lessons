using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAlone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string[] nameSt = new string[10];
            string[] surnameSt = new string[10];
            int i = 0;

            int[] markSt1 = new int[10];
            int[] markSt2 = new int[10];
            int[] markSt3 = new int[10];
            decimal[] avarageSt = new decimal[10];
            string[] statusAvarage = new string[10];
            
        Begin:
            Console.Clear();
            StudenAvarageRate studentAvarageRate = new StudenAvarageRate();

            Console.Write("Adınızı girin: ");
            string name = Console.ReadLine();
            nameSt[i] = name;
            
            Console.Write("Soyadınızı girin: ");
            string surname = Console.ReadLine();
            surnameSt[i] = surname;
           

            Console.Write("Birinci sınaq nəticənizi girin: ");
            int mark1 = 0;
            bool mark1Bool = int.TryParse(Console.ReadLine(), out mark1);
            markSt1[i] = mark1;


            Console.Write("Ikinci sınaq nəticənizi girin: ");
            int mark2 = 0;
            bool mark2Bool = int.TryParse(Console.ReadLine(), out mark2);
            markSt2[i] = mark2;

            Console.Write("Üçüncü sınaq nəticənizi girin: ");
            int mark3 = 0;
            bool mark3Bool = int.TryParse(Console.ReadLine(), out mark3);
            markSt3[i] = mark3;

            string resultAvarage = studentAvarageRate.RateAvarage(mark1, mark2, mark3, name, surname).ToString();
            statusAvarage[i] = resultAvarage;

            avarageSt[i] = studentAvarageRate.CalcAvarage(mark1, mark2, mark3);
            i++;

            //studentAvarageRate.CalcAvarage(mark1, mark2, mark3);
            studentAvarageRate.RateAvarageShow(mark1,mark2,mark3,name,surname);
            

            Console.WriteLine();
            Console.WriteLine("Davam etmək istəyirsiniz ? H/Y");
            string chois = Console.ReadLine();

            if (chois.ToUpper() == "H")
            {
                goto Begin;
            }
            else
            {
                for (int j = 0; j < nameSt.Length; j++)
                {
                    Console.WriteLine("Adınız : " + nameSt[j] + " Soyadınız: " + surnameSt[j]+" Sınaq1 : "+markSt1[j]+" Sınaq2 : "+markSt2[j]+" Sınaq3 : "+markSt3[j]+" Ortalamanız :"+avarageSt[j]+" Nəticəniz :"+statusAvarage[j]);
                }
            }


            Console.ReadLine();
        }
    }
}
