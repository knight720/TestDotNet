using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Work
    {
        private static Random _random = new Random();
        private long Id { get; set; }
        private int _sleep;

        public Work(long id)
        {
            this.Id = id;
        }

        public void Action()
        {
            this._sleep = Work._random.Next(500);
            Thread.Sleep(this._sleep);

            var shopId = 8;
            this.Method(shopId);
        }

        private void Method(long value)
        {
            Console.WriteLine($"{this.Id}: {value} {this._sleep}");
        }
    }
}
