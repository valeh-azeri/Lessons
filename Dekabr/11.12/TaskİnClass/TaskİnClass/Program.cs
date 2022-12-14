using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskİnClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Orxan bəy neçə yaşınız var ?             2.Orxan bəy hansı sahədə işləyirsiniz ?
            3.Orxan bəy ən son nə zaman kitab oxumusunuz?             4.Orxan bəy sevdiyiniz rəng hansıdır?             5.Orxan bəy avtomobil idarə edə bilirsiniz ?
            6.Orxan bəy gündə neçə saat yatırsınız?             7.Orxan bəy TV kanallarını izləyirsiniz?*/

            Console.OutputEncoding = Encoding.Unicode;            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Xoş  gəlmisiniz !");
            Console.WriteLine("Zəhmət olmasa  adınızı   daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine(name + " Sizə necə müraciət edə  bilərik");
            string nick = Console.ReadLine();
            Console.WriteLine(name + " " + nick + " Neçə yaşınız var ?");
            string eich = Console.ReadLine();
            Console.WriteLine(name + " " + nick + "  ən son nə zaman kitab oxumusunuz?");
            string book = Console.ReadLine();
            Console.WriteLine(name + " " + nick + "  sevdiyiniz rəng hansıdır?");
            string color = Console.ReadLine();
            Console.WriteLine(name + " " + nick + " vtomobil idarə edə bilirsiniz ?");
            string car = Console.ReadLine();
            Console.WriteLine(name + " " + nick + "  gündə neçə saat yatırsınız?");
            string sleep = Console.ReadLine();
            Console.WriteLine(name + " " + nick + "  TV kanallarını izləyirsiniz?");
            string tV = Console.ReadLine();
            Console.WriteLine("Anketə qatıldığınız üçün təşəkkür  edirik");

            Console.Clear();
            Console.WriteLine("Sizin Anket  məlumatlarınız aşağıdakılardır :");
            Console.WriteLine("Adınız :" + name);
            Console.WriteLine("Müraciətiniz :" + nick);
            Console.WriteLine("Yaşınız :" + eich);
            Console.WriteLine("Oxuduğunuz kitab :" + book);
            Console.WriteLine("Sevdiyiniz rəng :" + color);
            Console.WriteLine("Avtomobil idarəsi :" + car);
            Console.WriteLine("Günlük uxu rejimi :" + sleep);
            Console.WriteLine("İzlədiyiniz TV kanalı :" + tV);
            Console.ReadLine();







        }
    }
}
