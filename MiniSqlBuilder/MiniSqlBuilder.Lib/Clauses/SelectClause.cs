namespace MiniSqlBuilder.Lib.Clauses;

public sealed class SelectClause
{
    public string ColumnName { get; set; }
    public string Alias { get; set; }
}