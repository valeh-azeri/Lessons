using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Switch-case ilə sadə kalkulyator app'ı yazacaqsız. İlk öncə istifadəçiyə kiçik menyu çıxardın. 
             Orda edə biləcəyi əməliyyatlar olacaq. Toplama, çıxma, vurma
             və bölmə. İstifadəçi hansını seçsə həmin case'də ekrana nəticəni çıxardacaqsız. 
             Nəticəni göstərəndən sonra aşağıda yenidən ana menyunu göstərəcəksiz. İstifadəçi
             istədiyi qədər yəni proqramı bağlayana qədər bu döngü halında davam edəcək.*/

            string choise="Menyu";
            decimal result;
            decimal num1, num2;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //Console.WriteLine("Bu app Kiçik bir Kalkulyatordur");
            //Console.WriteLine("_______________________________");

            

            //Console.WriteLine("1. Toplama");
            //Console.WriteLine("2. Çıxma");
            //Console.WriteLine("3. Vurma");
            //Console.WriteLine("4. bölmə");
            

            //Console.WriteLine("_______________________________");
            //Console.WriteLine("Xahiş edirəm  işləminizi seçin");
            
            
            switch (choise)
            {
                
                case "Menyu":
                    Console.Clear();
                    Console.WriteLine("Bu app Kiçik bir Kalkulyatordur");
                    Console.WriteLine("_______________________________");
                    Console.WriteLine("1 ci sayını girin : ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2 ci sayını girin : ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("_______________________________");
                    Console.WriteLine("1. Toplama");
                    Console.WriteLine("2. Çıxma");
                    Console.WriteLine("3. Vurma");
                    Console.WriteLine("4. bölmə");
                    Console.WriteLine("_______________________________");
                    Console.WriteLine("Xahiş edirəm  işləminizi seçin");
                    choise = Console.ReadLine();
                    

                    break;


                case "1":
                    result = num1 + num2;
                    Console.WriteLine("Sayıların toplamı=" + result);
                    goto case "Menyu";

                case "2":
                    result = num1 - num2;
                    Console.WriteLine("Sayıların çıxılması=" + result);
                    goto case "Menyu";

                case "3":
                    result = num1 * num2;
                    Console.WriteLine("Sayıların vurulması=" + result);
                    goto case "Menyu";
                case "4":
                    result = num1 / num2;
                    Console.WriteLine("Sayıların bölünməsi=" + result);
                    goto case  "Menyu";

               

                
            }
            




        }
    }
}
