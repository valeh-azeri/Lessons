using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskİnClass
{
    class Program
    {
        static void Main(string[] args)
        {
            bool VarBool = true;
            int VarInt = 1;
            string NotNum = Convert.ToString(VarInt);
            bool NewBool = int.TryParse(NotNum, out VarInt);

            Console.Write(NewBool);
            Console.ReadLine();
        }
    }
}
