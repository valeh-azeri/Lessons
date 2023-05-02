using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Car
    {
        /*(Property'ləri: Şəhər (satıldığı), Marka, Model, Buraxılış ili,
            Rəngi, Mühərrik Həcmi, At Gücü, Kilometrajı, Sürətlər Qutusunun tipi, Qiyməti).
            Bir list'in içinə bir neçə dənə Car əlavə edib nümunədən aşağıdakı sorğuları yazacaqsınız.*/
        public int CarID { get; set; }
        public string CarMark { get; set; }
        public string CarModel { get; set; }
        public DateTime CarYear { get; set; }
        public string SellerCity { get; set; }
        public EnumColor Color { get; set; }
        public string Engine { get; set; }
        public string  EngineValue { get; set; }
        public string  EngineForce { get; set; }
        public int  Kilometr { get; set; }
        public EnumVelcityBox  VelocityBox { get; set; }
        public int  Price { get; set; }







    }
}
