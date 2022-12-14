using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_DateTime_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            DateTime now = DateTime.Now;
            DateTime utsNow = DateTime.UtcNow;
            long ticks = now.Ticks;
            int millisecond = now.Millisecond;
            int second = now.Second;
            int minute = now.Minute;
            int day = now.Day;
            int hour = now.Hour;
            DayOfWeek DayOgWeek = now.DayOfWeek;
            int month = now.Month;
            int year = now.Year;
            string shortDayString = now.ToShortDateString();
            string longDaytString = now.ToLongDateString();
            string timFormat = now.ToString("MM/dd/yyyy");
            TimeSpan timeOfDay = now.TimeOfDay;
            
            Console.WriteLine("Doğum trixini girin : gün.ay.il kimi:");
            DateTime newEnteredDateTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(newEnteredDateTime);

            Console.WriteLine(now);
            Console.WriteLine(utsNow);
            Console.WriteLine(ticks);
            Console.WriteLine(millisecond);
            Console.WriteLine(second);
            Console.WriteLine(minute);
            Console.WriteLine(day);
            Console.WriteLine(hour);
            Console.WriteLine(DayOgWeek);
            Console.WriteLine(month);
            Console.WriteLine(year);
            Console.WriteLine(timeOfDay);
            Console.WriteLine(shortDayString);
            Console.WriteLine(longDaytString);
            Console.WriteLine(timFormat);
            Console.ReadLine();
            

        }
    }
}
