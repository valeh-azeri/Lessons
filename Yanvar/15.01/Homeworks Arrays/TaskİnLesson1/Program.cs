using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TaskİnLesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            string choise;
            ArrayList arrList = new ArrayList();
            do
            {
                Console.WriteLine("1. Element Elave et");
                Console.WriteLine("2. Elementleri goste");
                Console.WriteLine("3. Element axtar");
                Console.WriteLine("4. Element editle");
                Console.WriteLine("5. Element sil");
                Console.WriteLine("6. Exit");

                Console.WriteLine("Seçiminizi edin :");
                choise = Console.ReadLine();

                switch (choise)
                {
                    case "Menyu": {
                            
                            Console.WriteLine("1. Element Elave et");
                            Console.WriteLine("2. Elementleri goste");
                            Console.WriteLine("3. Element axtar");
                            Console.WriteLine("4. Element editle");
                            Console.WriteLine("5. Element sil");
                            Console.WriteLine("6. Exit");
                            Console.WriteLine("Seçiminizi edin :");
                            choise = Console.ReadLine();
                        } break;
                    case "1": 
                        {
                            Console.WriteLine("Zəhmət olmasa daxil etmək istədiyiniz elementi yazın :");
                            arrList.Add(Console.ReadLine());
                            Console.WriteLine("Element əlavə olundu");
                            
                            goto case "Menyu";
                        }

                    case "2":
                        {
                            for (int i = 0; i < arrList.Count; i++)
                            {
                                Console.WriteLine("{0}.Element-{1}", (i + 1), arrList[i]);
                                
                            }
                            Console.WriteLine("Daxil etmək üçün  bir  tuşa basın :");
                            Console.ReadLine();
                            goto case "Menyu";
                        }
                        case "3":
                        {
                            Console.Write("Axtaracağınız elementi daxil edin ");
                            string arrElemen = Console.ReadLine();
                            if (arrList.IndexOf(arrElemen)>0) 
                            {
                                Console.WriteLine("Element tapıldı:");
                            }
                        }
                        break;
                }

            } while (choise!="6");
        }
    }
}
