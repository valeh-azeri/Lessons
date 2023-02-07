using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework 1:
           Bir array'da rəqəmləri saxlayıb sonra bütün array'dakı rəqəmlərin toplamının ortalamasını tapacaqsınız.
           Bunun üçün öncə bütün elementlərin toplamını tapın sonra onu array'dakı element sayına bölün. 
           Proqram açılanda istifadəçidən Array'ın neçə elementi olacağını soruşub həmin sayda elementi olacaq
           bir array yaradacaq. Arrayı yaratdıqdan sonra bütün elementlərinin dəyərlərini istifadəçidən 
           soruşub array'ı doldurun.
           Axırda da elementlərin toplamını və ortalama dəyərini ekrana yazdırın. 
           Bunu həm for döngüsüylə edin həm də foreach.
             */
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Neçə elementli Array düzəltmək istərdiniz ? : ");
           

            int countNumber =0;             
            int result = 0;
            bool countNumberBoll = int.TryParse(Console.ReadLine(), out countNumber);

            Console.WriteLine();

            if (countNumber >= 0)
            {

                int[] numbers = new int[countNumber];
                for (int i = 0; i < numbers.Length; i++)
                {

                    Console.Write(i + 1 + " ci rəqəmi girin :");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                    result += numbers[i];
                
                }
                result = result / numbers.Length;
                Console.WriteLine("___________________");
                Console.WriteLine("Ortalama = "+result);
                Console.ReadLine();



            }
            else {
                Console.WriteLine("Xahiş edriəm rəqəm daxil edəsiniz!");
            }
            Console.ReadLine();

        }
    }
}
