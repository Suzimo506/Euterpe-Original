namespace Sirenix.Utilities.Unsafe;

public static class UnsafeUtilities
{

	public static void MemoryCopy(object from, object to, int byteCount, int fromByteOffset, int toByteOffset) { }

	public static string StringFromBytes(Byte[] buffer, int charLength, bool needs16BitSupport) { }

	public static int StringToBytes(Byte[] buffer, string value, bool needs16BitSupport) { }

	public static T[] StructArrayFromBytes(Byte[] bytes, int byteLength) { }

	public static T[] StructArrayFromBytes(Byte[] bytes, int byteLength, int byteOffset) { }

	public static Byte[] StructArrayToBytes(T[] array) { }

	public static Byte[] StructArrayToBytes(T[] array, ref Byte[] bytes, int byteOffset) { }

}

