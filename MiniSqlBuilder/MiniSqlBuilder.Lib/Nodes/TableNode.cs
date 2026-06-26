using MiniSqlBuilder.Lib.Cache;
using MiniSqlBuilder.Lib.Metadata;

namespace MiniSqlBuilder.Lib.Nodes;

public sealed class TableNode<T>
{
    public TableMetadata TableMetadata { get; set; }
    public string TableAlias { get; set; }

    public TableNode(string? tableAlias = null)
    {
        var tableMetadata = MetadataCache<T>.Metadata ?? throw new InvalidOperationException($"Table metadata not found for type {typeof(T).Name}");
        TableMetadata = tableMetadata;
        TableAlias = tableAlias ?? tableMetadata.TableName;
    }
}