using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static readonly Dictionary<string, string> _currencyFormatDictionary
            = new Dictionary<string, string>
            {
                { "TW", "N0" },
                { "MY", "N2" }
            };
         
        static void Main(string[] args)
        {
            var country = "TW";
            var format = "N0";
            _currencyFormatDictionary.TryGetValue(country, out format);
            Console.WriteLine("{0}: {1}",country, format);

            country = "MY";
            format = "N0";
            _currencyFormatDictionary.TryGetValue(country, out format);
            Console.WriteLine("{0}: {1}", country, format);

            //// TryGetValue 會洗掉預設值
            country = "US";
            format = "N0";
            Console.WriteLine("{0}: {1}", country, format);
            _currencyFormatDictionary.TryGetValue(country, out format);
            Console.WriteLine("{0}: {1}", country, format);

            Console.ReadLine();
        }
    }
}
