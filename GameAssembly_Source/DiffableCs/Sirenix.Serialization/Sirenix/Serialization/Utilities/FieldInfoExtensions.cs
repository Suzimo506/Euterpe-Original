namespace Sirenix.Serialization.Utilities;

[Extension]
internal static class FieldInfoExtensions
{

	[Extension]
	public static FieldInfo DeAliasField(FieldInfo fieldInfo, bool throwOnNotAliased = false) { }

	[Extension]
	public static bool IsAliasField(FieldInfo fieldInfo) { }

}

