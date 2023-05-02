using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeworkForInheritance
{
    public class Student :Person
    {
        public string Department { get; set; }
        public string Level { get; set; }
        public string RegUser { get; set; }
        public DateTime RegdDate { get; set; }
        public string EditUser { get; set; }
        public DateTime EditDate { get; set; }
        public bool Deleted { get; set; }
    }
}
