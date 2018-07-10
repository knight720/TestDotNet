using System;

namespace ConsoleTestFunc
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var p = new Program();
            var result = p.GetData("Key");
            Console.WriteLine(result);
            result = p.GetData("Kkk");
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private string cache;

        private string GetData(string key)
        {
            Func<string> getDataFunc = () =>
            {
                return this.GetData(key);
            };

            //// key 加入 locale
            key = this.AppendLocale(key);

            var result = string.Empty;
            if (cache != null)
            {
                result = getDataFunc();
            }
            else
            {
                cache = key;
                result = key; 
            }

            

            return result;
        }

        private string AppendLocale(string name)
        {
            var result = $"{name}-ABC";
            return result;
        }
    }
}