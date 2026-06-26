using MiniSqlBuilder.Lib.Cache;
using MiniSqlBuilder.Playground.Models;

namespace MiniSqlBuilder.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1EqualMetadata()
    {
        var m1 = MetadataCache<UserModel>.Metadata;
        var m2 = MetadataCache<UserModel>.Metadata;

        Assert.Equal(m1, m2);
    }

    [Fact]
    public void Test2SameMetadata()
    {
        var m1 = MetadataCache<UserModel>.Metadata;
        var m2 = MetadataCache<UserModel>.Metadata;

        Assert.Same(m1, m2);
    }

    [Fact]
    public void Test3DifferentMetadata() // Fail
    {
        var m1 = MetadataCache<UserModel>.Metadata;
        var m2 = MetadataCache<User2Model>.Metadata;

        Assert.Equal(m1, m2);
    }

    [Fact]
    public void Test4UnsameMetadata()
    {
        var m1 = MetadataCache<UserModel>.Metadata;
        var m2 = MetadataCache<User2Model>.Metadata;

        Assert.NotSame(m1, m2);
    }

    [Fact]
    public void Test5EqualTableName()
    {
        var m1 = MetadataCache<UserModel>.Metadata.TableName;
        var m2 = MetadataCache<UserModel>.Metadata.TableName;

        Assert.Equal(m1, m2);
    }

    [Fact]
    public void Test6SameTableName()
    {
        var m1 = MetadataCache<UserModel>.Metadata.TableName;
        var m2 = MetadataCache<UserModel>.Metadata.TableName;

        Assert.Same(m1, m2);
    }

    [Fact]
    public void Test7DifferentTableName()
    {
        var m1 = MetadataCache<UserModel>.Metadata.TableName;
        var m2 = MetadataCache<User2Model>.Metadata.TableName;

        Assert.Equal(m1, m2);
    }

    [Fact]
    public void Test8UnsameTableName()
    {
        var m1 = MetadataCache<UserModel>.Metadata.TableName;
        var m2 = MetadataCache<User2Model>.Metadata.TableName;

        Assert.NotSame(m1, m2);
    }

    [Fact]
    public void Test9EqualColumns()
    {
        var m1 = MetadataCache<UserModel>.Metadata.Columns;
        var m2 = MetadataCache<UserModel>.Metadata.Columns;

        Assert.Equal(m1, m2);
    }

    [Fact]
    public void Test10SameColumns()
    {
        var m1 = MetadataCache<UserModel>.Metadata.Columns;
        var m2 = MetadataCache<UserModel>.Metadata.Columns;

        Assert.Same(m1, m2);
    }

    [Fact]
    public void Test11DifferentColumns() // Fail
    {
        var m1 = MetadataCache<UserModel>.Metadata.Columns;
        var m2 = MetadataCache<User2Model>.Metadata.Columns;

        Assert.Equal(m1, m2);
    }

    [Fact]
    public void Test12UnsameColumns()
    {
        var m1 = MetadataCache<UserModel>.Metadata.Columns;
        var m2 = MetadataCache<User2Model>.Metadata.Columns;

        Assert.NotSame(m1, m2);
    }
}
