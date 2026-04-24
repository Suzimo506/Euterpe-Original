namespace Newtonsoft.Json.Linq;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
{
	private readonly List<JToken> _values; //Field offset: 0x58

	protected virtual IList<JToken> ChildrenTokens
	{
		 get { } //Length: 5
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual JToken Item
	{
		 get { } //Length: 268
		 set { } //Length: 284
	}

	public override JToken Item
	{
		 get { } //Length: 17
		 set { } //Length: 17
	}

	public virtual JTokenType Type
	{
		 get { } //Length: 6
	}

	public JArray() { }

	public JArray(JArray other) { }

	public JArray(object content) { }

	public override void Add(JToken item) { }

	public override void Clear() { }

	internal virtual JToken CloneToken() { }

	public override bool Contains(JToken item) { }

	public override void CopyTo(JToken[] array, int arrayIndex) { }

	protected virtual IList<JToken> get_ChildrenTokens() { }

	public override bool get_IsReadOnly() { }

	public override JToken get_Item(int index) { }

	public virtual JToken get_Item(object key) { }

	public virtual JTokenType get_Type() { }

	public override IEnumerator<JToken> GetEnumerator() { }

	public override int IndexOf(JToken item) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal virtual int IndexOfItem(JToken item) { }

	public override void Insert(int index, JToken item) { }

	public static JArray Load(JsonReader reader, JsonLoadSettings settings) { }

	public static JArray Parse(string json, JsonLoadSettings settings) { }

	public static JArray Parse(string json) { }

	public override bool Remove(JToken item) { }

	public override void RemoveAt(int index) { }

	public virtual void set_Item(object key, JToken value) { }

	public override void set_Item(int index, JToken value) { }

	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

}

