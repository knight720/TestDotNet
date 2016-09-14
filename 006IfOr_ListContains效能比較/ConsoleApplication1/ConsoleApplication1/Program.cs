using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            strList = new List<string>();
            for (int i = 0; i < 100; i++) strList.Add("A");

            Case1();
            Case2();
            Case3();
            Case4();


            //Run ifor = IfOr;
            //RunAndMeasure(ifor);


            Console.ReadLine();
        }

        static int times = 1000000;
        static string value = "B";
        static List<string> strList;

        /// <summary>
        /// // List with Contains
        /// </summary>
        public static void Case1()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < times; i++)
            {
                if (strList.Contains(value))
                {
                    int a = 0;
                }
            }

            sw.Stop();
            Console.WriteLine(string.Format("List Conatins {0}s", sw.Elapsed.TotalSeconds));
        }

        /// <summary>
        /// if or
        /// </summary>
        public static void Case2()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < times; i++)
            {
                if (value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //1
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //2
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //3
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //4
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //5
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //6
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //7
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //8
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //9
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //10
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //11
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //12
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //13
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //14
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //15
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //16
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //17
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //18
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //19
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A"  //20
                    )
                {
                    int a = 0;
                }
            }

            sw.Stop();
            Console.WriteLine(string.Format("If Or {0}s", sw.Elapsed.TotalSeconds));
        }

        public static void Case3()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < times; i++)
            {
                if (value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //1
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //2
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //3
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //4
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //5
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //6
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //7
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //8
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //9
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //10
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //11
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //12
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //13
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //14
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //15
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //16
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //17
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //18
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //19
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "B"  //20
                    )
                {
                    int a = 0;
                }
            }

            sw.Stop();
            Console.WriteLine(string.Format("If Or {0}s", sw.Elapsed.TotalSeconds));
        }

        public static void Case4()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < times; i++)
            {
                if (value == "B" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" || //1
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" || //2
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" || //3
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" || //4
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" || //5
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" || //6
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" || //7
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" || //8
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" || //9
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" || //10
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" || //11
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" || //12
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" || //13
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" || //14
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" || //15
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" || //16
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" || //17
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" || //18
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" || //19
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "A" ||
                    value == "B"  //20
                    )
                {
                    int a = 0;
                }
            }

            sw.Stop();
            Console.WriteLine(string.Format("If Or {0}s", sw.Elapsed.TotalSeconds));
        }

        delegate void Run();

        //public static void RunAndMeasure(Run run)
        //{
        //    Stopwatch sw = new Stopwatch();
        //    sw.Start();

        //    run.Invoke();

        //    sw.Stop();
        //    Console.WriteLine(string.Format("List Conatins {0}s", sw.Elapsed.TotalSeconds));
        //}

        /// <summary>
        /// // List with Contains
        /// </summary>
        public static void ListContains()
        {
            for (int i = 0; i < times; i++)
            {
                if (strList.Contains(value))
                {
                    int a = 0;
                }
            }
        }

        /// <summary>
        /// if or
        /// </summary>
        public static void IfOr()
        {
            for (int i = 0; i < times; i++)
            {
                if (value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //1
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //2
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //3
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //4
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //5
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //6
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //7
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //8
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //9
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //10
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //11
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //12
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //13
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //14
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //15
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //16
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //17
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //18
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" | //19
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A" |
                    value == "A"  //20
                    )
                {
                    int a = 0;
                }
            }
        }
    }
}
