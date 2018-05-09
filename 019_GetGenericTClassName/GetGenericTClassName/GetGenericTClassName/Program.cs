using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetGenericTClassName
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.PrintClassName("abc");
            Program.PrintClassName(1);

            var obj = DateTime.Now;
            Program.PrintClassName(obj);

            Program.PrintClassName2<DateTime>();

            var obj2 = Program.GetDefaultEntity<OneClass>();
            Console.WriteLine(obj2);


            Console.Write("Finish!");
            Console.ReadLine();
        }

        static void PrintClassName<T>(T obj)
        {
            var type = obj.GetType();
            Console.WriteLine(type.FullName);
            
        }

        static void PrintClassName2<T>()
        {
            var type = typeof(T);
            Console.WriteLine(type.FullName);
        }

        static T GetDefaultEntity<T>()
        {
            var type = typeof(T);

            if (type.Equals(typeof(OneClass)))
            {
                var entity = new OneClass
                {
                    A = "AAA",
                    B = 111,
                    C = true
                };
                return (T)Convert.ChangeType(entity, type);
            }
            else
            {
                return default(T);
            }
        }
    }

    class OneClass
    {
        public string A { get; set; }
        public int B { get; set; }
        public bool C { get; set; }

        public override string ToString()
        {
            return $"{A}, {B}, {C}";
        }
    }
}
