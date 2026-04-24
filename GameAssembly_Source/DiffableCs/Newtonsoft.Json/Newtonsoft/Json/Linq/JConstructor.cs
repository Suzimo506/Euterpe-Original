namespace Newtonsoft.Json.Linq;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class JConstructor : JContainer
{
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string _name; //Field offset: 0x58
	private readonly List<JToken> _values; //Field offset: 0x60

	protected virtual IList<JToken> ChildrenTokens
	{
		 get { } //Length: 5
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual JToken Item
	{
		 get { } //Length: 268
		 set { } //Length: 284
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string Name
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 5
	}

	public virtual JTokenType Type
	{
		 get { } //Length: 6
	}

	public JConstructor(JConstructor other) { }

	public JConstructor(string name) { }

	internal virtual JToken CloneToken() { }

	protected virtual IList<JToken> get_ChildrenTokens() { }

	public virtual JToken get_Item(object key) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string get_Name() { }

	public virtual JTokenType get_Type() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal virtual int IndexOfItem(JToken item) { }

	public static JConstructor Load(JsonReader reader, JsonLoadSettings settings) { }

	public virtual void set_Item(object key, JToken value) { }

	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

}

