using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NonTRAEntity
    {
        public NonTRAEntity(string a, int b)
        {
            this.AProperty = a;
            this.BProperty = b;
        }

        public string AProperty { get; set; }

        public int BProperty { get; set; }

        public override string ToString()
        {
            return $"{this.AProperty}, {this.BProperty}";
        }
    }
}
