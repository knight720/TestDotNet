using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JsonParser
{
    class Program
    {
        static string _Url = "https://alerts.ncdr.nat.gov.tw/JSONAtomFeed.ashx?AlertType=8";

        static void Main(string[] args)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var json = wc.DownloadString(_Url);

                Debug.WriteLine(json);

                //var obj = JsonConvert.DeserializeObject(json);
                JObject obj = JObject.Parse(json);

                Console.WriteLine(obj["entry"][0]["link"]["@href"]);

            }

            Console.Read();
        }
    }
}
