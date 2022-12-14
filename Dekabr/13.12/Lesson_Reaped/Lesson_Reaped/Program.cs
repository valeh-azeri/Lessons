using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Reaped
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            #region implicit Convension 
            //kiçiyi  böyük olana  çevirə bilərik
            //Nümunə 1   
            byte a = 250;
            short b = a;

            byte byte_Max = byte.MaxValue;
            short short_Max = byte_Max;

            short short_Max_Value = short.MaxValue;
            long take_Short = short_Max_Value;

            #endregion

            #region Expilicit 
            //Kiçiyə böyük olanı mənimsətmək(sərhəddi aşmamaq  şərti ilə)

            int a1 = 20000;
            //short b = a; xəta verir. Hansı ki əslində bu dəyər shortda saxlanıla bilər
            short b1 = (short)a1; //Artıq  xəta  yoxdur

            #endregion

            #region Checked & Unchecked Convension
            /* o deməkdir ki, kiçiyə böyüyü  mənimsətdikdə  əgər  dəyər   böyük götürülərsə  informasia 
             itir. İtməsin  deyə  cheked dən istifadə etmək lazımdır */

            Console.WriteLine("");
            long lonVar = Convert.ToUInt32(Console.ReadLine());
            int take_longVar = (int)lonVar;
            Console.ReadLine();



            #endregion

        }
    }
}
