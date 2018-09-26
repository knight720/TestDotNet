using System;
using System.Collections;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TranslationClient tc = new TranslationClient();
            TranslationService ts = new TranslationService(tc);

            Console.WriteLine("Data");
            var entity1 = new TRAEntity("aaa", 1);
            Console.WriteLine(entity1);
            var entity2 = new OAEntity("bbb", 2);
            Console.WriteLine(entity2);
            var entity3 = new NonTRAEntity("ccc", 3);
            Console.WriteLine(entity3);
            var entity4 = new ErrorEntity("ddd", 4);
            Console.WriteLine(entity4);

            Console.WriteLine("Translat By Entity");
            ts.Translation(entity1);
            Console.WriteLine(entity1);
            ts.Translation(entity2);
            Console.WriteLine(entity2);
            ts.Translation(entity3);
            Console.WriteLine(entity3);
            ts.Translation(entity4);
            Console.WriteLine(entity4);

            Console.WriteLine("Translat By List");
            ArrayList list = new ArrayList();
            list.Add(entity1);
            list.Add(entity2);
            list.Add(entity3);
            list.Add(entity4);
            ts.Translation(list);
            Console.WriteLine(entity1);
            Console.WriteLine(entity2);
            Console.WriteLine(entity3);
            Console.WriteLine(entity4);

            Console.ReadLine();
        }
    }
}