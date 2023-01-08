using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Homework 1: İstifadəçi mənfi dəyər daxil edənə qədər, 
              daxil etdiyi bütün müsbət rəqəmləri toplayıb axırda nəticəni ekrana yazın.              
               */
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int digits=0, sum=0;
            Console.WriteLine("Bu app sizin daxil etdiyiniz rəqəmləri toplayacaq.");
            Console.WriteLine("__________________________________________________");
            Console.WriteLine();
            Console.Write("Xahiş edirəm bir  rəqəm daxil edin :");
            digits = Convert.ToInt32(Console.ReadLine());
            sum += digits;
            while (digits>=0)
            {
                
                Console.Write("Xahiş edirəm bir  rəqəm daxil edin :");
                digits = Convert.ToInt32(Console.ReadLine());
                sum += digits;
                Console.WriteLine("Girdiyiniz  rəqəmlərin toplamı =" + sum);

            }
            


        }
    }
}
