namespace Newtonsoft.Json.Serialization;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class JsonFormatterConverter : IFormatterConverter
{
	private readonly JsonSerializerInternalReader _reader; //Field offset: 0x10
	private readonly JsonISerializableContract _contract; //Field offset: 0x18
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly JsonProperty _member; //Field offset: 0x20

	public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member) { }

	public override object Convert(object value, Type type) { }

	private T GetTokenValue(object value) { }

	public override bool ToBoolean(object value) { }

	public override int ToInt32(object value) { }

	public override long ToInt64(object value) { }

	public override float ToSingle(object value) { }

	public override string ToString(object value) { }

}

