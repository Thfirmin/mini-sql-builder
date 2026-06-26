using MiniSqlBuilder.Lib.Query;

namespace MiniSqlBuilder.Lib.Sql;

public sealed class SqlGenerator : ISqlGenerator
{
    public static string Build<T>(SqlQueryTree sqlQueryTree)
    {
        return $"SELECT {sqlQueryTree.SelectClause.Columns.Join(", ")} FROM {sqlQueryTree.FromClause.TableName}";
    }
}