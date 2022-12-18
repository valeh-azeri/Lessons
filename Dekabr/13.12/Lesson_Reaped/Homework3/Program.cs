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
            int birth, heigth, weigth, salary, friends;

            Console.WriteLine("Yaşınızı  girin :");
            birth= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Maaşınızı  girin :");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Boyunuzu  girin :");
            heigth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Çəkinizi  girin :");
            weigth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dostlarınızın sayını girin :");
            friends = Convert.ToInt32(Console.ReadLine());
            

            checked
            {
                byte salary2 = (byte)salary;
                byte birth2 = (byte)birth;
                Console.WriteLine("Maaşı :" + salary.ToString());
                Console.WriteLine("Yaşı :" + birth.ToString());

                unchecked
                {
                    byte heigth2 = (byte)heigth;
                    byte weigth2 = (byte)weigth;
                    byte friends2 = (byte)friends;
                    Console.WriteLine("Boyu  :" + heigth.ToString());
                    Console.WriteLine("Çəki :" + weigth.ToString());
                    Console.WriteLine("Dost sayı :" + friends.ToString());
                    Console.ReadLine();
                }
            }

            

        }
    }
}
