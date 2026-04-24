namespace Newtonsoft.Json;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class JsonReader : IDisposable
{
	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private enum State
	{
		Start = 0,
		Complete = 1,
		Property = 2,
		ObjectStart = 3,
		Object = 4,
		ArrayStart = 5,
		Array = 6,
		Closed = 7,
		PostValue = 8,
		ConstructorStart = 9,
		Constructor = 10,
		Error = 11,
		Finished = 12,
	}

	private JsonToken _tokenType; //Field offset: 0x10
	private object _value; //Field offset: 0x18
	internal char _quoteChar; //Field offset: 0x20
	internal State _currentState; //Field offset: 0x24
	private JsonPosition _currentPosition; //Field offset: 0x28
	private CultureInfo _culture; //Field offset: 0x40
	private DateTimeZoneHandling _dateTimeZoneHandling; //Field offset: 0x48
	private Nullable<Int32> _maxDepth; //Field offset: 0x4C
	private bool _hasExceededMaxDepth; //Field offset: 0x54
	internal DateParseHandling _dateParseHandling; //Field offset: 0x58
	internal FloatParseHandling _floatParseHandling; //Field offset: 0x5C
	private string _dateFormatString; //Field offset: 0x60
	private List<JsonPosition> _stack; //Field offset: 0x68
	[CompilerGenerated]
	private bool <CloseInput>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private bool <SupportMultipleContent>k__BackingField; //Field offset: 0x71

	public bool CloseInput
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public CultureInfo Culture
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 92
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 set { } //Length: 12
	}

	protected State CurrentState
	{
		 get { } //Length: 4
	}

	public string DateFormatString
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public DateParseHandling DateParseHandling
	{
		 get { } //Length: 4
		 set { } //Length: 109
	}

	public DateTimeZoneHandling DateTimeZoneHandling
	{
		 get { } //Length: 4
		 set { } //Length: 109
	}

	public override int Depth
	{
		 get { } //Length: 111
	}

	public FloatParseHandling FloatParseHandling
	{
		 get { } //Length: 4
		 set { } //Length: 109
	}

	public Nullable<Int32> MaxDepth
	{
		 get { } //Length: 5
		 set { } //Length: 129
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override string Path
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 248
	}

	public bool SupportMultipleContent
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override JsonToken TokenType
	{
		 get { } //Length: 4
	}

	public override object Value
	{
		 get { } //Length: 5
	}

	public override Type ValueType
	{
		 get { } //Length: 19
	}

	protected JsonReader() { }

	public override void Close() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal JsonReaderException CreateUnexpectedEndException() { }

	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	public bool get_CloseInput() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public CultureInfo get_Culture() { }

	protected State get_CurrentState() { }

	public string get_DateFormatString() { }

	public DateParseHandling get_DateParseHandling() { }

	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	public override int get_Depth() { }

	public FloatParseHandling get_FloatParseHandling() { }

	public Nullable<Int32> get_MaxDepth() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override string get_Path() { }

	[CompilerGenerated]
	public bool get_SupportMultipleContent() { }

	public override JsonToken get_TokenType() { }

	public override object get_Value() { }

	public override Type get_ValueType() { }

	private JsonToken GetContentToken() { }

	internal JsonPosition GetPosition(int depth) { }

	private JsonContainerType GetTypeForCloseToken(JsonToken token) { }

	internal bool MoveToContent() { }

	private JsonContainerType Peek() { }

	private JsonContainerType Pop() { }

	private void Push(JsonContainerType value) { }

	public abstract bool Read() { }

	internal void ReadAndAssert() { }

	internal bool ReadAndMoveToContent() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool ReadArrayElementIntoByteArrayReportDone(List<Byte> buffer) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal Byte[] ReadArrayIntoByteArray() { }

	public override Nullable<Boolean> ReadAsBoolean() { }

	public override Byte[] ReadAsBytes() { }

	public override Nullable<DateTime> ReadAsDateTime() { }

	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	public override Nullable<Decimal> ReadAsDecimal() { }

	public override Nullable<Double> ReadAsDouble() { }

	public override Nullable<Int32> ReadAsInt32() { }

	public override string ReadAsString() { }

	internal Nullable<Boolean> ReadBooleanString(string s) { }

	internal Nullable<DateTimeOffset> ReadDateTimeOffsetString(string s) { }

	internal Nullable<DateTime> ReadDateTimeString(string s) { }

	internal Nullable<Decimal> ReadDecimalString(string s) { }

	internal Nullable<Double> ReadDoubleString(string s) { }

	internal void ReaderReadAndAssert() { }

	internal bool ReadForType(JsonContract contract, bool hasConverter) { }

	internal void ReadForTypeAndAssert(JsonContract contract, bool hasConverter) { }

	internal Nullable<Int32> ReadInt32String(string s) { }

	internal void ReadIntoWrappedTypeObject() { }

	[CompilerGenerated]
	public void set_CloseInput(bool value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void set_Culture(CultureInfo value) { }

	public void set_DateFormatString(string value) { }

	public void set_DateParseHandling(DateParseHandling value) { }

	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	public void set_FloatParseHandling(FloatParseHandling value) { }

	public void set_MaxDepth(Nullable<Int32> value) { }

	[CompilerGenerated]
	public void set_SupportMultipleContent(bool value) { }

	private void SetFinished() { }

	internal void SetPostValueState(bool updateIndex) { }

	protected void SetStateBasedOnCurrent() { }

	protected void SetToken(JsonToken newToken) { }

	protected void SetToken(JsonToken newToken, object value, bool updateIndex) { }

	protected void SetToken(JsonToken newToken, object value) { }

	public void Skip() { }

	private override void System.IDisposable.Dispose() { }

	private void UpdateScopeWithFinishedValue() { }

	private void ValidateEnd(JsonToken endToken) { }

}

