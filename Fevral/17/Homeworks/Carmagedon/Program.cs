using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carmagedon
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Homework 2:
            Satılacaq məhsulu yaradacaqsınız və onun bir neçə dənə constructor method'ları olacaq.

            Məhsul (item) Class'ında olacaq property'lər:
                Marka
                Model
                İstehsal ili
                Km
                Yanacaq növü
                Sürətlər qutusu
                Alış qiyməti
                Satış qiyməti
                Max endirim məbləği
                Qiymət (private olması mütləqdir!)

               Constructor overload'ları aşağıdakı kimi olmalıdır:
                1. marka, model
                2. marka, model, istehsal ili
                3. marka, model, istehsal ili, km
                4. bütün property'lər

               Əlavə olaraq iki methodunuz olacaq hansı ki, birinci method bütün məlumatları ekrana yazacaq və ikinci method isə müəyyən obyektin
               satış qiymətini təyin edəcək. Burda biraz baş işlətmək lazımdır. Təyin edilən qiymət, satış qiyməti - max endirim qiyməti qədər
               olmalıdır. Yəni, max endirim qiyməti qədər geriyə gedə bilməliyəm.
               Məsələn:
               Satış qiymətim 10 manatdırsa, maximum endirim qiymətim 2 manatdırsa, mən bu məhsulu ən aşağı 8 manata sata bilməliyəm. 7 manata
               satmağa çalışsam xəta mesajı yazsın ekrana (məs: Max. endirim qiymətindən aşağı bir qiymət təyin etməyə çalışdınız!)
            */
            Console.OutputEncoding=Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;


            CarCeller CarCellerFull = new CarCeller("Opel", "Astra", "2009", "100000", "Benzin", "Avtomat", 15000, 20000, 300);
            CarCeller CarcellerOverload1 = new CarCeller("Opel", "Astra");
            CarCeller CarcellerOverload2 = new CarCeller("Opel", "Astra", "2009");
            CarCeller CarcellerOverload3 = new CarCeller("Opel", "Astra", "2009", "10000");


            int PurchacePrice=CarCellerFull.PurchacePrice;
            int MaxDiscountAmount = CarCellerFull.MaxDiscountAmount;
            int Price = CarCellerFull.price(PurchacePrice, MaxDiscountAmount);

            CarCellerFull.FullInfo();
            Console.WriteLine("Maşınınız üçün bəlirlənən məbləğ :");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Məbləğ :"+Price);
            Console.ReadLine();


        }

    }
}

