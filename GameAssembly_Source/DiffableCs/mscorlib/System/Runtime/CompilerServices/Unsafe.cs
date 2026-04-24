namespace System.Runtime.CompilerServices;

internal static class Unsafe
{

	public static T Add(ref T source, int elementOffset) { }

	public static T AddByteOffset(ref T source, IntPtr byteOffset) { }

	public static T As(object o) { }

	public static T AsRef(Void* source) { }

	public static IntPtr ByteOffset(ref T origin, ref T target) { }

	public static T Read(Void* source) { }

	public static int SizeOf() { }

}

