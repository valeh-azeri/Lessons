using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Homework 4: İstifadəçidən qeyd etdiyim tiplərdə dəyər alıb onları uyğun 
             * tipdə dəyişənlərə çevirəcəksiz.
                bool, string, short, long, int, char, datetime.*/
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Bu app sizdən uyğun  formatda dəyişən girməyinizi istəyəcək");
            Console.WriteLine("Boolean tipində dəyər girin :");
            bool varBool = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("String tipində dəyər girin :");
            string varString = Console.ReadLine().ToUpper();
            Console.WriteLine("Short tipində bir  dəyər  girin :");
            short varShort=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Long tipində bir  dəyər girin :");
            long varLong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Int tipində bir  dəyər girin :");
            int varInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Char tipində bir  dəyər girin :");
            Char varChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("DateTime tipində bir  dəyər girin :");
            DateTime varDateTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Boolean tipindəki girdiyiniz dəyər =" + varBool);
            Console.WriteLine("String tipindəki girdiyiniz dəyər =" + varString);
            Console.WriteLine("Short tipindəki girdiyiniz dəyər =" + varShort);
            Console.WriteLine("Long tipindəki girdiyiniz dəyər =" + varLong);
            Console.WriteLine("Int tipindəki girdiyiniz dəyər =" + varInt);
            Console.WriteLine("Char tipindəki girdiyiniz dəyər =" + varChar);
            Console.WriteLine("DateTime tipindəki girdiyiniz dəyər =" + varDateTime);
            Console.ReadLine();



        }
    }
}
