namespace Newtonsoft.Json.Linq;

[Extension]
[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public static class Extensions
{

	[Extension]
	internal static U Convert(T token) { }

	[Extension]
	public static U Value(IEnumerable<T> value) { }

	[Extension]
	public static U Value(IEnumerable<JToken> value) { }

}

