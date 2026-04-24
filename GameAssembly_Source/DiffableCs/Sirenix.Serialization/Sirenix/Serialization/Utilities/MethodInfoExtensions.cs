namespace Sirenix.Serialization.Utilities;

[Extension]
internal static class MethodInfoExtensions
{

	[Extension]
	public static MethodInfo DeAliasMethod(MethodInfo methodInfo, bool throwOnNotAliased = false) { }

	[Extension]
	public static string GetFullName(MethodBase method, string extensionMethodPrefix) { }

	[Extension]
	public static string GetFullName(MethodBase method) { }

	[Extension]
	public static string GetParamsNames(MethodBase method) { }

	[Extension]
	public static bool IsAliasMethod(MethodInfo methodInfo) { }

	[Extension]
	public static bool IsExtensionMethod(MethodBase method) { }

}

