using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            for (var i = 0; i < 100000; i++)
            {
                Work w = new Work(i);
                w.Action();
            }

            Console.WriteLine("end...");
            Console.Read();

        }


    }
}
