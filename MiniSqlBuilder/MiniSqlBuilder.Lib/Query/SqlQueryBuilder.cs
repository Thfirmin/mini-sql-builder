using MiniSqlBuilder.Lib.Cache;

namespace MiniSqlBuilder.Lib.Query;

public sealed class SqlQueryBuilder
{
    private readonly List<string> _selectColumns = [];


    public SqlQueryBuilder Select<T>()
    {
        var tableMetadata = MetadataCache<T>.Metadata;
        _selectColumns.AddRange(tableMetadata.Columns.Select(c => $"{c.Value.ColumnName} AS {c.Value.Property.Name}"));
        return this;
    }
}