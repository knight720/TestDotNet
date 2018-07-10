using System;

namespace ConsoleTestFunc
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var p = new Program();

            var result = p.GetRData("rKey");
            Console.WriteLine(result);

            Console.WriteLine("===");
            result = p.GetMData("mKey");
            Console.WriteLine(result);

            Console.WriteLine("===");
            result = p.GetRData("rKey");
            Console.WriteLine(result);

            Console.WriteLine("===");
            result = p.GetMData("mKey");
            Console.WriteLine(result);

            Console.WriteLine("===");
            result = p.GetRData("rKey", true);
            Console.WriteLine(result);

            Console.WriteLine("===");
            result = p.GetMData("mKey", true);
            Console.WriteLine(result);

            Console.ReadLine();
        }

        private string _mCache;
        private string _rCache;

        private string GetMData(string key, bool clear = false)
        {
            Func<string> getDataFunc = () =>
            {
                return this.GetRData(key);
            };

            if (clear)
            {
                this._mCache = null;
            }

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

            Console.WriteLine($"GetMDate Key: {key}");

            return result;
        }

        private string GetRData(string key, bool clear = false)
        {
            //// key 加入 locale
            key = this.AppendLocale(key);

            if (clear)
            {
                this._rCache = null;
            }

            var result = string.Empty;
            if (this._rCache == null)
            {
                result = $"RData: {DateTime.Now.Millisecond}";
                this._rCache = result;
            }
            else
            {
                result = this._rCache;
            }

            Console.WriteLine($"GetRDate Key: {key}");

            return result;
        }

        private string AppendLocale(string name)
        {
            var result = $"{name}-ABC";
            return result;
        }
    }
}