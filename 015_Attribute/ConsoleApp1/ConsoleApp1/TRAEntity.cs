using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TRAEntity
    {
        public TRAEntity(string a, int b)
        {
            this.AProperty = a;
            this.BProperty = b;
        }

        [RequireTranslation(Module = "module")]
        public string AProperty { get; set; }

        [Other(Value = 1)]
        public int BProperty { get; set; }

        public override string ToString()
        {
            return $"{this.AProperty}, {this.BProperty}";
        }
    }
}
