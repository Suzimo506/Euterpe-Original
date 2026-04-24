namespace Unity.Collections.LowLevel.Unsafe;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
public static class UnsafeUtility
{
	private struct AlignOfHelper
	{
		public byte dummy; //Field offset: 0x0
		public T data; //Field offset: 0x0

	}


	public static Void* AddressOf(ref T output) { }

	public static int AlignOf() { }

	public static int EnumToInt(T enumValue) { }

	[ThreadSafe]
	public static void Free(Void* memory, Allocator allocator) { }

	internal static string GetReasonForArrayNonBlittable(Array arr) { }

	internal static string GetReasonForGenericListNonBlittable() { }

	private static string GetReasonForTypeNonBlittableImpl(Type t, string name) { }

	private static void InternalEnumToInt(ref T enumValue, ref int intValue) { }

	internal static bool IsArrayBlittable(Array arr) { }

	[ThreadSafe]
	public static bool IsBlittable(Type type) { }

	public static bool IsBlittable() { }

	private static bool IsBlittableValueType(Type t) { }

	internal static bool IsGenericListBlittable() { }

	[ThreadSafe]
	public static Void* Malloc(long size, int alignment, Allocator allocator) { }

	public static void MemClear(Void* destination, long size) { }

	[ThreadSafe]
	public static int MemCmp(Void* ptr1, Void* ptr2, long size) { }

	[ThreadSafe]
	public static void MemCpy(Void* destination, Void* source, long size) { }

	[ThreadSafe]
	public static void MemMove(Void* destination, Void* source, long size) { }

	[ThreadSafe]
	public static void MemSet(Void* destination, byte value, long size) { }

	public static T ReadArrayElement(Void* source, int index) { }

	[ThreadSafe]
	public static int SizeOf(Type type) { }

	public static int SizeOf() { }

	public static void WriteArrayElement(Void* destination, int index, T value) { }

}

