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

            for (int i = 0; i < 100000; i++)
            {
                var shopId = 8;
                object obj = (object)shopId;

                var type = obj.GetType().ToString();
                Console.WriteLine(type);

                switch (type)
                {
                    case "System.Int32":
                        break;
                    default:
                        break;
                }

            }

            Console.WriteLine("end...");
            Console.Read();

        }
    }
}
