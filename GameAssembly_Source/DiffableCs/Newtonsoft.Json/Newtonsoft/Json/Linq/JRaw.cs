namespace Newtonsoft.Json.Linq;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class JRaw : JValue
{

	public JRaw(JRaw other) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public JRaw(object rawJson) { }

	internal virtual JToken CloneToken() { }

	public static JRaw Create(JsonReader reader) { }

}

