using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    class Order
    {
        public int Id { get; set; }
        public string OrderDetails { get; set; }
        public Adress ShippingAdress { get; set; }
        public DateTime CreatDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}
