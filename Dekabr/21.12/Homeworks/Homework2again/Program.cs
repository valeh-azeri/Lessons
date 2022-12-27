using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2again
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Homework 2:
             Switch -case ilə sadə kalkulyator app'ı yazacaqsız. İlk öncə istifadəçiyə kiçik menyu çıxardın. 
             Orda edə biləcəyi əməliyyatlar olacaq.Toplama, çıxma, vurma
            və bölmə.İstifadəçi hansını seçsə həmin case'də ekrana nəticəni çıxardacaqsız. 
             Nəticəni göstərəndən sonra aşağıda yenidən ana menyunu göstərəcəksiz. İstifadəçi
             istədiyi qədər yəni proqramı bağlayana qədər bu döngü halında davam edəcək.
             */
            string choise;
            decimal result;
            
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Clear();
            Console.WriteLine("Bu app Kiçik bir Kalkulyatordur");
            Console.WriteLine("_______________________________");
            Console.WriteLine("1 ci sayını girin : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2 ci sayını girin : ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Xahiş edirəm  işləminizi seçin");
            Console.WriteLine("_______________________________");
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Çıxma");
            Console.WriteLine("3. Vurma");
            Console.WriteLine("4. bölmə");
            Console.WriteLine("_______________________________");
            choise = Console.ReadLine();

            switch (choise)
            {
                

                case "Menyu":
                    
                   
                    Console.WriteLine("_______________________________");
                    Console.WriteLine("1. Toplama");
                    Console.WriteLine("2. Çıxma");
                    Console.WriteLine("3. Vurma");
                    Console.WriteLine("4. bölmə");
                    Console.WriteLine("_______________________________");
                    Console.WriteLine("Xahiş edirəm  işləminizi seçin");
                    choise = Console.ReadLine();
                    if (choise == "1")
                    {
                        goto case "1";

                    }
                    else if (choise == "2")
                    {
                        goto case "2";
                    }
                    else if (choise == "3")
                    {
                        goto case "3";
                    }
                    else if (choise == "4")
                    {
                        goto case "4";
                    }
                    else {
                        goto case "4";
                    } 







                case "1":
                    result = number1 + number2;
                    Console.WriteLine("Sayıların toplamı=" + result);
                    goto case "Menyu";

                case "2":
                    result = number1 - number2;
                    Console.WriteLine("Sayıların çıxılması=" + result);
                    goto case "Menyu";

                case "3":
                    result = number1 * number2;
                    Console.WriteLine("Sayıların vurulması=" + result);
                    goto case "Menyu";
                case "4":
                    result = number1 / number2;
                    Console.WriteLine("Sayıların bölünməsi=" + result);
                    goto case "Menyu";




            }
            Console.ReadLine();
        }
    }
}
