using System.Reflection;

namespace MiniSqlBuilder.Lib.Metadata;

public sealed class TableMetadata
{
    public string TableName { get; init; }
    public IReadOnlyDictionary<PropertyInfo, ColumnMetadata> Columns { get; init; }

    public TableMetadata(string tableName, IReadOnlyDictionary<PropertyInfo, ColumnMetadata> columns)
    {
        TableName = tableName;
        Columns = columns;
    }
}