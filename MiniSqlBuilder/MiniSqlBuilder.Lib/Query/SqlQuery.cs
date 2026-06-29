namespace MiniSqlBuilder.Lib.Query;

public static class SqlQuery
{
	public static SqlQueryBuilder<T> From<T>(string? tableAlias = null)
	{
		return new SqlQueryBuilder<T>(tableAlias);
	}
}