using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1._2
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
            int countArray;
            float result = 0;

            Console.Write("Diziniz  neçə elemanlı olsun :");
            countArray = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[countArray];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write((i+1)+".Rəqəmi girin :");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var item in numbers)
            {
                result += item;
            }

            result = result / numbers.Length;
            Console.WriteLine("Ortalama ="+result);
            Console.ReadLine();

        }
    }
}
