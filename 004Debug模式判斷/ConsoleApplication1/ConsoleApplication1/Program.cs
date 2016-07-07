using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Debugger.IsAttached)
            {
                Console.WriteLine("Debug");
            }
            else Console.WriteLine("Not Debug");

            Console.ReadLine();
        }
    }
}
