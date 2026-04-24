namespace System.Runtime.CompilerServices;

public static class Unsafe
{

	[NonVersionable]
	public static T Add(ref T source, int elementOffset) { }

	[NonVersionable]
	public static Void* Add(Void* source, int elementOffset) { }

	[NonVersionable]
	public static T Add(ref T source, IntPtr elementOffset) { }

	[NonVersionable]
	public static T AddByteOffset(ref T source, IntPtr byteOffset) { }

	[NonVersionable]
	public static bool AreSame(ref T left, ref T right) { }

	[NonVersionable]
	public static T As(object o) { }

	[NonVersionable]
	public static TTo As(ref TFrom source) { }

	[NonVersionable]
	public static Void* AsPointer(ref T value) { }

	[NonVersionable]
	public static T AsRef(Void* source) { }

	[NonVersionable]
	public static IntPtr ByteOffset(ref T origin, ref T target) { }

	[NonVersionable]
	public static void CopyBlock(ref byte destination, ref byte source, uint byteCount) { }

	[NonVersionable]
	public static void InitBlockUnaligned(Void* startAddress, byte value, uint byteCount) { }

	[NonVersionable]
	public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount) { }

	[NonVersionable]
	public static T ReadUnaligned(ref byte source) { }

	[NonVersionable]
	public static int SizeOf() { }

	[NonVersionable]
	public static void WriteUnaligned(ref byte destination, T value) { }

}

