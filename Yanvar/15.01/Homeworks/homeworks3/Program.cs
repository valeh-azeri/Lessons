using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworks3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homework 3:
           Bir array'a Random() ilə 1-100000 arası 100 ədəd rəqəm yığın. 
           Sonra həmin array'dakı ən kiçik və ən böyük rəqəmləri tapın. Əlavə olaraqda bütün rəqəmlərin
           toplamını ekrana yazdırın.*/

            Console.OutputEncoding = Encoding.Unicode;

            Random rand = new Random();
            long[] numArr = new long[100];
            long result = 0;
            

            for (int i = 0; i < numArr.Length; i++)
            {
                long numbersRand = rand.Next(100000);
                numArr[i] = numbersRand;
                Console.Write(numArr[i]+"\t");
                result += numArr[i];
            }
            Console.WriteLine();
            Console.WriteLine("Arraydakı rəqəmlərin toplamı =" + result);
            long maxNum = numArr[0], minNum = numArr[0];
            for (int i = 0; i < numArr.Length; i++)
            {
                if (numArr[i]>maxNum)
                {
                    maxNum = numArr[i];
                }
                if (numArr[i] < minNum)
                {
                    minNum = numArr[i];
                }
            }
            Console.WriteLine("Dizininin Maximum rəqəmi =" +maxNum );
            Console.WriteLine("Dizininin Minimum rəqəmi =" + minNum);


            Console.ReadLine();

        }
    }
}
