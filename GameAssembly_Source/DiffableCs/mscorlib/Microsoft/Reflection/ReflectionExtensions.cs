namespace Microsoft.Reflection;

[Extension]
internal static class ReflectionExtensions
{

	[Extension]
	public static Assembly Assembly(Type type) { }

	[Extension]
	public static Type BaseType(Type type) { }

	[Extension]
	public static TypeCode GetTypeCode(Type type) { }

	[Extension]
	public static bool IsAbstract(Type type) { }

	[Extension]
	public static bool IsEnum(Type type) { }

	[Extension]
	public static bool IsSealed(Type type) { }

	[Extension]
	public static bool ReflectionOnly(Assembly assm) { }

}

