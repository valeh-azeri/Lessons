using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Homework 4: İstifadəçidən bir rəqəm alın. While döngüsüylə istifadəçinin 
             * daxil etdiyi rəqəmdən 0 - a doğru geriyə sayın.*/
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Geri sayım üçün  bir rəqəm girin ");
            var num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (var i = num; i >0; i--)
            {
                Console.Write(i+"\t");
                
            }
            Console.ReadLine();
        }
    }
}
