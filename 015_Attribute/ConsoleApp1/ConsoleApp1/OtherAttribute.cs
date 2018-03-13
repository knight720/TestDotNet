using System;

namespace ConsoleApp1
{
    /// <summary>
    /// Translation Property
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class OtherAttribute : Attribute
    {
        /// <summary>
        /// Moduel Name
        /// </summary>
        public int Value { get; set; }
    }
}