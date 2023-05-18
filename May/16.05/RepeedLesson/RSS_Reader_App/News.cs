using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_Reader_App
{
    public class News
    {
        public string Header { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Header;
        }

    }

    
}

