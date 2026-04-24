namespace Newtonsoft.Json;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class JsonTextReader : JsonReader, IJsonLineInfo
{
	private readonly bool _safeAsync; //Field offset: 0x78
	private readonly TextReader _reader; //Field offset: 0x80
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Char[] _chars; //Field offset: 0x88
	private int _charsUsed; //Field offset: 0x90
	private int _charPos; //Field offset: 0x94
	private int _lineStartPos; //Field offset: 0x98
	private int _lineNumber; //Field offset: 0x9C
	private bool _isEndOfFile; //Field offset: 0xA0
	private StringBuffer _stringBuffer; //Field offset: 0xA8
	private StringReference _stringReference; //Field offset: 0xB8
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IArrayPool<Char> _arrayPool; //Field offset: 0xC8
	[CompilerGenerated]
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private JsonNameTable <PropertyNameTable>k__BackingField; //Field offset: 0xD0

	public override int LineNumber
	{
		 get { } //Length: 70
	}

	public override int LinePosition
	{
		 get { } //Length: 13
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public JsonNameTable PropertyNameTable
	{
		[CompilerGenerated]
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 8
		[CompilerGenerated]
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 set { } //Length: 15
	}

	public JsonTextReader(TextReader reader) { }

	private static object BigIntegerParse(string number, CultureInfo culture) { }

	private static void BlockCopyChars(Char[] src, int srcOffset, Char[] dst, int dstOffset, int count) { }

	private void ClearRecentString() { }

	public virtual void Close() { }

	private char ConvertUnicode(bool enoughChars) { }

	private JsonReaderException CreateUnexpectedCharacterException(char c) { }

	private void EatWhitespace() { }

	private void EndComment(bool setToken, int initialPosition, int endPosition) { }

	private void EnsureBuffer() { }

	private void EnsureBufferNotEmpty() { }

	private bool EnsureChars(int relativePosition, bool append) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private object FinishReadQuotedNumber(ReadType readType) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private object FinishReadQuotedStringValue(ReadType readType) { }

	private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition) { }

	public override int get_LineNumber() { }

	public override int get_LinePosition() { }

	[CompilerGenerated]
	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public JsonNameTable get_PropertyNameTable() { }

	private void HandleNull() { }

	public override bool HasLineInfo() { }

	private bool IsSeparator(char c) { }

	private bool MatchValue(string value) { }

	private bool MatchValue(bool enoughChars, string value) { }

	private bool MatchValueWithTrailingSeparator(string value) { }

	private void OnNewLine(int pos) { }

	private void ParseComment(bool setToken) { }

	private void ParseConstructor() { }

	private void ParseFalse() { }

	private void ParseNull() { }

	private void ParseNumber(ReadType readType) { }

	private object ParseNumberNaN(ReadType readType) { }

	private object ParseNumberNaN(ReadType readType, bool matched) { }

	private object ParseNumberNegativeInfinity(ReadType readType, bool matched) { }

	private object ParseNumberNegativeInfinity(ReadType readType) { }

	private object ParseNumberPositiveInfinity(ReadType readType) { }

	private object ParseNumberPositiveInfinity(ReadType readType, bool matched) { }

	private bool ParseObject() { }

	private bool ParsePostValue(bool ignoreComments) { }

	private bool ParseProperty() { }

	private void ParseReadNumber(ReadType readType, char firstChar, int initialPosition) { }

	private void ParseReadString(char quote, ReadType readType) { }

	private void ParseString(char quote, ReadType readType) { }

	private void ParseTrue() { }

	private void ParseUndefined() { }

	private char ParseUnicode() { }

	private void ParseUnquotedProperty() { }

	private bool ParseValue() { }

	private void PrepareBufferForReadData(bool append, int charsRequired) { }

	private void ProcessCarriageReturn(bool append) { }

	private void ProcessLineFeed() { }

	private void ProcessValueComma() { }

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

	private bool ReadChars(int relativePosition, bool append) { }

	private int ReadData(bool append) { }

	private int ReadData(bool append, int charsRequired) { }

	private void ReadFinished() { }

	private bool ReadNullChar() { }

	private bool ReadNumberCharIntoBuffer(char currentChar, int charPos) { }

	private void ReadNumberIntoBuffer() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private object ReadNumberValue(ReadType readType) { }

	private void ReadStringIntoBuffer(char quote) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private object ReadStringValue(ReadType readType) { }

	private bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition) { }

	[CompilerGenerated]
	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void set_PropertyNameTable(JsonNameTable value) { }

	private void SetNewLine(bool hasNextChar) { }

	private void ShiftBufferIfNeeded() { }

	private JsonReaderException ThrowReaderError(string message, Exception ex = null) { }

	private bool ValidIdentifierChar(char value) { }

	private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition) { }

}

