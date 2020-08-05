using System;
using System.Net;
using Newtonsoft.Json;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://api.softwareavanzado.world/index.php?webserviceClient=administrator&webserviceVersion=1.0.0&option=contact&id=1&api=hal";
            var json = new WebClient().DownloadString(url);
            dynamic m = JsonConvert.DeserializeObject(json);
            Console.WriteLine(json);
            
        }
    }
}
