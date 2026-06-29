// See https://aka.ms/new-console-template for more information

using MiniSqlBuilder.Lib.Query;
using MiniSqlBuilder.Lib.Sql;
using MiniSqlBuilder.Playground.Models;

var query = SqlQuery
	.From<UserModel>()
	.Select()
	.Build(SqlServerGenerator.Instance);

var query2 = SqlQuery
	.From<UserModel>("UserAlias")
	.Select()
	.Build(SqlServerGenerator.Instance);

Console.WriteLine(query.Sql);
Console.WriteLine(query2.Sql);