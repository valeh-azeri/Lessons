using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Base
    {
        public static int counter = 1;
        private int _id;
        public int Id
        {
            get
            {
                return this._id ;
            }
            private set
            {
            }
        }

        public DateTime CreateDate { get; set; }
        public int CreateUser { get; set; }
        public DateTime? EditDate { get; set; }
        public int EditeUser { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int DeleteUser { get; set; }

        public Base()
        {
            _id = counter;
            counter++;
        }
    }
}
