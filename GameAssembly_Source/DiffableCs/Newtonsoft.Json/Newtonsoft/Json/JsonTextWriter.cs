namespace Newtonsoft.Json;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class JsonTextWriter : JsonWriter
{
	private readonly bool _safeAsync; //Field offset: 0x60
	private readonly TextWriter _writer; //Field offset: 0x68
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Base64Encoder _base64Encoder; //Field offset: 0x70
	private char _indentChar; //Field offset: 0x78
	private int _indentation; //Field offset: 0x7C
	private char _quoteChar; //Field offset: 0x80
	private bool _quoteName; //Field offset: 0x82
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Boolean[] _charEscapeFlags; //Field offset: 0x88
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Char[] _writeBuffer; //Field offset: 0x90
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IArrayPool<Char> _arrayPool; //Field offset: 0x98
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Char[] _indentChars; //Field offset: 0xA0

	private Base64Encoder Base64Encoder
	{
		private get { } //Length: 124
	}

	public char QuoteChar
	{
		 get { } //Length: 8
	}

	public JsonTextWriter(TextWriter textWriter) { }

	public virtual void Close() { }

	private void CloseBufferAndWriter() { }

	private void EnsureWriteBuffer() { }

	private Base64Encoder get_Base64Encoder() { }

	public char get_QuoteChar() { }

	internal virtual void OnStringEscapeHandlingChanged() { }

	private int SetIndentChars() { }

	private void UpdateCharEscapeFlags() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual void WriteComment(string text) { }

	protected virtual void WriteEnd(JsonToken token) { }

	private void WriteEscapedString(string value, bool quote) { }

	protected virtual void WriteIndent() { }

	protected virtual void WriteIndentSpace() { }

	private void WriteIntegerValue(uint value, bool negative) { }

	private void WriteIntegerValue(long value) { }

	private void WriteIntegerValue(int value) { }

	private void WriteIntegerValue(ulong value, bool negative) { }

	public virtual void WriteNull() { }

	private int WriteNumberToBuffer(ulong value, bool negative) { }

	private int WriteNumberToBuffer(uint value, bool negative) { }

	public virtual void WritePropertyName(string name) { }

	public virtual void WritePropertyName(string name, bool escape) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual void WriteRaw(string json) { }

	public virtual void WriteStartArray() { }

	public virtual void WriteStartConstructor(string name) { }

	public virtual void WriteStartObject() { }

	public virtual void WriteUndefined() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual void WriteValue(Uri value) { }

	public virtual void WriteValue(TimeSpan value) { }

	public virtual void WriteValue(Guid value) { }

	public virtual void WriteValue(DateTimeOffset value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual void WriteValue(Byte[] value) { }

	public virtual void WriteValue(DateTime value) { }

	public virtual void WriteValue(decimal value) { }

	public virtual void WriteValue(byte value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual void WriteValue(sbyte value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual void WriteValue(ushort value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual void WriteValue(string value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual void WriteValue(object value) { }

	public virtual void WriteValue(int value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual void WriteValue(uint value) { }

	public virtual void WriteValue(long value) { }

	public virtual void WriteValue(char value) { }

	public virtual void WriteValue(float value) { }

	public virtual void WriteValue(double value) { }

	public virtual void WriteValue(Nullable<Double> value) { }

	public virtual void WriteValue(bool value) { }

	public virtual void WriteValue(short value) { }

	public virtual void WriteValue(Nullable<Single> value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual void WriteValue(ulong value) { }

	protected virtual void WriteValueDelimiter() { }

	private void WriteValueInternal(string value, JsonToken token) { }

	private int WriteValueToBuffer(DateTimeOffset value) { }

	private int WriteValueToBuffer(DateTime value) { }

}

