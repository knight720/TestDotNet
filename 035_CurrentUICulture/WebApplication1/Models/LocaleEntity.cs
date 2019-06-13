using System.Globalization;

namespace WebApplication1.Models
{
    public class LocaleEntity
    {
        public string InnerLocale
        {
            get { return CultureInfo.CurrentUICulture.Name; }
        }

        public string OuterLocale { get; set; }
    }
}