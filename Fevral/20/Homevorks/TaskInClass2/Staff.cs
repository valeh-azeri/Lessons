using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInClass2
{
    class Staff
    {
        private static string _email;

        public static string Email {
            get
            {
                return _email;
            }
             set
            {
                _email = value + "@gmail.com";
            }
        }
    }
}
