using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGoogleTranslate
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://translate.googleapis.com/translate_a/single";
            string sourceLanguage = "zh-TW";
            string targetLanguage = "en";
            string text = "中文";

            string fullUrl = $"{url}?client=gtx&sl={sourceLanguage}&tl={targetLanguage}&dt=t&q={text}";

            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.GetEncoding(950);
            string responce = webClient.DownloadString(fullUrl);

            Console.WriteLine(responce);
            Console.ReadLine();
        }
    }
}
