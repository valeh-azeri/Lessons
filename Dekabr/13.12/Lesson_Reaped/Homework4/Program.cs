using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Homework 4:
            Aşağıdakı dəyərləri düzgün tiplərdə dəyişənlər yaradıb saxlayın:
            1: "Hava gozeldir."
            2: '%'
            3: 9999999999999999
            4: true
            5: false
            6: '0'
            7: 0
            8: 150
            9: -111111111115615
            10: 15.2M
            11: 15.2
            12: 15.2F
            13: new DateTime(2020, 12, 12) */
            string weather = "Hava gozeldir.";
            char percentage = '%';
            long longLengh= 9999999999999999;
            bool BoolTrue = true;
            bool boolFalse = false;
            char charNumber = '0';
            byte zeroByte = 0;
            byte numberByte = 150;
            long longNumber = -111111111115615;
            decimal decimalNumber = 15.2M;
            double doubleNumber = 15.2;
            float floatNumber = 15.2f;
            DateTime newTime = new DateTime(2020, 12,12);
            Console.ReadLine();
        }
    }
}
