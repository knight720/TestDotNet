using System;

namespace ConsoleApp1
{
    /// <summary>
    /// Translation Property
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class RequireTranslationAttribute : Attribute
    {
        /// <summary>
        /// Moduel Name
        /// </summary>
        public string Module { get; set; }
    }
}