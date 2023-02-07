using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Homework 3: App'ın işləmə prinsipi: İlk öncə istifadəçidən "Texmin oyunu ucun en yuksek deyeri 
             * daxil edin: " yazısı ilə bir rəqəm alınmalıdır.Sonra 1 ilə bu rəqəm arasında random bir rəqəm 
             * generate edilməlidir və istifadəçidən generate olunan rəqəmi
              tapmağı istənməlidir. "1. Cəhdiniz! Zəhmət olmasa rəqəmi təxmin edin: 
              " mesajı ilə istifadəçidən bir rəqəm soruşulur. Hər səhv daxil edilən rəqəmdə eyni şey təkrar
              göstərilir.Sadəcə 2. 3. 4.deyə artır cəhd sayı.İstifadəçi düzgün rəqəmi
                tapdığı zaman "5. Cəhdinizdə düzgün rəqəmi tapdınız!" mesajı göstərilməlidir.*/

            
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int gameMaxNumber, counter=1, generatedNumber, userGestNumber;

            Console.WriteLine("BU BİR  TƏXMİN  OYUNUDUR !!!");
            Console.WriteLine("____________________________");

            Console.Write("Təxmin oyunu üçün generate olunacaq ən yüksək rəqəmi  girin :");
            gameMaxNumber = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();
            generatedNumber = rand.Next(0, gameMaxNumber);
            Console.WriteLine(generatedNumber);
            Console.WriteLine("Oyun Başladı !!!");
            Console.Write(counter+".Təxmininizi girin :");
            userGestNumber = Convert.ToInt32(Console.ReadLine());
           

            while (userGestNumber!=generatedNumber)
            {
                counter++;
                if (userGestNumber>generatedNumber)
                {
                    Console.Write(counter + ".Təxmininizi yalnışdır.Bir az azaldın :");
                    userGestNumber = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.Write(counter + ".Təxmininizi yalnışdır.Bir az artırın :");
                    userGestNumber = Convert.ToInt32(Console.ReadLine());
                }
                
            }
            Console.WriteLine("Təbrik edirik.Tutulan sayını "+counter+" dəfədə tapdınız");
            Console.ReadLine();



        }
    }
}
