using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Homework 2: İstifadəçidən 3 ayrı sətirdə 3 ayrı rəqəm alın. İstifadəçi 3-cü 
             * rəqəmi daxil etdikdən sonra ekrana belə bir yazı
            yazdırın Nəticə: 5 + 5 + 10 = 20. Bunu çıxma, vurma və bölmə üçün də edin.*/
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            decimal number1, number2, number3;
            decimal sum, minus;
            decimal times, devision; 
            Console.WriteLine("Bu app sizin girdiyiniz ardıcıl 3 sayını vuracaq, cıxacaq, toplayacaq və böləcək,");
            Console.WriteLine("Xahiş edirəm ixtiyari 3 sayı  girin");
            number1 = Convert.ToDecimal(Console.ReadLine());
            number2 = Convert.ToDecimal(Console.ReadLine());
            number3 = Convert.ToDecimal(Console.ReadLine());
            sum = number1 + number2 + number3;
            minus = number1 - number2 - number3;
            times = number1 * number2 * number3;
            devision = number1 / number2 / number3;
            Console.WriteLine(" Sayıların toplamı =" + number1 + "+" + number2 + "+" + number3 + "=" + sum);
            Console.WriteLine(" Sayıların çıxılması =" + number1 + "-" + number2 + "-" + number3 + "=" + minus);
            Console.WriteLine(" Sayıların toplamı =" + number1 + "*" + number2 + "*" + number3 + "=" + times);
            Console.WriteLine(" Sayıların toplamı =" + number1 + "/" + number2 + "/" + number3 + "=" + devision);
            Console.ReadLine();


        }
    }
}
