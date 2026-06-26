using MiniSqlBuilder.Lib.Clauses;

namespace MiniSqlBuilder.Lib.Query;

public sealed class SqlQueryTree
{
    public SelectClause SelectClause { get; set; } = new();
    public FromClause FromClause { get; set; } = new();
}