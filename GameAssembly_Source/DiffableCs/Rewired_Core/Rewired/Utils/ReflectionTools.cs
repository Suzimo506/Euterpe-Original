namespace Rewired.Utils;

[CustomClassObfuscation]
[CustomObfuscation]
public static class ReflectionTools
{
	[Flags]
	internal enum BindingFlags
	{
		IgnoreCase = 1,
		DeclaredOnly = 2,
		Instance = 4,
		Static = 8,
		Public = 16,
		NonPublic = 32,
		FlattenHierarchy = 64,
	}


	private static Type aqrAETCZYYxnhXvBRaLICipspMbZA(string unnamed_param_0, bool unnamed_param_1, bool unnamed_param_2 = false) { }

	public static TRet CallPrivateMethod(T obj, string name, Object[] param) { }

	public static bool DoesTypeImplement(Type type, Type baseOrInterfaceType) { }

	public static T GetAttribute(Type type, bool inherit) { }

	public static IEnumerable<FieldInfo> GetFields(Type type, BindingFlags bindingFlags) { }

	public static IEnumerable<FieldInfo> GetFields(Type type) { }

	public static Type[] GetGenericArguments(Type type) { }

	public static MethodInfo GetMethodInfo(Delegate delegate) { }

	public static IEnumerable<MethodInfo> GetMethods(Type type, BindingFlags bindingFlags) { }

	public static IEnumerable<MethodInfo> GetMethods(Type type) { }

	public static TRet GetPrivateField(T obj, string name) { }

	public static TRet GetPrivateProperty(T obj, string name) { }

	public static IEnumerable<PropertyInfo> GetProperties(Type type) { }

	public static IEnumerable<PropertyInfo> GetProperties(Type type, BindingFlags bindingFlags) { }

	internal static Type GetTypeInAssembly(string classPath, string assemblyName, bool ignoreCase = false) { }

	internal static Type GetTypeInUnityBuildAssembly(string classPath, bool ignoreCase = false) { }

	internal static Type GetTypeInUnityEditorAssembly(string classPath, bool ignoreCase = false) { }

	public static Type GetUnderlyingEnumType(Type enumType) { }

	public static bool IsArray(Type type) { }

	internal static bool IsAssemblyLoaded(string assemblyName, bool useShortName, bool ignoreCase) { }

	public static bool IsClass(Type type) { }

	public static bool IsDefined(Type type, Type attributeType, bool inherit) { }

	public static bool IsEnum(Type type) { }

	public static bool IsGenericType(Type type) { }

	public static bool IsPrimitive(Type type) { }

	public static bool IsValueType(Type type) { }

	public static void SetPrivateField(T obj, string name, object value) { }

	public static void SetPrivateProperty(T obj, string name, object value) { }

}

