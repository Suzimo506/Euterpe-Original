namespace Sirenix.Utilities;

[Extension]
public static class PropertyInfoExtensions
{

	[Extension]
	public static PropertyInfo DeAliasProperty(PropertyInfo propertyInfo, bool throwOnNotAliased = false) { }

	[Extension]
	public static bool IsAliasProperty(PropertyInfo propertyInfo) { }

	[Extension]
	public static bool IsAutoProperty(PropertyInfo propInfo, bool allowVirtual = false) { }

}

