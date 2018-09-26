using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var list =
                new[] {
                    new { a = 1, b = 2 },
                    new { a = 3, b = 4 },
                    new { a = 5, b = 6 }
                };

            var value = 1;
            var item = list.Where(i => i.a.Equals(value)).First();
            bool isNull = item == null;
            Console.WriteLine($"item {value}  is Null: {isNull}");

            value = 7;
            //// System.InvalidOperationException: '序列未包含項目'
            //item = list.Where(i => i.a.Equals(value)).First();
            item = list.Where(i => i.a.Equals(value)).FirstOrDefault();
            isNull = item == null;
            Console.WriteLine($"item {value}  is Null: {isNull}");

            Console.ReadLine();
        }
    }
}