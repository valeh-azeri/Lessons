using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomework
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public virtual void ShowInfo()
        {
            
            Console.WriteLine("ID: "+Id+"\n Name :"+Name+ "\n Surname: " + Surname);
        }

    }
}
