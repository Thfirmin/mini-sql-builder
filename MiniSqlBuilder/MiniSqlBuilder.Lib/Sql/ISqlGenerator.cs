using MiniSqlBuilder.Lib.Query;

namespace MiniSqlBuilder.Lib.Sql;

public interface ISqlGenerator
{
    static abstract string Build<T>(SqlQueryTree sqlQueryTree);
}