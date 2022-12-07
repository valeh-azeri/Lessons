using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  take name, surname adn city in  different variables
            string name, surname, city;
            Console.WriteLine("Adınızı girin :");
            name=Console.ReadLine();
            Console.WriteLine("Soyadinizi  girin :");
            surname = Console.ReadLine();
            Console.WriteLine("Yaşadığınız  şəhəri girin :");
            city = Console.ReadLine();

            Console.WriteLine(name + " " + surname + " " + city);
            Console.Read();
            #endregion


        }
    }
}
