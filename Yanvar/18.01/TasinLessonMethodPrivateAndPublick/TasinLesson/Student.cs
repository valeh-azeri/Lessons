using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasinLesson
{
    class Student
    {
        public void SaySalam()
        {
            Console.WriteLine("Salama  qaqalar");
           
        }

        private void SayNecesen()
        {
            Console.WriteLine("Necesiz");
            
        }

        public void SayNece()
        {
            SayNecesen();
        }

    }
}
