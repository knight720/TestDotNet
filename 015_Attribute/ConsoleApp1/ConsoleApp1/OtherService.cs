using System;
using System.Collections;
using System.Linq;
using System.Reflection;

namespace ConsoleApp1
{
    /// <summary>
    /// OtherService
    /// </summary>
    public class OtherService
    {
        public T DoSomething<T>(T data) where T : class
        {
            //// Return null if empty
            if (data == null)
            {
                return null;
            }

            //// Translation
            if (data is IEnumerable)
            {
                foreach (var item in data as IEnumerable)
                {
                    this.TranslationDataProperty(item);
                }
            }
            else
            {
                this.TranslationDataProperty(data);
            }

            return data;
        }

        /// <summary>
        /// Fill data's property with definitions
        /// </summary>
        /// <typeparam name="T">Data's type</typeparam>
        /// <param name="item">data</param>
        private void TranslationDataProperty<T>(T item)
            where T : class
        {
            //// Get data's type
            var dataType = item.GetType();

            var properties = dataType.GetProperties()
                .Where(prop =>
                Attribute.IsDefined(prop, typeof(OtherAttribute))
                && prop.PropertyType == typeof(int));

            ////未定義需要翻譯的欄位
            if (properties.Count() == 0)
            {
                return;
            }

            foreach (var property in properties)
            {
                object objValue = property.GetValue(item);
                if (objValue == null)
                {
                    continue;
                }

                var attribute = property.GetCustomAttribute<OtherAttribute>();
                Console.WriteLine($"OtherAttribute.Value = {attribute.Value}, OtherAttribute.Content = {attribute.Content}");
                Console.WriteLine($"OtherAttribute.Content is Null : {attribute.Content == null}");
            }
        }
    }
}