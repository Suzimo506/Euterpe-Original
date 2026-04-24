namespace Newtonsoft.Json.Serialization;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class JsonPropertyCollection : KeyedCollection<String, JsonProperty>
{
	private readonly Type _type; //Field offset: 0x38
	private readonly List<JsonProperty> _list; //Field offset: 0x40

	public JsonPropertyCollection(Type type) { }

	public void AddProperty(JsonProperty property) { }

	public JsonProperty GetClosestMatchProperty(string propertyName) { }

	protected virtual string GetKeyForItem(JsonProperty item) { }

	public JsonProperty GetProperty(string propertyName, StringComparison comparisonType) { }

	private bool TryGetValue(string key, out JsonProperty item) { }

}

