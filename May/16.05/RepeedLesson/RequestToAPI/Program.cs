using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;

namespace RequestToAPI
{
    class Program
    {
        static  void Main(string[] args)
        {
            var client = new HttpClient();

            client.BaseAddress=new Uri(" https://api.first.org/data/v1/");
           
            HttpResponseMessage response = client.GetAsync("countries").Result;

            string getresponse = response.Content.ReadAsStringAsync().Result;

            Directory.CreateDirectory(@"C:\\HomeAPI");
            var file=File.Create(@"C:\\HomeAPI\\Api.json");
            file.Close();
            File.WriteAllText(@"C:\\HomeAPI\\Api.json",getresponse);
            
            Xobject data = JsonConvert.DeserializeObject<Xobject>(getresponse);

        }
    }
}
