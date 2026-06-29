using MiniSqlBuilder.Lib.Clauses;

namespace MiniSqlBuilder.Lib.Query;

public sealed class SqlQueryTree
{
    public FromClause FromClause { get; set; } = new();
    public SelectClause SelectClause { get; set; } = new();
}