using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainHomework3
{
    class Program
    {
        static void Main(string[] args)
        {
            String choice = "";
            do
            {
                ShowMenyu();
                

            } while (choice=="7");
           
        }
        public  static void ShowMenyu()
        {
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Çıxma");
            Console.WriteLine("3. Vurma");
            Console.WriteLine("4. Bölmə");
            Console.WriteLine("5. Ədədin Faizi");
            Console.WriteLine("6. Faizin Ədədi");
            Console.WriteLine("7. Çıxış");
            
            return;
        }
        

    }
}
