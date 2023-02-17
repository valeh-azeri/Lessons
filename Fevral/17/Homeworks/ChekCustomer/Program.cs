using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChekCustomer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           Homework 1:
           İnternetdə Access Modifiers mövzusunu araşdırın və elə edin ki, CheckCustomerFromDb methodunu nə public nədə private istifadə etmədən,
           Program class'ında istifadə edə bilim. Inherit almaq şansınız yoxdur, yanlız aşağıdakı kimi yazanda işləməlidir və dəyişikliyi Customer
           class'ı tərəfdə etməlisiniz.

           Nümunə:
           Customer customer = new Customer();
           customer.CheckCustomerFromDb();
           */
                     
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Qeydiyyatınızı tamamlamaq  üçün  aşağıdakı formu doldurun :");

            Console.WriteLine("Adinizi  girin ");
            string Name = Console.ReadLine();
            Console.WriteLine("Soyadinizi girin ");
            string Surname = Console.ReadLine();
            Console.WriteLine("Şəxsiyyət vəsiqəsi nömrənizi girin ");
            string  DocumentNumber = Console.ReadLine();
            Console.WriteLine("Şəxsiyyət vəsiqəsinin seriasını girin");
            string  DocumentSerial = Console.ReadLine();
            Console.WriteLine("Adresinizi girin");
            string  Address = Console.ReadLine();

            Customer newRegistration = new Customer(DocumentNumber, DocumentSerial, Name, Surname, Address);

            newRegistration.Name = Name;
            newRegistration.Surname = Surname;
            newRegistration.DocumentNumber = DocumentNumber;
            newRegistration.DocumentSerial = DocumentSerial;
            newRegistration.Address = Address;

            bool isUserDuplicate = newRegistration.CheckCustomer();

            if (isUserDuplicate==true)
            {

                Console.WriteLine("Bu istifadəçi  artıq  qeydiyyatdan keçib");
            }
            else

                
                newRegistration.Register();
                Console.ReadLine();

                }
            
           
        }
        

    }

