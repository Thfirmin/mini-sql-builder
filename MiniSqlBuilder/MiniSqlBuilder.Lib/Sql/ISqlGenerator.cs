using MiniSqlBuilder.Lib.Query;

namespace MiniSqlBuilder.Lib.Sql;

public interface ISqlGenerator
{
    SqlResult Generate(SqlQueryTree sqlQueryTree);
}