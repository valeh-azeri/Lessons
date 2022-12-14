using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Homework 3:
           İstifadəçidən yaşını, maaşını, boyunu, çəkisini və neçə dostu olduğunu soruşacaqsınız. 
           Daxil etdiyi bütün dəyərləri ilk öncə int tipinə convert
           edəcəksiniz. Daha sonra int dəyişənini byte tipinə cast edəcəksiniz (explicit conversion).
           Burada istifadəçi maaşı və yaşı xaricində digər məlumatları byte'ın max dəyərindən çox yazsa 
           heç bir xəta çıxmasın. Maaşını və ya yaşını byte
           tipinin qəbul edəcəyi maksimum dəyərdən çox yazarsa elə edin ki, proqramda xəta çıxsın.*/
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string birth, heigth, weigth, salary, friends;
            int birth1, heigth1, weigth1, salary1, friends1;
            Console.WriteLine("Yaşınızı  girin :");
            birth=Console.ReadLine();
            Console.WriteLine("Maaşınızı  girin :");
            salary = Console.ReadLine();
            Console.WriteLine("Boyunuzu  girin :");
            heigth = Console.ReadLine();
            Console.WriteLine("Çəkinizi  girin :");
            weigth = Console.ReadLine();
            Console.WriteLine("Dostlarınızın sayını girin :");
            friends = Console.ReadLine();

            birth1 = Convert.ToInt32(birth);
            heigth1 = Convert.ToInt32(heigth);
            weigth1 = Convert.ToInt32(weigth);
            salary1 = Convert.ToInt32(salary);
            friends1 = Convert.ToInt32(friends);

            checked
            {
                byte salary2 = (byte)salary1;
                byte birth2 = (byte)birth1;
                Console.WriteLine("Maaşı :" + salary2.ToString());
                Console.WriteLine("Yaşı :" + birth2.ToString());
                unchecked
                {
                    byte heigth2 = (byte)heigth1;
                    byte weigth2 = (byte)weigth1;
                    byte friends2 = (byte)friends1;
                    Console.WriteLine("Boyu  :" + heigth2.ToString());
                    Console.WriteLine("Çəki :" + weigth2.ToString());
                    Console.WriteLine("Dost sayı :" + friends2.ToString());
                    Console.ReadLine();
                }
            }

            

        }
    }
}
