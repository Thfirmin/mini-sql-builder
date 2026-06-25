namespace MiniSqlBuilder.Lib.Metadata;

public sealed class TableMetadata
{
    public string TableName { get; init; }
    public IReadOnlyDictionary<string, ColumnMetadata> Columns { get; init; }
}