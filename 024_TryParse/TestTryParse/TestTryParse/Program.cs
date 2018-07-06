using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isEnable = true;
            // null > False
            // string.Empty > False
            // "false" or "False" > Fasle 
            // "aalse" > Fasle 
            // "true" or "True" or "TrUe" > True
            string strIsEnable = "TrUe";
            bool.TryParse(strIsEnable, out isEnable);

            Console.WriteLine(isEnable);

            Console.ReadLine();
        }
    }
}
