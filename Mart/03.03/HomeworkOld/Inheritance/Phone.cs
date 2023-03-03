using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Phone : Settings
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool FastCharge { get; set; }
        public string MadeInCountry { get; set; }
        public decimal Price { get; set; }
    }
}
