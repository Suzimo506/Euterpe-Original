namespace Sirenix.Utilities;

[Extension]
public static class FieldInfoExtensions
{

	[Extension]
	public static FieldInfo DeAliasField(FieldInfo fieldInfo, bool throwOnNotAliased = false) { }

	[Extension]
	public static bool IsAliasField(FieldInfo fieldInfo) { }

}

