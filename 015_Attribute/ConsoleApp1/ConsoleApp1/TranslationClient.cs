using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TranslationClient
    {
        public string GetString(string module, string key, string defalutValue)
        {
            return defalutValue + DateTime.Now.ToLocalTime();
        }
    }
}
