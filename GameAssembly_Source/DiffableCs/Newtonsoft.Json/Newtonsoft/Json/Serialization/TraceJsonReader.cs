namespace Newtonsoft.Json.Serialization;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class TraceJsonReader : JsonReader, IJsonLineInfo
{
	private readonly JsonReader _innerReader; //Field offset: 0x78
	private readonly JsonTextWriter _textWriter; //Field offset: 0x80
	private readonly StringWriter _sw; //Field offset: 0x88

	public virtual int Depth
	{
		 get { } //Length: 39
	}

	private override int Newtonsoft.Json.IJsonLineInfo.LineNumber
	{
		private get { } //Length: 88
	}

	private override int Newtonsoft.Json.IJsonLineInfo.LinePosition
	{
		private get { } //Length: 88
	}

	public virtual string Path
	{
		 get { } //Length: 39
	}

	public virtual JsonToken TokenType
	{
		 get { } //Length: 39
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual object Value
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 39
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual Type ValueType
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 39
	}

	public TraceJsonReader(JsonReader innerReader) { }

	public virtual void Close() { }

	public virtual int get_Depth() { }

	public virtual string get_Path() { }

	public virtual JsonToken get_TokenType() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual object get_Value() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual Type get_ValueType() { }

	public string GetDeserializedJsonMessage() { }

	private override int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	private override int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	private override bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	public virtual bool Read() { }

	public virtual Nullable<Boolean> ReadAsBoolean() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual Byte[] ReadAsBytes() { }

	public virtual Nullable<DateTime> ReadAsDateTime() { }

	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	public virtual Nullable<Decimal> ReadAsDecimal() { }

	public virtual Nullable<Double> ReadAsDouble() { }

	public virtual Nullable<Int32> ReadAsInt32() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual string ReadAsString() { }

	public void WriteCurrentToken() { }

}

