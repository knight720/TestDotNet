using System;
using System.Collections.Generic;
using System.Text;

namespace UrlToKey
{
    public class UrlToKey
    {
        public static string Convert(string url)
        {
            if (url.Length < 8) return string.Empty;
            
            int start = url.IndexOf('/', 8);
            url = url.Substring(start+1);

            if (string.IsNullOrEmpty(url)) return string.Empty;

            StringBuilder sb = new StringBuilder();

            foreach (var c in url)
            {

                sb.Append(c.ToKey());
            }

            if (sb[0].Equals('_')) sb.Remove(0, 1);

            return sb.ToString();
        }
    }
}
