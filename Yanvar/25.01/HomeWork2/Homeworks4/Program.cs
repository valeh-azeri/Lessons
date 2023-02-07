using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Homeworks:
                    4. Bir dənə kiçik console app yazın. Bu app sizdən sinif adı soruşacaq. 
                    Məsələn 1A, 1B və s. daxil ediləcək. Sonra sinif rəhbərinin adı
                 soruşulacaq. Axırda isə, 10 tələbə adı soruşulacaq. Bu tələbələrin adlarını array'dan 
                 istifadə etmədən 10 ayrı string dəyişəndə saxlayın student1, student2, student3... və 
                 sonra sinif adı, müəllim adı, tələbələrin adlarını göndərə biləcəyiniz bir method yazın.
                 Method cəmi 3 parametr qəbul edə bilər. 3-dən artıq parametr istifadə etmək haqqınız yoxdur. 
                 Axırda sinif haqqında məlumat yazısı və onun altında sinif adı, sinif rəhbərinin adı və 
                 tələbə adları alt-alta yazılsın. Tələbə adlarını da collection və ya list
                 şəklində göndərmək haqqınız yoxdur. İp ucu verim dərsdə keçmişdik.
             */

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Sinifinizi girin: ");
            string className = Console.ReadLine();
            Console.WriteLine("Sinif rəhbərinizi  girin: ");
            string teacherName = Console.ReadLine();
            int i = 1;
            Console.WriteLine(i+".Şagird adını girin"); i++;
            string studen1 = Console.ReadLine();
            Console.WriteLine(i+ ".Şagird adını girin"); i++;
            string studen2 = Console.ReadLine();
            Console.WriteLine(i + ".Şagird adını girin"); i++;
            string studen3 = Console.ReadLine();
            Console.WriteLine(i + ".Şagird adını girin"); i++;
            string studen4 = Console.ReadLine();
            Console.WriteLine(i + ".Şagird adını girin"); i++;
            string studen5 = Console.ReadLine();
            Console.WriteLine(i + ".Şagird adını girin"); i++;
            string studen6 = Console.ReadLine();
            Console.WriteLine(i + ".Şagird adını girin"); i++;
            string studen7 = Console.ReadLine();
            Console.WriteLine(i + ".Şagird adını girin"); i++;
            string studen8 = Console.ReadLine();
            Console.WriteLine(i + ".Şagird adını girin"); i++;
            string studen9 = Console.ReadLine();
            Console.WriteLine(i + ".Şagird adını girin"); i++;
            string studen10 = Console.ReadLine();

            Console.Clear();
            ShowMyClass(className, teacherName, studen1, studen2, studen3, studen4, studen5, studen6, studen7, studen8, studen9, studen10);
            Console.ReadLine();
        }

        public static void ShowMyClass(string className, string teacherName, params string[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine((i + 1) + "." + students[i]);
            }
            Console.WriteLine("Sinifin adı : "+className);
            Console.WriteLine("Sinif Rəhbərinin adı :"+teacherName);
        }
    }
}
