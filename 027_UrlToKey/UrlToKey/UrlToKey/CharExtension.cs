using System;
using System.Collections.Generic;
using System.Text;

namespace UrlToKey
{
    public static class CharExtension
    {
        public static string ToKey(this char c)
        {
            string result = c.ToString();

            if (c == '/')
            {
                return string.Empty;
            }
            if (c < 65
                || c > 122
                || (c > 90 && c < 97))
            {
                return result;
            }
            else
            {
                if (c < 'a')
                {
                    result = $"_{(char)(c + 32)}";
                }
            }

            return result;
        }
    }
}
