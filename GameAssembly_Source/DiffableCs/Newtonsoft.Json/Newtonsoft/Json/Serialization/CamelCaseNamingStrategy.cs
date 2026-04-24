namespace Newtonsoft.Json.Serialization;

public class CamelCaseNamingStrategy : NamingStrategy
{

	public CamelCaseNamingStrategy() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected virtual string ResolvePropertyName(string name) { }

}

