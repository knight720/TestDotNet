namespace Translation_Column_Code_Key
{
    internal interface IDefinitionKey
    {
        string ColumnName { get; set; }

        string Code { get; set; }

        string Key { get; }
    }
}