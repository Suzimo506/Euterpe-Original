namespace Sirenix.Utilities;

[Extension]
public static class MemberInfoExtensions
{

	[Extension]
	public static MemberInfo DeAlias(MemberInfo memberInfo, bool throwOnNotAliased = false) { }

	[Extension]
	public static T GetAttribute(ICustomAttributeProvider member, bool inherit) { }

	[Extension]
	public static T GetAttribute(ICustomAttributeProvider member) { }

	[Extension]
	public static IEnumerable<T> GetAttributes(ICustomAttributeProvider member) { }

	[Extension]
	public static IEnumerable<T> GetAttributes(ICustomAttributeProvider member, bool inherit) { }

	[Extension]
	public static Attribute[] GetAttributes(ICustomAttributeProvider member) { }

	[Extension]
	public static Attribute[] GetAttributes(ICustomAttributeProvider member, bool inherit) { }

	[Extension]
	public static string GetNiceName(MemberInfo member) { }

	[Extension]
	public static bool IsAlias(MemberInfo memberInfo) { }

	[Extension]
	public static bool IsDefined(ICustomAttributeProvider member, bool inherit) { }

	[Extension]
	public static bool IsDefined(ICustomAttributeProvider member) { }

	[Extension]
	public static bool IsStatic(MemberInfo member) { }

	[Extension]
	public static bool SignaturesAreEqual(MemberInfo a, MemberInfo b) { }

}

