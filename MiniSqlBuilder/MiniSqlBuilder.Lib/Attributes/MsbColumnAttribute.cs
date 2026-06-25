namespace MiniSqlBuilder.Lib.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public sealed class MsbColumnAttribute : Attribute
{
    public string ColumnName { get; }

    public MsbColumnAttribute(string columnName)
    {
        if (string.IsNullOrWhiteSpace(columnName))
            throw new ArgumentException("Column name cannot be null or whitespace");

        if (columnName.Length > 100)
            throw new ArgumentException("Column name cannot be longer than 100 characters");

        ColumnName = columnName.Trim();
    }
}