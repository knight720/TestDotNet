using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_nameof
{
    class Program
    {
        static void Main(string[] args)
        {
            ParentClass p = new ParentClass("PA");
            ChildClass c = new ChildClass("CH", "NIU");
            Console.WriteLine(string.Format("{0}: {1}",nameof(p), typeof(ParentClass).ToString()));
            Console.WriteLine(string.Format("{0}: {1}",nameof(c), typeof(ChildClass).ToString()));
            Console.WriteLine(string.Format("{0}: {1}",nameof(args), typeof(string[]).ToString()));
            Console.ReadLine();
        }
    }
}
