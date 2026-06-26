using MiniSqlBuilder.Lib.Metadata;

namespace MiniSqlBuilder.Lib.Cache;

public sealed class MetadataCache<T>
{
    public static readonly TableMetadata Metadata;

    static MetadataCache()
    {
        Metadata = MetadataBuilder.Build<T>();
    }
}