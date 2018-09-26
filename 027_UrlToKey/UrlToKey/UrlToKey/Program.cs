using System;

namespace UrlToKey
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input Url (':q' to exit): ");
                var url = Console.ReadLine();

                if (url.Equals(":q")) break;
                if (string.IsNullOrEmpty(url)) continue;

                var key = UrlToKey.Convert(url);
                Console.WriteLine($"Output: {key}");
                Console.WriteLine();
            }
        }
    }

    
}
