using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathOperations;

namespace OtherSolutionProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOperation = new MathOperation();
            var deyer=mathOperation.Calculate(50, 2, MathOperations.Enums.MathOperationsTypeEnum.Multuplication);
        }
    }
}
