using MiniSqlBuilder.Lib.Cache;
using MiniSqlBuilder.Lib.Clauses;
using MiniSqlBuilder.Lib.Sql;

namespace MiniSqlBuilder.Lib.Query;

public sealed class SqlQueryBuilder<T>
{
    private readonly SqlQueryTree _tree = new();

    public SqlQueryBuilder(string? tableAlias = null)
    {
        _tree.FromClause = new FromClause(MetadataCache<T>.Metadata, tableAlias);
    }


    public SqlQueryBuilder<T> Select()
    {
        if (_tree.FromClause.TableMetadata is null)
            throw new InvalidOperationException("From clause is not set");

        foreach (var column in _tree.FromClause.TableMetadata.Columns)
        {
            _tree.SelectClause.Columns.Add(column.Value);
        }
        return this;
    }

    public SqlResult Build(ISqlGenerator generator)
    {
        return generator.Generate(_tree);
    }

    // Future: Add other generators here
}