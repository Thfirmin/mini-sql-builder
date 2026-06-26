using System.Reflection;

namespace MiniSqlBuilder.Lib.Metadata;

public sealed class ColumnMetadata
{
    public PropertyInfo Property { get; init; }
    public Type PropertyType { get; init; }
    public string PropertyName { get; init; }
    public string ColumnName { get; init; }

    public ColumnMetadata(PropertyInfo property, string columnName)
    {
        Property = property;
        PropertyType = property.PropertyType;
        PropertyName = property.Name;
        ColumnName = columnName;
    }
}