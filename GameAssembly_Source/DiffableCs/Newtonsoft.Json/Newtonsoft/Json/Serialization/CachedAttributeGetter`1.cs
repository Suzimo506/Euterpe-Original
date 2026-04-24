namespace Newtonsoft.Json.Serialization;

internal static class CachedAttributeGetter
{
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static readonly ThreadSafeStore<Object, T> TypeAttributeCache; //Field offset: 0x0

	private static CachedAttributeGetter`1() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static T GetAttribute(object type) { }

}

