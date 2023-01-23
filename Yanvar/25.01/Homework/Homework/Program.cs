using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Homework 1:
            Main methodunda tələbənin ad, soyad, qiymət 1, qiymət 2 və qiymət 3 məlumatları alınıb hamısı
            bir method'a ötürüləcək.Əlavə olaraq bir Student class'ınız olsun. Bu class'da 3 method olacaq. 
            CalcAverage, RateAverage və bir dənə də CalcAverage'in overload'ı olacaq.Bunun üçün Method Overloading
            mövzusu araşdırılmalıdır.CalcAverage ortalama qiyməti hesablayacaq. RateAverage isə ortalama qiymətə
            görə, tələbənin ortalamasının 45-dən yuxarı/aşağı olub-olmamasını check edəcək.
            Əgər yuxarıdırsa keçib, aşağıdırsa kəsilib yazısını ekrana çıxardacaq.*/

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

        Begin:
            Console.Clear();
            Avarge studentAvarageRate = new Avarge();

            Console.Write("Adınızı girin: ");
            string name = Console.ReadLine();

            Console.Write("Soyadınızı girin: ");
            string surname = Console.ReadLine();

            Console.Write("Birinci sınaq nəticənizi girin: ");
            int mark1 = 0;
            bool mark1Bool = int.TryParse(Console.ReadLine(), out mark1);


            Console.Write("Ikinci sınaq nəticənizi girin: ");
            int mark2 = 0;
            bool mark2Bool = int.TryParse(Console.ReadLine(), out mark2);

            Console.Write("Üçüncü sınaq nəticənizi girin: ");
            int mark3 = 0;
            bool mark3Bool = int.TryParse(Console.ReadLine(), out mark3);

            studentAvarageRate.CalcAvarage(mark1, mark2, mark3);
            studentAvarageRate.RateAvarage(mark1, mark2, mark3, name, surname);
            
            Console.WriteLine();
            Console.WriteLine("Davam etmək istəyirsiniz ? H/Y");
            string chois = Console.ReadLine();

            if (chois.ToUpper() == "H")
            {
                goto Begin;
            }
            

            Console.ReadLine();



        }
    }
}
