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
            /* Homework 2:
            Bir Car class'ınız olsun. (Property'ləri: Şəhər (satıldığı), Marka, Model, Buraxılış ili,
            Rəngi, Mühərrik Həcmi, At Gücü, Kilometrajı, Sürətlər Qutusunun tipi, Qiyməti).
            Bir list'in içinə bir neçə dənə Car əlavə edib nümunədən aşağıdakı sorğuları yazacaqsınız.
            Nümunə data:
            Şəhər: Bakı
            Marka: Lexus
            Model: GX460
            Buraxılış ili: 2021
            Rəngi: Black (Enum olacaq və 10-15 dənə rəng olsun Enum'da)
            Mühərrik Həcmi: 4500
            At Gücü: 296
            Kilometrajı: 15777
            Sürətlər Qutusunun tipi: Automatic (Enum olacaq. Dəyərləri də Automatic, Manual, Robot)
            Qiyməti: 200.000

            Aşağıdakı sorğuları yazın:
            1. Markası Mercedes olub, mühərrik həcmi 4200'dən az olan və ya bərabər olan, Bakıda satılan.
            2. Bakıda satılmayan, buraxılış ili 2015-ci il daxil olmaqla 2020-ci ilə qədər olan (2020 də daxildir buna)
            3. Kilometrajı 0 olan və Modelində "ml" sözü olan
            4. Sürətlər qutusu avtomatik olan və qiyməti 15.000-17.500 arasında olan
            5. Rəngi Red, Black olmayan, mühərrik həcmi 2000-4000 arasında olan, sürətlər qutusu Robot olmayan, buraxılış ili 2010-dan köhnə olmayan.
            6. Ya markası Lexus olub, qiyməti 30.000-ə qədər olan ya da markası Mercedes olub qiyməti 45.000-ə qədər olan.*/


           var query1 = DatabaseCar.CarsTable.Where(m => m.EngineValue <= 4200 && m.SellerCity == "Baki");
            var query2 = DatabaseCar.CarsTable.Where(x => x.SellerCity != "Baki" && x.CarYear >= 2015 && x.CarYear <= 2020); 
           
        }
    }
}
