namespace Sirenix.Utilities;

[Extension]
public static class UnityExtensions
{
	private static readonly ValueGetter<Object, IntPtr> UnityObjectCachedPtrFieldGetter; //Field offset: 0x6B5DC

	private static UnityExtensions() { }

	[Extension]
	public static bool SafeIsUnityNull(object obj) { }

}

