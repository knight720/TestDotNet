using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int _MaxTimes = 999999;
        static int _ListCount = 2;

        static void Main(string[] args)
        {
            Stopwatch watch = Stopwatch.StartNew();
            for (int i = 0; i < _MaxTimes; i++)
            {
                Method1();
            }
            watch.Stop();
            Console.WriteLine("General: {0:N0}ms", watch.ElapsedMilliseconds);

            watch = Stopwatch.StartNew();
            for (int i = 0; i < _MaxTimes; i++)
            {
                Method2();
            }
            watch.Stop();
            Console.WriteLine("List: {0:N0}ms", watch.ElapsedMilliseconds);

            watch = Stopwatch.StartNew();
            for (int i = 0; i < _MaxTimes; i++)
            {
                Method3();
            }
            watch.Stop();
            Console.WriteLine("List ot Array: {0:N0}ms", watch.ElapsedMilliseconds);

            watch = Stopwatch.StartNew();
            for (int i = 0; i < _MaxTimes; i++)
            {
                Method4();
            }
            watch.Stop();
            Console.WriteLine("HasSet: {0:N0}ms", watch.ElapsedMilliseconds);

            Console.ReadLine();
        }

        static void Method1()
        {
            var input = Generate();
            if (input != Generate())
            {
                // Do Nothing
            }
        }

        static void Method2()
        {
            var inputList = new List<string>();
            inputList.Add(Generate());

            for (int i = 0; i< _ListCount;i++)
            {
                if ("area" == "area")
                {
                    inputList.Add(Generate());
                }
            }

            if (inputList.Contains(Generate()))
            {
                // Do Nothing
            }
        }

        static void Method3()
        {
            var inputList = new List<string>();
            inputList.Add(Generate());

            for (int i = 0; i < _ListCount; i++)
            {
                if ("area" == "area")
                {
                    inputList.Add(Generate());
                }
            }

            var inputArray = inputList.ToArray();
            if (inputArray.Contains(Generate()))
            {
                // Do Nothing
            }
        }

        static void Method4()
        {
            var inputSet = new HashSet<string>();
            inputSet.Add(Generate());

            for (int i = 0; i < _ListCount; i++)
            {
                if ("area" == "area")
                {
                    inputSet.Add(Generate());
                }
            }

            if (inputSet.Contains(Generate()))
            {
                // Do Nothing
            }
        }


        static string Generate()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
