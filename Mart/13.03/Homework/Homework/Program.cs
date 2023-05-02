using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Homework 1:
                Bu gün ev tapşırığınız abstract, interface, virtual method'ları araşdırmaqdır.
                Araşdırandan sonra da, gələn dərsə qədər bir nümunə hazırlamağa çalışın.Bu bir kiçik kitabxana app'ı,
                calculator və ya hər hansısa kiçik bir task ola bilər.Generic collection'ları falan keçəndən sonra
                kiçik app'lar yazanda bunları praktika edəndə daha rahat başa düşəcəksiz çünkü hal-hazırda bunları
                real tədbiq etməyə çalışsaz hələ bilmədiyiniz nə qədər mövzu əksiyi var.*/
            /*
        Homework 1:

        Bir dənə kitabxana app'ı yazacaqsınız. İlk öncə mən bir neçə müəllif əlavə edəcəyəm və sonra da
        müəlliflərin kitablarını əlavə edəcəyəm. Nəzərə alın ki, müəllifləri əlavə edəndən sonra 
        -birinci müəllif
        məlumatlarını ekranda görməliyəm ki, kitab'ı əlavə edəndə müəllifin Id dəyərinə görə əlavə edəcəm.
        Bura qədər bildiyiniz hər şeydən istifadə edərək bu app'ı yazmağa çalışın. Müəllif və kitabları əlavə
        etmək, silmək, hamısını görmək, Ad'a görə axtarmaq kimi seçim olacaq. Bacarsanız editləmək funksiyasını
        da yazın.
        */
            
            
            string choise = "Menyu";

            switch (choise)
            {
                case "Menyu":
                    Console.WriteLine("Kitabxa programına xoş gəldiniz. Xahis edirəm seçiminizi edin :");
                    Console.WriteLine("1.Müllif əlavə edin");
                    Console.WriteLine("2.Müllif Sil");
                    Console.WriteLine("3.Müəllifləri gör");
                    Console.WriteLine("4.Kitab Əlavə et");
                    Console.WriteLine("5.Kitab Sil");
                    Console.WriteLine("6.Kitabları gör");

                    choise=Console.ReadLine();
                    if (choise=="1")
                    {
                        goto case "1";
                      
                        
                    }
                    else if (choise == "2")
                    {
                        goto case "2";
                    }
                    else if (choise == "3")
                    {
                        goto case "3";
                    }
                    else if (choise == "4")
                    {
                        goto case "4";
                    }
                    else if (choise == "5")
                    {
                        goto case "5";
                    }
                    else if (choise == "6")
                    {
                        goto case "6";
                    }
                    else
                    {
                        goto case "Menyu";
                    }
                case "1":
                    Library outhor = new Library();
                    Console.WriteLine("Yazar  ID sini girin");
                    outhor.OuthorId = Console.ReadLine();
                    Console.WriteLine("Yazar  Adini girin");
                    outhor.OuthorName = Console.ReadLine();
                    Console.WriteLine("Yazar  Soyadini girin");
                    outhor.OuthorSurname = Console.ReadLine();
                    break;
                case "2": break;
                case "3": break;
                case "4": break;
                case "5": break;
                case "6": break;


            }

        }

    }
}
