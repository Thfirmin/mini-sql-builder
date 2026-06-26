using MiniSqlBuilder.Lib.Nodes;

namespace MiniSqlBuilder.Lib.Clauses;

public sealed class FromClause
{
    public TableNode TableNode { get; set; }

    public FromClause(string? tableAlias = null)
    {
        TableNode = new TableNode(tableAlias);
    }
}