using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAlone
{
    class StudenAvarageRate
    {
        public decimal CalcAvarage(decimal mar1, decimal mark2, decimal mark3)
        {
            decimal avarage = (mar1 + mark2 + mark3) / 3;
            return avarage;
        }



        public string RateAvarage(decimal mark1, decimal mark2, decimal mark3, string name, string surname)
        {
            string result = "";
            decimal avarage = (mark1 + mark2 + mark3) / 3;

            if (avarage <= 45)
            {
               result = "KƏSİLDİNİZ";
                return result;

            }
            else
            {
                result = "KEÇDINIZ";
                return result;
            }


        }

        public void RateAvarageShow(decimal mark1, decimal mark2, decimal mark3, string name, string surname)
        {
            decimal avarage = (mark1 + mark2 + mark3) / 3;

            if (avarage <= 45)
            {
                Console.WriteLine("Hörmətli " + name + " " + surname + " sizin imtahan nəticələrini: \n 1." + mark1 + "\n 2." + mark2 + "\n 3." + mark3 + ". \n Ortalamanız :" + avarage + " \n və siz..");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("KƏSİLDİNİZ");
            }
            else
            {
                Console.WriteLine("Hörmətli " + name + " " + surname + " sizin imtahan nəticələriniz: \n 1." + mark1 + " \n 2." + mark2 + "\n 3." + mark3 + ". \n Ortalamanız :" + avarage + " \n və siz..");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("KEÇDINIZ");
            }

            return;
        }
    }
}
