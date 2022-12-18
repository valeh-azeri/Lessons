using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryHome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            bool varBool = true;
            int numberOne = 1;
            string varString = Convert.ToString(varBool); 
            bool badResult = int.TryParse(varString, out numberOne);

        }
    }
}
