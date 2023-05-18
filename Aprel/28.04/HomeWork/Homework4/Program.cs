using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static List<string> Names = new List<string>();

        static void Main(string[] args)
        {
            /* Homework 4:
            Bir dənə String List'iniz olsun (names) və FakeData ilə 1000 dənə Name əlavə edin.
            Sonra həmin list'dən adı 5 simvol və ya daha uzun olan adları silin. Bunu etmək üçün 
            Remove və ya RemoveAll method'larını araşdırın və sonra edin. */

             

            for (int i = 1; i < 100; i++)
            {
                 var name = FakeData.NameData.GetFirstName();
                Names.Add(name);
            }
            Console.WriteLine();
            Console.WriteLine("ILK LISTIMIZ");
            ShowList();

            Console.WriteLine();
            Console.WriteLine("SILINMIS LISTIMIZ");
            Names.RemoveAll(m => m.Length >= 5);
            ShowList();
            Console.ReadLine();

        }

        static void ShowList()
        {
            foreach (var item in Names)
            {
               Console.Write(item + " - ");
            }
        }
        
    }
}
