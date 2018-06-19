using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Translation_Column_Code_Key
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var columnName = "ShopShippingType_FeeTypeDef";
            var code = "Free";

            Console.WriteLine(NY.WS.T.Backend.Definition.ShopShippingType.FeeTypeDefFixed);

            var key = GetKey(columnName, code);
            //fee_type_def_free
            Console.WriteLine(NY.WS.T.Backend.Definition.ShopShippingType.GetString(key));

            Console.ReadLine();
        }

        private static string GetKey(string columnName, string code)
        {
            var column = columnName.Split('_').Last();
            string[] split = Regex.Split(column, @"(?<!^)(?=[A-Z])");
            List<string> keyList = split.ToList();
            keyList.Add(code);
            keyList = keyList.ConvertAll(s => s.ToLower());

            return string.Join("_", keyList);
        }
    }
}