namespace ProtoBuf;

internal sealed class Helpers
{
	public static readonly Type[] EmptyTypes; //Field offset: 0x64F26

	private static Helpers() { }

	private Helpers() { }

	public static StringBuilder AppendLine(StringBuilder builder) { }

	public static void BlockCopy(Byte[] from, int fromIndex, Byte[] to, int toIndex, int count) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void DebugAssert(bool condition, string message) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void DebugAssert(bool condition, string message, Object[] args) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void DebugAssert(bool condition) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void DebugWriteLine(string message, object obj) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void DebugWriteLine(string message) { }

	internal static ConstructorInfo GetConstructor(Type type, Type[] parameterTypes, bool nonPublic) { }

	internal static ConstructorInfo[] GetConstructors(Type type, bool nonPublic) { }

	internal static MethodInfo GetGetMethod(PropertyInfo property, bool nonPublic, bool allowInternal) { }

	internal static MemberInfo[] GetInstanceFieldsAndProperties(Type type, bool publicOnly) { }

	internal static MethodInfo GetInstanceMethod(Type declaringType, string name) { }

	internal static MethodInfo GetInstanceMethod(Type declaringType, string name, Type[] types) { }

	internal static Type GetMemberType(MemberInfo member) { }

	internal static PropertyInfo GetProperty(Type type, string name, bool nonPublic) { }

	internal static MethodInfo GetSetMethod(PropertyInfo property, bool nonPublic, bool allowInternal) { }

	internal static MethodInfo GetStaticMethod(Type declaringType, string name) { }

	public static ProtoTypeCode GetTypeCode(Type type) { }

	internal static Type GetUnderlyingType(Type type) { }

	internal static bool IsAssignableFrom(Type target, Type type) { }

	internal static bool IsEnum(Type type) { }

	public static bool IsInfinity(float value) { }

	public static bool IsInfinity(double value) { }

	public static bool IsNullOrEmpty(string value) { }

	internal static bool IsSubclassOf(Type type, Type baseClass) { }

	internal static bool IsValueType(Type type) { }

	internal static object ParseEnum(Type type, string value) { }

	public static void Sort(Int32[] keys, Object[] values) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void TraceWriteLine(string message) { }

}

