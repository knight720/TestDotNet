namespace NY.WS.T.Backend.Definition
{
    public class ShopShippingType
    {
        public static string GetString(string key, string defaultValue = null)
        {
            return string.Join(".", new string[]{ "backend.definition.shop_shipping_type", key});
        }

        public static string FeeTypeDefFixed { get { return GetString("fee_type_def_fixed"); } }
        public static string FeeTypeDefFree { get { return GetString("fee_type_def_free"); } }
        public static string FeeTypeDefOverPrice { get { return GetString("fee_type_def_over_price"); } }
        public static string FeeTypeDefWeightBilling { get { return GetString("fee_type_def_weight_billing"); } }
    }
}