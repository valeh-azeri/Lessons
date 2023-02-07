using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Calck
    {
        #region Show menyu 
        public void ShowMenyu()
        {
        Begin:

            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Çıxma");
            Console.WriteLine("3. Vurma");
            Console.WriteLine("4. Bölmə");
            Console.WriteLine("5. Ədədin Faizi");
            Console.WriteLine("6. Faizin Ədədi");
            Console.WriteLine("7. Çıxış");

            Console.Write("Seçmək istədiyiniz əməliyyatı  girin :");
            string choice = Console.ReadLine();

            Console.Write("1. sayini girin");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            decimal num1Dec = (decimal)num1;

            Console.Write("2. sayini girin");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            decimal num2Dec = (decimal)num2;
            
            Console.Clear();
            



            switch (choice)
            {
                case "1":
                    {

                        
                        decimal result = Plus(num1Dec, num2Dec);
                        Console.WriteLine("Cavab=" + result);
                        Console.WriteLine();
                    } goto Begin;
                case "2":
                    {
                        
                        decimal result = Minus(num1Dec, num2Dec);
                        Console.WriteLine("Cavab=" + result);
                        Console.WriteLine();
                    } goto Begin;
                case "3":
                    {
                        
                        decimal result = Times(num1Dec, num2Dec);
                        Console.WriteLine("Cavab=" + result);
                        Console.WriteLine();
                    } goto Begin;
                case "4":
                    {
                        
                        decimal result = Division(num1Dec, num2Dec);
                        Console.WriteLine("Cavab=" + result);
                        Console.WriteLine();
                    } goto Begin;
                case "5":
                    {
                        
                        decimal result = PercentOfNum2(num1Dec, num2Dec);
                        Console.WriteLine("Cavab=" + result);
                        Console.WriteLine();
                    } goto Begin;
                case "6":
                    {
                        
                        decimal result = Num2PercentOfNum1(num1Dec, num2Dec);
                        Console.WriteLine("Cavab=" + result);
                        Console.WriteLine();
                    } goto Begin;
                case "7": break;

            }


        }
        #endregion

        #region Plus
        public decimal Plus(int num1, int num2)
        {
            decimal result = num1 + num2;
            return result;
        }
        public decimal Plus(decimal num1, decimal num2)
        {
            decimal result = num1 + num2;
            return result;
        }
        public decimal Plus(decimal num1, int num2)
        {
            decimal result = num1 + num2;
            return result;
        }
        public decimal Plus(int num1, decimal num2)
        {
            decimal result = num1 + num2;
            return result;
        }
        public decimal Plus(string num1, decimal num2)
        {
            decimal result = Convert.ToInt32(num1) + num2;
            return result;
        }
        public decimal Plus(decimal num1, string num2)
        {
            decimal result = Convert.ToInt32(num2) + num1;
            return result;
        }
        #endregion

        #region Minus
        public decimal Minus(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
        public decimal Minus(decimal num1, decimal num2)
        {
            decimal result = num1 - num2;
            return result;
        }
        public decimal Minus(decimal num1, int num2)
        {
            decimal result = num1 - num2;
            return result;
        }
        public decimal Minus(int num1, decimal num2)
        {
            decimal result = num1 - num2;
            return result;
        }
        public decimal Minus(string num1, decimal num2)
        {
            decimal result = Convert.ToInt32(num1) - num2;
            return result;
        }
        public decimal Minus(decimal num1, string num2)
        {
            decimal result = num1 -Convert.ToInt32(num2);
            return result;
        }
        #endregion

        #region Times
        public decimal Times(decimal num1, decimal num2)
        {
            decimal result = num1 * num2;
            return result;
        }
        #endregion

        #region Division
        public decimal Division(decimal num1, decimal num2)
        {

            if (num2 == 0)
            {
                decimal result = 0;
                Console.WriteLine("Sifira bölmək olmur");
                return result;

            }
            else
            {
                decimal result = num1 / num2;
                return result;
            }


        }
        #endregion

        #region % number
        public decimal PercentOfNum2(decimal num1, decimal num2)
        {
            decimal result = (num1 * num2) / 100;
            return result;
        }

        #endregion

        #region Number of %
        public decimal Num2PercentOfNum1(decimal num1, decimal num2)
        {
            decimal result = (num1 * 100) / num2;
            return result;
        }
        #endregion

        



    }
}
