﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homevorks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Vəsiqənin seriyası və vəsiqənin nömrəsi adlı iki xananız olacaq. DocumentSerial və DocumentNumber olaraq adlandıra bilərsiniz.
             */
            CardClass card = new CardClass();
            card.DocumentSerial = "AA";
            card.DocumentNumber = "12345678A";
        }
    }
}