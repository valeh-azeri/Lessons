﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    class Program

    {


        static void Main(string[] args)

        {

            /*Əvvəlcədən iki dəyişəndə username və password saxlayın.Bunlar heç bir zaman dəyişməyəcək 
             * şəkildə olsun.
             Yəni proqramda belə dəyişdirmək mümkün olmasın
             Sonra istifadəçidən username və password'u daxil etməsini istəyin. 
             Əgər istifadəçi doğru məlumatları yazsa 
             ekrana "Sisteme daxil olundu." mesajı çıxsın.
             Yox əgər səhv məlumat daxil etsə, yenidən username və password'u daxil etməsini istəyin. 
             3 dəfə səhv daxil 
             etdikdən sonra "Hesab bloklandi" yazsın.
             Not: Switch case və döngülərdən istifadə etmək olmaz.*/
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int loginTimes = 1;

            Console.WriteLine("istifadeci adi girin :");
            string loginString = Console.ReadLine();

            Console.WriteLine("istifadeci adi girin :");
            string passwordString = Console.ReadLine();

            const string login = "kimya", password = "123";

            if (loginString==login && passwordString==password)
            {
                Console.WriteLine("Giriş edildi");
            }

            else if (loginTimes == 1 || loginString != login && loginString != password)
            {
                Console.WriteLine("Istifadəçi  adı və ya  şifrə  yalnışdır");
                loginTimes++;
                Console.WriteLine("istifadeci adi girin :");
                loginString = Console.ReadLine();

                Console.WriteLine("istifadeci adi girin :");
                passwordString = Console.ReadLine();
            }
                if (loginString == login && passwordString == password)
                {
                    Console.WriteLine("Giriş edildi");
                }

                     if (loginTimes == 2 || loginString != login && loginString != password)
                        {
                            Console.WriteLine("Istifadəçi  adı və ya  şifrə  yalnışdır");
                            loginTimes++;

                            Console.WriteLine("istifadeci adi girin :");
                            loginString = Console.ReadLine();

                            Console.WriteLine("istifadeci adi girin :");
                            passwordString = Console.ReadLine();
                        }
                        if (loginString == login && passwordString == password)
                        {
                            Console.WriteLine("Giriş edildi");
                        }
                       
                        else if (loginTimes == 2 || loginString != login && loginString != password)
                        {
                            Console.WriteLine("Girişiniz  bloklandı");
                        }
            
            Console.ReadLine();
            

              
            

                       
            
        }
    }
}
