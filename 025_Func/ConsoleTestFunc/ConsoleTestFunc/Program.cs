using System;

namespace ConsoleTestFunc
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var p = new Program();

            var result = p.GetRData("rKey");
            //Console.WriteLine(result);

            Console.WriteLine("===");

            result = p.GetMData("mKey");
            //Console.WriteLine(result);
            
            Console.ReadLine();
        }

        private string _mCache;
        private string _rCache;

        private string GetMData(string key)
        {
            Func<string> getDataFunc = () =>
            {
                return this.GetRData(key);
            };

            //// key 加入 locale
            key = this.AppendLocale(key);

            var result = string.Empty;
            if (this._mCache == null)
            {
                result = getDataFunc();
                this._mCache = result;
            }
            else
            {
                result = this._mCache;
            }

            Console.WriteLine($"GetMDate: {key}");

            return result;
        }

        private string GetRData(string key)
        {
            //// key 加入 locale
            key = this.AppendLocale(key);

            var result = string.Empty;
            if (this._rCache != null)
            {
                result = this._rCache;
            }
            else
            {
                this._rCache = key;
                result = key;
            }

            Console.WriteLine($"GetRDate: {key}");

            return result;
        }

        private string AppendLocale(string name)
        {
            var result = $"{name}-ABC";
            return result;
        }
    }
}