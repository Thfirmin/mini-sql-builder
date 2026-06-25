namespace MiniSqlBuilder.Lib.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public sealed class MsbTableAttribute : Attribute
{
    public string TableName { get; }

    public MsbTableAttribute(string tableName)
    {
        if (string.IsNullOrWhiteSpace(tableName))
            throw new ArgumentException("Table name cannot be null or whitespace");

        if (tableName.Length > 100)
            throw new ArgumentException("Table name cannot be longer than 100 characters");

        TableName = tableName.Trim();
    }
}