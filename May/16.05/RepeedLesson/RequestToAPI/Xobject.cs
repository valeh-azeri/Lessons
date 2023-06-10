using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestToAPI
{
    public class Xobject
    {
        public string Status { get; set; }
        [JsonProperty("status-code")]
        public int StatusCode { get; set; }
        public string Version { get; set; }
        public string Access { get; set; }
        public IDictionary<string, SingleCountry> Data { get; set; }
    }

    public class SingleCountry
    {
        public string Country { get; set; }
        public string Region { get; set; }
    }
}
