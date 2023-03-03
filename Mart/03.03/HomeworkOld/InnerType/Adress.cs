using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    class Adress
    {
        public int Id { get; set; }
        public int No{ get; set; }
        public string Building{ get; set; }
        public string Street{ get; set; }
        public string Distinct{ get; set; }
        public DateTime CreatDate { get; set; }
        public DateTime? EditDate { get; set; }

        //Inner Type
        public City City;
    }
}
