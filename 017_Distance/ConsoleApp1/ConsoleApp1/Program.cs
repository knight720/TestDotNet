using System;
using System.Collections.Generic;
using System.Linq;
using System.Spatial;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var gp1 = GeographyPoint.Create(121.5, 23.5);
            var gp2 = GeographyPoint.Create(121.4, 23.6);
            var distance = GeographyOperationsExtensions.Distance(gp1, gp2);
            Console.WriteLine($"{gp1}, {gp2}, Distance: {distance}");
            Console.ReadLine();
        }
    }
}
