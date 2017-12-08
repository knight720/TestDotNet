using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Work
    {
        private long Id { get; set; }

        public Work(long id)
        {
            this.Id = id;
        }

        public void Action()
        {
            var shopId = 8;
            this.Method(shopId);
        }

        private void Method(long value)
        {
            Console.WriteLine(string.Format("{0}: {1}", this.Id, value));
        }
    }
}
