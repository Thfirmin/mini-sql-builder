using MiniSqlBuilder.Lib.Clauses;
using MiniSqlBuilder.Lib.Query;

namespace MiniSqlBuilder.Lib.Sql;

public sealed class SqlServerGenerator : ISqlGenerator
{
    public static readonly SqlServerGenerator Instance = new();

    private SqlServerGenerator() {}

    public SqlResult Generate(SqlQueryTree sqlQueryTree)
    {
        if (sqlQueryTree.FromClause.TableMetadata is null)
            throw new InvalidOperationException("From clause is not set");

        var sql =
		GenerateSelectClause(sqlQueryTree.SelectClause, sqlQueryTree.FromClause.TableAlias)
        + " "
        + GenerateFromClause(sqlQueryTree.FromClause);
        return new SqlResult(sql, new SqlParameters());
    }

    private static string GenerateSelectClause(SelectClause selectClause, string tableAlias)
    {
        var sql = "SELECT ";
        sql += string.Join(", ", selectClause.Columns.Select(c => $"[{tableAlias}].[{c.ColumnName}] AS [{c.PropertyName}]"));
        return sql;
    }

    private static string GenerateFromClause(FromClause fromClause)
    {
        if (fromClause.TableMetadata is null)
            throw new InvalidOperationException("From clause is not set");

        var sql = "FROM ";
        sql += $"[{fromClause.TableMetadata.TableName}]";
        if (!string.IsNullOrWhiteSpace(fromClause.TableAlias) && fromClause.TableAlias != fromClause.TableMetadata.TableName)
            sql += $" AS [{fromClause.TableAlias}]";

        return sql;
    }
}