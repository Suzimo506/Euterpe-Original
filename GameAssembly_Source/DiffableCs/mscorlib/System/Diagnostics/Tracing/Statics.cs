namespace System.Diagnostics.Tracing;

internal static class Statics
{
	public static readonly TraceLoggingDataType IntPtrType; //Field offset: 0x0
	public static readonly TraceLoggingDataType UIntPtrType; //Field offset: 0x4
	public static readonly TraceLoggingDataType HexIntPtrType; //Field offset: 0x8

	private static Statics() { }

	public static void CheckName(string name) { }

	public static byte Combine(int settingValue, byte defaultValue) { }

	public static int Combine(int settingValue1, int settingValue2) { }

	public static TraceLoggingTypeInfo<DataType> CreateDefaultTypeInfo(List<Type> recursionCheck) { }

	public static Delegate CreateDelegate(Type delegateType, MethodInfo methodInfo) { }

	public static object CreateInstance(Type type, Object[] parameters) { }

	public static void EncodeTags(int tags, ref int pos, Byte[] metadata) { }

	public static Type FindEnumerableElementType(Type type) { }

	public static TraceLoggingDataType Format16(EventFieldFormat format, TraceLoggingDataType native) { }

	public static TraceLoggingDataType Format32(EventFieldFormat format, TraceLoggingDataType native) { }

	public static TraceLoggingDataType Format64(EventFieldFormat format, TraceLoggingDataType native) { }

	public static TraceLoggingDataType Format8(EventFieldFormat format, TraceLoggingDataType native) { }

	public static TraceLoggingDataType FormatPtr(EventFieldFormat format, TraceLoggingDataType native) { }

	public static AttributeType GetCustomAttribute(PropertyInfo propInfo) { }

	public static AttributeType GetCustomAttribute(Type type) { }

	public static MethodInfo GetDeclaredStaticMethod(Type declaringType, string name) { }

	public static Type[] GetGenericArguments(Type type) { }

	public static MethodInfo GetGetMethod(PropertyInfo propInfo) { }

	public static IEnumerable<PropertyInfo> GetProperties(Type type) { }

	public static TraceLoggingTypeInfo GetTypeInfoInstance(Type dataType, List<Type> recursionCheck) { }

	public static bool HasCustomAttribute(PropertyInfo propInfo, Type attributeType) { }

	public static bool IsEnum(Type type) { }

	public static bool IsGenericMatch(Type type, object openType) { }

	public static bool IsValueType(Type type) { }

	public static TraceLoggingDataType MakeDataType(TraceLoggingDataType baseType, EventFieldFormat format) { }

	public static Byte[] MetadataForString(string name, int prefixSize, int suffixSize, int additionalSize) { }

	public static bool ShouldOverrideFieldName(string fieldName) { }

}

