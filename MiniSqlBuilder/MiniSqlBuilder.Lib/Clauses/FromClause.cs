using MiniSqlBuilder.Lib.Metadata;

namespace MiniSqlBuilder.Lib.Clauses;

public sealed class FromClause
{
    public TableMetadata? TableMetadata { get; init; }
    public string TableAlias { get; init; } = string.Empty;

    public FromClause() {}

    public FromClause(TableMetadata tableMetadata, string? tableAlias = null)
    {
        TableMetadata = tableMetadata;
        TableAlias = tableAlias ?? tableMetadata.TableName;
    }
}