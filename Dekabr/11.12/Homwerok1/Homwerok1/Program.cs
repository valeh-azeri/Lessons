using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homwerok1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Data Types

            string stringVar = "Hello World!!";
            int intVar = 100;
            float floatVar = 10.2f;
            char charVar = 'A';
            bool boolVar = true;

            uint ui = 100u;
            float fl = 10.2f;
            long l = 45755452222222l;
            ulong ul = 45755452222222ul;
            double d = 11452222.555d;
            decimal mon = 1000.15m;

            int i = default(int); // 0
            float f = default(float);// 0
            decimal d = default(decimal);// 0
            bool b = default(bool);// false
            char c = default(char);// '\0'


            // Conversion
            int il = 345;
            float t = il;

            /*
             int i = 100;
             uint u = (uint) i;
             Console.Write(i); */

            long l1 = -9223372036854775808;
            long l2 = 9223372036854775807;

            ulong ul1 = 18223372036854775808ul;
            ulong ul2 = 18223372036854775808UL;

            Console.WriteLine(Int64.MaxValue);//9223372036854775807
            Console.WriteLine(Int64.MinValue);//-9223372036854775808
            Console.WriteLine(UInt64.MaxValue);//18446744073709551615

            float f1 = 123456.5F;
            float f2 = 1.123456f;

            Console.WriteLine(f1);//123456.5
            Console.WriteLine(f2);//1.123456


            double d1 = 12345678912345.5d;
            double d2 = 1.123456789123456d;

            Console.WriteLine(d1);//12345678912345.5
            Console.WriteLine(d2);//1.123456789123456

            decimal d12 = 123456789123456789123456789.5m;
            decimal d22 = 1.1234567891345679123456789123m;

            Console.WriteLine(d12);
            Console.WriteLine(d22);

            double d = 0.12e2;
            Console.WriteLine(d);  // 12;

            float f = 123.45e-2f;
            Console.WriteLine(f);  // 1.2345

            decimal m = 1.2e6m;
            Console.WriteLine(m);// 1200000

            //Create DateTime Object
            DateTime dt = new DateTime(); // assigns default value 01/01/0001 00:00:00
                                          //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();

            //assigns year, month, day
            DateTime dt2 = new DateTime(2015, 12, 31);

            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);
            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);
            DateTime dt = new DateTime(636370000000000000);
            DateTime.MinValue.Ticks;  //min value of ticks
            DateTime.MaxValue.Ticks; // max value of ticks
            DateTime currentDateTime = DateTime.Now;  //returns current date and time
            DateTime todaysDate = DateTime.Today; // returns today's date
            DateTime currentDateTimeUTC = DateTime.UtcNow;// returns current UTC date and time
            DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
            DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime
            //Time Span
            DateTime dt = new DateTime(2015, 12, 31);
            TimeSpan ts = new TimeSpan(25, 20, 55);
            DateTime newDate = dt.Add(ts);
            Console.WriteLine(newDate);//1/1/2016 1:20:55 AM
            //Subtract Dates
            DateTime dt1 = new DateTime(2015, 12, 31);
            DateTime dt2 = new DateTime(2016, 2, 2);
            TimeSpan result = dt2.Subtract(dt1);//33.00:00:00
            DateTime dt1 = new DateTime(2015, 12, 20);
            DateTime dt2 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50);
            //Operators  in  Date Time  function / Biz   bunlai hele  gormemisik
            Console.WriteLine(dt2 + time); // 1/10/2017 10:36:10 AM
            Console.WriteLine(dt2 - dt1); //377.05:10:20
            Console.WriteLine(dt1 == dt2); //False
            Console.WriteLine(dt1 != dt2); //True
            Console.WriteLine(dt1 > dt2); //False
            Console.WriteLine(dt1 < dt2); //True
            Console.WriteLine(dt1 >= dt2); //False
            Console.WriteLine(dt1 <= dt2);//True

            //Convert to  string 
            var str = "5/12/2020";
            DateTime dt;

            var isValidDate = DateTime.TryParse(str, out dt);

            if (isValidDate)
                Console.WriteLine(dt);
            else
                Console.WriteLine($"{str} is not a valid date string");

            //C# - Struct (Bizim gormediyimiz 

            // Define an Enum
            enum  WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        /*
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        Console.WriteLine(WeekDays.Friday); //output: Friday 
        int day = (int)WeekDays.Friday; // enum to int conversion
        Console.WriteLine(day); //output: 4 
		
        var wd = (WeekDays)5; // int to enum conversion
        Console.WriteLine(wd);//output: Saturday */
        
        #endregion




    }
    }
}
