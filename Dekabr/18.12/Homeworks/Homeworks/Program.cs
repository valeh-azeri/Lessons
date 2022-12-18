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
            /*Homework 1: İstifadəçidən 2 dənə ayrı dəyər alın(rəqəm). Məsələn birincidə 
             * istifadəçi 20 daxil etdi onu a dəyişənində saxlayın.
                         İkincidə 50 daxil etdi onu da b dəyişənində saxlayın. Elə edin ki, 
                         bu iki dəyişənin dəyərlərinin yerlərini dəyişdirin.
                         Yəni a 20, b 50-dirsə elə edin ki, a olsun 50, b olsun 20.*/
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int convertToOne, convertToTwo;
            Console.WriteLine("Bu app sizin girdiyiniz rəqəmlərin yerini dəyişəcək");
            Console.WriteLine("Xahiş edirəm birinci rəqəmi  girəsiniz :");
            int varNumberOne = Convert.ToInt32(Console.ReadLine());
            convertToOne = varNumberOne;
            Console.WriteLine("Xahiş edirəm ikinci rəqəmi  girəsiniz :");
            int varNumberTwo = Convert.ToInt32(Console.ReadLine());
            convertToTwo = varNumberTwo;
            varNumberOne = convertToTwo;
            varNumberTwo = convertToOne;
            Console.WriteLine("Dəyişdirilmiş birinci rəqəm :" + varNumberOne);
            Console.WriteLine("Dəyişdirilmiş ikinci rəqəm :" + varNumberTwo);
            Console.ReadLine();



        }
    }
}
