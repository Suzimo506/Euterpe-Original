namespace Sirenix.Serialization.Utilities;

[Extension]
internal static class UnityExtensions
{
	private static readonly ValueGetter<Object, IntPtr> UnityObjectCachedPtrFieldGetter; //Field offset: 0x2C927EC

	private static UnityExtensions() { }

	[Extension]
	public static bool SafeIsUnityNull(object obj) { }

}

