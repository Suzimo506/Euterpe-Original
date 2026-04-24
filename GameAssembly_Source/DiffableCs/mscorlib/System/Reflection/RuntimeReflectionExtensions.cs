namespace System.Reflection;

[Extension]
public static class RuntimeReflectionExtensions
{

	private static void CheckAndThrow(Type t) { }

	[Extension]
	public static MethodInfo GetRuntimeMethod(Type type, string name, Type[] parameters) { }

	[Extension]
	public static PropertyInfo GetRuntimeProperty(Type type, string name) { }

}

