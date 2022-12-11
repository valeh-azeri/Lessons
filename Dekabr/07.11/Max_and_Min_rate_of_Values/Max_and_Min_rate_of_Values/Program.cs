using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_and_Min_rate_of_Values
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Intin Max value : "+int.MaxValue);
            Console.WriteLine("Intin Min value : " + int.MinValue);
            Console.WriteLine();

            Console.WriteLine("Short Max value : " + short.MaxValue);
            Console.WriteLine("Short Min value : " + short.MinValue);
            Console.WriteLine();

            Console.WriteLine("UShort Max value : " + ushort.MaxValue);
            Console.WriteLine("UShort Min value : " + ushort.MinValue);
            Console.WriteLine();

            Console.WriteLine("Long Max value : " + long.MaxValue);
            Console.WriteLine("Long Min value : " + long.MinValue);
            Console.WriteLine();

            Console.WriteLine("Byte Max value : " + byte.MaxValue);
            Console.WriteLine("Byte Min value : " + byte.MinValue);
            Console.WriteLine();

            Console.WriteLine("Sbyte Max value : " + sbyte.MaxValue);
            Console.WriteLine("Sbyte Min value : " + sbyte.MinValue);
            Console.WriteLine();


            Console.WriteLine("Char Max value : " + char.MinValue);
            Console.WriteLine("Char Min value : " + char.MaxValue);
            Console.WriteLine();

            //yüksək dəqiqlik tələb edən rəqəmlərdə  istifadə olunur- sonunda  d yazılır. Məcburidir. 10 dalıqları da saxlayırıq
            Console.WriteLine("Double Max value : " + double.MinValue);
            Console.WriteLine("Double Min value : " + double.MinValue);
            Console.WriteLine();

            double epl = double.Epsilon;
            Console.WriteLine("Epilson 0-a ən yaxın dəyəri  göstərir :"+epl.ToString());

            //Decimal-da  dəyişən təyin  etdikdə  sonunda  m mütləq  yazılmalıdır, yoxsa  double   qəbul  edir
            Console.WriteLine("Decimal Max value : " + decimal.MinValue);
            Console.WriteLine("Decimal Min value : " + decimal.MinValue);
            Console.WriteLine();

            //float da da   f  hərfi yazılmalıdır. Yosa   yenə double  qəbul edəcək 
            Console.WriteLine("Float Max value : " + float.MinValue);
            Console.WriteLine("Float Min value : " + float.MinValue);
            Console.WriteLine();

            //Object tipi bütün  tipləri özündə birləşdirir.

            Console.Read();

        }
    }
}
