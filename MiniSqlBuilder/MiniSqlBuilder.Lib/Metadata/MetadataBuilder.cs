using System.Reflection;
using MiniSqlBuilder.Lib.Attributes;

namespace MiniSqlBuilder.Lib.Metadata;

public static class MetadataBuilder
{
    public static TableMetadata Build<T>()
    {
        var type = typeof(T);
        if (type.GetCustomAttribute<MsbTableAttribute>() is not MsbTableAttribute tableAttribute)
            throw new InvalidOperationException("Type does not have a MsbTableAttribute");

        var columns = type.GetProperties().Select(BuildColumnMetadata);
        return new TableMetadata(tableAttribute.TableName, columns.ToDictionary(c => c.Property, c => c));
    }

    private static ColumnMetadata BuildColumnMetadata(PropertyInfo property)
    {
        if (property.GetCustomAttribute<MsbColumnAttribute>() is not MsbColumnAttribute columnAttribute)
            throw new InvalidOperationException("Property does not have a MsbColumnAttribute");

        return new ColumnMetadata(property, columnAttribute.ColumnName);
    }
}