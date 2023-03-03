using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskİnClass
{
     public  class CheckName
    {
        

        public static string checkname (string Name, string  Surname)
        {
            string join = Name + Surname;
            if (join.Length > 20)
            {
                Name = Name.Substring(0, 1);
                join = Name + "." + Surname;
                return join;
            }
            else
            {
                join = Name + ". " + Surname;
                return join;
            }
            
        }

    }
}
