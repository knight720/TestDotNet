using System;
using System.Collections;
using System.Linq;
using System.Reflection;

namespace ConsoleApp1
{
    /// <summary>
    /// TranslationService
    /// </summary>
    public class TranslationService
    {
        /// <summary>
        /// ITranslationClient
        /// </summary>
        private TranslationClient _translationClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationService" /> class.
        /// </summary>
        /// <param name="translationClient">ITranslationClient</param>
        public TranslationService(TranslationClient translationClient)
        {
            this._translationClient = translationClient;
        }

        /// <summary>
        /// 翻譯資料內容
        /// </summary>
        /// <typeparam name="T">資料型別</typeparam>
        /// <param name="data">資料</param>
        /// <returns>翻譯後的資料</returns>
        public T Translation<T>(T data) where T : class
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
                Attribute.IsDefined(prop, typeof(RequireTranslationAttribute))
                && prop.PropertyType == typeof(string));

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

                Attribute attribute = property.GetCustomAttribute(typeof(RequireTranslationAttribute));

                var translationAttribute = (RequireTranslationAttribute)attribute;
                string value = objValue.ToString();
                var translation = this._translationClient.GetString(translationAttribute.Module, value, value);
                property.SetValue(item, translation);
            }
        }
    }
}