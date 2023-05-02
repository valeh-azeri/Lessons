using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home1
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAnyMethod runAny = new RunAnyMethod(Add);

            runAny += Edit;
            runAny += Delete;

            runAny += () =>
            {
            };

            runAny();



        }

        public delegate void RunAnyMethod();

        public static void Add()
        {
            Console.WriteLine("Add method");
        }

        public static void Edit()
        {
            Console.WriteLine("Edit method");
        }

        public static void Delete()
        {
            Console.WriteLine("Delete method");
        }
    }
}
