using MiniSqlBuilder.Lib.Metadata;

namespace MiniSqlBuilder.Lib.Clauses;

public sealed class SelectClause
{
    public IList<ColumnMetadata> Columns { get; } = [];

    public SelectClause() {}

    public SelectClause(IEnumerable<ColumnMetadata> columns)
    {
        Columns = columns.ToList();
    }
}