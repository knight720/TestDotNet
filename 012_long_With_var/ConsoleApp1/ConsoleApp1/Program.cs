using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            for (var i = 0; i < 10000; i++)
            {
                //Program.SingleThread(i);
                Program.MultiThread(i);
            }

            Console.WriteLine("end...");
            Console.Read();

        }

        static void SingleThread(long id)
        {
            Work w = new Work(id);
            w.Action();
        }

        static void MultiThread(long id)
        {
            Work w = new Work(id);
            Thread thread = new Thread(w.Action);
            thread.Start();
        }

    }


}
