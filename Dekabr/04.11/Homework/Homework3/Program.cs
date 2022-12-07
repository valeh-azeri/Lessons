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
            #region 10 city  in  different method
            string city1, city2, city3, city4, city5, city6, city7, city8, city9, city10;
            Console.WriteLine("Sizdən ardıcıl olaraq 10 şəhər adı girməyinizi xahiş edirik :");
            city1 = Console.ReadLine();
            city2 = Console.ReadLine();
            city3 = Console.ReadLine();
            city4 = Console.ReadLine();
            city5 = Console.ReadLine();
            city6 = Console.ReadLine();
            city7 = Console.ReadLine();
            city8 = Console.ReadLine();
            city9 = Console.ReadLine();
            city10 = Console.ReadLine();
            Console.WriteLine("Sizin girdiyiniz şəhərlər  aşağıdakılardır");
            Console.WriteLine(city1+","+ city2 + "," + city3 + "," + city4 + "," + city5 + "," + city6 + "," + city7 + "," + city8 + "," + city9 + "," + city10);
            
            Console.Read();
            #endregion
        }
    }
}
