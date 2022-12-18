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
            /* Homework 3: İstifadəçidən 10 dənə fərqli rəqəm alıb bir dəyişəndə toplayın. 
             * Bu taskı da çıxma, vurma və bölmə üçün də edin.
            Çıxmada və toplama əməliyyatlarında 10-cu dəyər daxil edildikdən sonra alınan 
            nəticəyə 1 toplayacaq və ya çıxacaqsız.
            Vurmada bölmədə isə, alınan nəticəni 20'ə vurun və ya bölün.*/
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            decimal num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, sum, minus, times, devision;
            Console.WriteLine("Bu app sizin  girəcəyiniz 10 sayini toplayacaq(+1), çıxacaq(-1), vuracaq(20), böləcək(/20) ");
            Console.WriteLine("Xahiş edirəm ixtiyari 10 sayı girin ");
            num1 = Convert.ToDecimal(Console.ReadLine());
            num2 = Convert.ToDecimal(Console.ReadLine());
            num3 = Convert.ToDecimal(Console.ReadLine());
            num4 = Convert.ToDecimal(Console.ReadLine());
            num5 = Convert.ToDecimal(Console.ReadLine());
            num6 = Convert.ToDecimal(Console.ReadLine());
            num7 = Convert.ToDecimal(Console.ReadLine());
            num8 = Convert.ToDecimal(Console.ReadLine());
            num9 = Convert.ToDecimal(Console.ReadLine());
            num10 = Convert.ToDecimal(Console.ReadLine());
            sum = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + 1;
            minus = num1 - num2 - num3 - num4 - num5 - num6 - num7 - num8 - num9 - num10 - 1;
            times = num1 * num2 * num3 * num4 * num5 * num6 * num7 * num8 * num9 * num10 * 20;
            devision = num1 / num2 / num3 / num4 / num5 / num6 / num7 / num8 / num9 / num10 / 20;
            Console.WriteLine("Toplam +1 nəticəsi =" + sum);
            Console.WriteLine("Çıxma -1 nəticəsi =" + minus);
            Console.WriteLine("Vurma*20 nəticəsi =" + times);
            Console.WriteLine("Bölmə/20 nəticəsi =" + devision);
            Console.ReadLine();




        }
    }
}
