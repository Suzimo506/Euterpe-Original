namespace Newtonsoft.Json.Linq;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>, IConvertible
{
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private class JValueDynamicProxy : DynamicProxy<JValue>
	{

		public JValueDynamicProxy() { }

	}

	private JTokenType _valueType; //Field offset: 0x30
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private object _value; //Field offset: 0x38

	public virtual bool HasValues
	{
		 get { } //Length: 3
	}

	public virtual JTokenType Type
	{
		 get { } //Length: 4
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public object Value
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 5
	}

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal JValue(object value, JTokenType type) { }

	public JValue(JValue other) { }

	public JValue(long value) { }

	public JValue(decimal value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public JValue(string value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public JValue(object value) { }

	internal virtual JToken CloneToken() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal static int Compare(JTokenType valueType, object objA, object objB) { }

	private static int CompareBigInteger(BigInteger i1, object i2) { }

	private static int CompareFloat(object objA, object objB) { }

	public override int CompareTo(JValue obj) { }

	public static JValue CreateComment(string value) { }

	public static JValue CreateNull() { }

	public static JValue CreateUndefined() { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(JValue other) { }

	public virtual bool get_HasValues() { }

	public virtual JTokenType get_Type() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public object get_Value() { }

	public virtual int GetHashCode() { }

	protected virtual DynamicMetaObject GetMetaObject(Expression parameter) { }

	private static JTokenType GetStringValueType(Nullable<JTokenType> current) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static JTokenType GetValueType(Nullable<JTokenType> current, object value) { }

	private override int System.IComparable.CompareTo(object obj) { }

	private override TypeCode System.IConvertible.GetTypeCode() { }

	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	private override object System.IConvertible.ToType(Type conversionType, IFormatProvider provider) { }

	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

	public override string ToString(IFormatProvider formatProvider) { }

	public virtual string ToString() { }

	private static bool ValuesEquals(JValue v1, JValue v2) { }

	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

}

