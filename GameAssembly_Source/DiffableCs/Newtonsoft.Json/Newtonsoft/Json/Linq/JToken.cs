namespace Newtonsoft.Json.Linq;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class JToken : IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable, IDynamicMetaObjectProvider
{
	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private class LineInfoAnnotation
	{
		internal readonly int LineNumber; //Field offset: 0x10
		internal readonly int LinePosition; //Field offset: 0x14

		public LineInfoAnnotation(int lineNumber, int linePosition) { }

	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static JTokenEqualityComparer _equalityComparer; //Field offset: 0x0
	private static readonly JTokenType[] BooleanTypes; //Field offset: 0x8
	private static readonly JTokenType[] NumberTypes; //Field offset: 0x10
	private static readonly JTokenType[] BigIntegerTypes; //Field offset: 0x18
	private static readonly JTokenType[] StringTypes; //Field offset: 0x20
	private static readonly JTokenType[] GuidTypes; //Field offset: 0x28
	private static readonly JTokenType[] TimeSpanTypes; //Field offset: 0x30
	private static readonly JTokenType[] UriTypes; //Field offset: 0x38
	private static readonly JTokenType[] CharTypes; //Field offset: 0x40
	private static readonly JTokenType[] DateTimeTypes; //Field offset: 0x48
	private static readonly JTokenType[] BytesTypes; //Field offset: 0x50
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private JContainer _parent; //Field offset: 0x10
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private JToken _previous; //Field offset: 0x18
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private JToken _next; //Field offset: 0x20
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private object _annotations; //Field offset: 0x28

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override JToken First
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 158
	}

	public abstract bool HasValues
	{
		 get { } //Length: 0
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override JToken Item
	{
		 get { } //Length: 158
		 set { } //Length: 158
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override JToken Last
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 158
	}

	private override int Newtonsoft.Json.IJsonLineInfo.LineNumber
	{
		private get { } //Length: 71
	}

	private override int Newtonsoft.Json.IJsonLineInfo.LinePosition
	{
		private get { } //Length: 71
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public internal JToken Next
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 5
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal set { } //Length: 12
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public internal JContainer Parent
	{
		[DebuggerStepThrough]
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 5
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal set { } //Length: 12
	}

	public string Path
	{
		 get { } //Length: 662
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public internal JToken Previous
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 5
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal set { } //Length: 12
	}

	public JToken Root
	{
		 get { } //Length: 38
	}

	public abstract JTokenType Type
	{
		 get { } //Length: 0
	}

	private static JToken() { }

	internal JToken() { }

	public void AddAnnotation(object annotation) { }

	public T Annotation() { }

	public override JEnumerable<JToken> Children() { }

	internal abstract JToken CloneToken() { }

	public JsonReader CreateReader() { }

	public JToken DeepClone() { }

	private static JValue EnsureValue(JToken value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override JToken get_First() { }

	public abstract bool get_HasValues() { }

	public override JToken get_Item(object key) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override JToken get_Last() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public JToken get_Next() { }

	[DebuggerStepThrough]
	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public JContainer get_Parent() { }

	public string get_Path() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public JToken get_Previous() { }

	public JToken get_Root() { }

	public abstract JTokenType get_Type() { }

	protected override DynamicMetaObject GetMetaObject(Expression parameter) { }

	private static string GetType(JToken token) { }

	private override int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	private override int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	private override bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	public static DateTime op_Explicit(JToken value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Nullable<Int64> op_Explicit(JToken value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Nullable<Single> op_Explicit(JToken value) { }

	public static decimal op_Explicit(JToken value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Nullable<UInt32> op_Explicit(JToken value) { }

	public static double op_Explicit(JToken value) { }

	public static float op_Explicit(JToken value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Nullable<Guid> op_Explicit(JToken value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static uint op_Explicit(JToken value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static ulong op_Explicit(JToken value) { }

	public static Guid op_Explicit(JToken value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Nullable<SByte> op_Explicit(JToken value) { }

	public static TimeSpan op_Explicit(JToken value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Nullable<TimeSpan> op_Explicit(JToken value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Uri op_Explicit(JToken value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static string op_Explicit(JToken value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Nullable<UInt16> op_Explicit(JToken value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Nullable<UInt64> op_Explicit(JToken value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Nullable<Int32> op_Explicit(JToken value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Nullable<Int16> op_Explicit(JToken value) { }

	public static bool op_Explicit(JToken value) { }

	public static DateTimeOffset op_Explicit(JToken value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Nullable<Boolean> op_Explicit(JToken value) { }

	public static long op_Explicit(JToken value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Nullable<DateTime> op_Explicit(JToken value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Nullable<DateTimeOffset> op_Explicit(JToken value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Nullable<Decimal> op_Explicit(JToken value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Nullable<Double> op_Explicit(JToken value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Nullable<Byte> op_Explicit(JToken value) { }

	public static int op_Explicit(JToken value) { }

	public static short op_Explicit(JToken value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static ushort op_Explicit(JToken value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static char op_Explicit(JToken value) { }

	public static byte op_Explicit(JToken value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static sbyte op_Explicit(JToken value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Nullable<Char> op_Explicit(JToken value) { }

	public static JToken op_Implicit(decimal value) { }

	public static JToken op_Implicit(int value) { }

	public static JToken op_Implicit(string value) { }

	public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings) { }

	public static JToken ReadFrom(JsonReader reader) { }

	public void Remove() { }

	public void Replace(JToken value) { }

	public override void set_Item(object key, JToken value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal void set_Next(JToken value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal void set_Parent(JContainer value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal void set_Previous(JToken value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings) { }

	internal void SetLineInfo(int lineNumber, int linePosition) { }

	private override IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) { }

	private override object System.ICloneable.Clone() { }

	private static BigInteger ToBigInteger(JToken value) { }

	private static Nullable<BigInteger> ToBigIntegerNullable(JToken value) { }

	public T ToObject() { }

	public object ToObject(Type objectType) { }

	public T ToObject(JsonSerializer jsonSerializer) { }

	public object ToObject(Type objectType, JsonSerializer jsonSerializer) { }

	public virtual string ToString() { }

	public string ToString(Formatting formatting, JsonConverter[] converters) { }

	private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable) { }

	public abstract void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

}

