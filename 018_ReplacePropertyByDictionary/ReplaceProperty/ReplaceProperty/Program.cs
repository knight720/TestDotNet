using System;
using System.Collections.Generic;
using System.Linq;

namespace ReplaceProperty
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var p = new Program();
            p.Run();

            Console.ReadLine();
        }

        public void Run()
        {
            var dic = new Dictionary<string, string>();
            dic.Add("a", "A123");
            dic.Add("b", "B");

            var dicInt = new Dictionary<int, int>();
            dicInt.Add(1, 99);
            dicInt.Add(2, 88);

            var c = new COne("a", 1);
            Console.WriteLine(c);

            this.ReplaceProperty(c, "POne", dic);
            Console.WriteLine(c);

            this.ReplaceProperty(c, "PTwo", dicInt);
            Console.WriteLine(c);
        }

        /// <summary>
        /// Replace object property
        /// </summary>
        /// <param name="obj">Target Object</param>
        /// <param name="propertyName">Property Name</param>
        /// <param name="dictionary">Dictionary Source</param>
        private void ReplaceProperty<T>(object obj, string propertyName, IDictionary<T, T> dictionary)
        {
            var type = obj.GetType();
            if (type.GetProperties().Any(i => i.Name.Equals(propertyName)))
            {
                var property = type.GetProperty(propertyName);
                if (property.CanWrite == true
                    && property.PropertyType == typeof(T)
                    && property.GetValue(obj) != null)
                {
                    var value = (T)property.GetValue(obj);
                    if (dictionary.ContainsKey(value))
                    {
                        var newValue = dictionary[value];
                        property.SetValue(obj, newValue);
                    }
                }
            }
        }
    }

    internal class COne
    {
        public string POne { get; set; }

        public int PTwo { get; set; }

        public COne(string o, int t)
        {
            this.POne = o;
            this.PTwo = t;
        }

        public override string ToString()
        {
            return $"{this.POne}, {this.PTwo}";
        }
    }
}