using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.VisualBasic;

namespace ConsoleApp1
{
    class Program
    {
        private IDictionary<int, string> _dictinary;
        private IReadOnlyDictionary<int, string> _readOnlyDictionary;
        static void Main(string[] args)
        {
            var p = new Program();

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        private Program()
        {
            this._dictinary = new Dictionary<int, string>();

            this._dictinary = new Dictionary<int, string>(){
                { 1, "One" },
                { 2, "Two" }
            };

            ////未提供任何可對應到 'ReadOnlyDictionary<int, string>.ReadOnlyDictionary(IDictionary<int, string>)' 之必要型式參數 'dictionary' 的引數
            //this._readOnlyDictionary = new ReadOnlyDictionary<int, string>(); 
            this._readOnlyDictionary = new Dictionary<int, string>
            {
                { 1, "One"},
                { 2, "Two" }
            };

            this.InitialDictionary();
        }

        private void InitialDictionary()
        {
            
            this._dictinary = new Dictionary<int, string>(){
                { 1, "One" },
                { 2, "Two" }
            };

            this._readOnlyDictionary = new Dictionary<int, string>
            {
                { 1, "One"},
                { 2, "Two" }
            };

        }

    }
}
