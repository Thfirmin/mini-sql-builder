namespace MiniSqlBuilder.Lib.Sql;

public sealed class SqlResult
{
    public string Sql { get; }
    public SqlParameters Parameters { get; }

	public SqlResult(string sql, SqlParameters parameters)
	{
		Sql = sql;
		Parameters = parameters;
	}
}

public sealed class SqlParameters
{
    public Dictionary<string, object> Parameters { get; private set; } = [];

	public SqlParameters() { }

	public SqlParameters(Dictionary<string, object> parameters)
	{
		foreach (var parameter in parameters)
		{
			Parameters.Add(GetParameterName(parameter.Key), parameter.Value);
		}
	}

	public SqlParameters Add(string name, object value)
	{
		Parameters[GetParameterName(name)] = value;
		return this;
	}

	public SqlParameters Add(Dictionary<string, object> parameters)
	{
		foreach (var parameter in parameters)
		{
			Parameters.Add(GetParameterName(parameter.Key), parameter.Value);
		}
		return this;
	}

	public object this[string name]
	{
		get => Parameters[GetParameterName(name)];
		set => Parameters[GetParameterName(name)] = value;
	}

	private string GetParameterName(string name)
	{
		string key = name.Trim().ToLower();
		if (!key.StartsWith("@"))
			key = $"@{key.Trim()}";
		return key;
	}
}