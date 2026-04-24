namespace Sirenix.Serialization.Utilities;

[Extension]
internal static class PropertyInfoExtensions
{

	[Extension]
	public static PropertyInfo DeAliasProperty(PropertyInfo propertyInfo, bool throwOnNotAliased = false) { }

	[Extension]
	public static bool IsAliasProperty(PropertyInfo propertyInfo) { }

	[Extension]
	public static bool IsAutoProperty(PropertyInfo propInfo, bool allowVirtual = false) { }

}

