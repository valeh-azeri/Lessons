using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Homework 2:
           Bir dənə anket proqramı yığacaqsınız. İstifadəçidən onun haqqında məlumatları 
           toplayacaqsınız. 
           Bu məlumatlar ad, soyad, cins, doğum tarixi,
           yaşadığı ölkə, yaşadığı şəhər, boy, çəki, maaş olacaq. 
           Siz bu məlumatları saxlamaq üçün doğru bir data type seçməlisiniz.

           İstifadəçinin daxil edəcəyi məlumatlar belə olacaq:
           Ad: Mark
           Soyad: Henry
           Cins: K və ya Q
           Doğum tarixi: 1990-10-10
           Yaşadığı ölkə: Azərbaycan
           Yaşadığı şəhər: Bakı
           Boy: 1.75
           Çəki: 26.50
           Maaş: 2500.00

           */
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Xahiş  edirəm  bizim üçün əhəmiyyətli olan bu anket sorğusunu doldurasınız.");
            Console.WriteLine("Adınızı daxil edin :");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı daxil  edin :");
            string surname = Console.ReadLine();
            Console.WriteLine("Cinsinizi daxil edin (K/Q):");
            //char sex = (char)Console.ReadLine();
            string sex= Console.ReadLine();
            char sex1 = Convert.ToChar(sex);

            Console.WriteLine("Doğum tarixinizi  girin (gün.ay.il)");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Yaşadığınız ölkəni girin :");
            string country = Console.ReadLine();
            Console.WriteLine("Yaşadığınız şəhəri girin :");
            string city = Console.ReadLine();
            Console.WriteLine("Boyunuzu girin :");
            string heigth = Console.ReadLine();
            float heigth1 = Convert.ToInt16(heigth);
            Console.WriteLine("Çəkinizi girin :");
            string weigth = Console.ReadLine();
            byte weigth1 = Convert.ToByte(weigth);
            Console.WriteLine("Maaşınızı girin :");
            string salary = Console.ReadLine();
            long salary1 = Convert.ToInt64(salary);

            Console.Clear();

            Console.WriteLine("Adınız : "+name);
            Console.WriteLine("Soyadınız : " + surname);
            Console.WriteLine("Cinsiyyətiniz : " + sex);
            Console.WriteLine("Doğum tarixiniz : " + birth);
            Console.WriteLine("Yaşadığınız ölkə  : " + country);
            Console.WriteLine("Yaşadığınız şəhər : " + city);
            Console.WriteLine("Boyunuz : " + heigth1);
            Console.WriteLine("Çəkiniz : " + weigth1);
            Console.ReadLine();







        }

    }
}
