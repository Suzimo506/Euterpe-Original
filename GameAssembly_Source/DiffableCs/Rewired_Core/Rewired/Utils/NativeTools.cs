namespace Rewired.Utils;

[CustomClassObfuscation]
[CustomObfuscation]
internal static class NativeTools
{
	private static Byte[] jnpyAgTRgmFjUEpuESMsBhxJqbaP; //Field offset: 0x6A0FA

	public static bool CopyMemory(IntPtr source, IntPtr destination, int sourceStartIndex, int destinationStartIndex, int bytesToCopy, bool throwOnError = true) { }

	public static bool CopyMemory(Byte[] source, IntPtr destination, int sourceStartIndex, int destinationStartIndex, int bytesToCopy, bool throwOnError = true) { }

	public static bool CopyMemory(IntPtr source, Byte[] destination, int sourceStartIndex, int destinationStartIndex, int bytesToCopy, bool throwOnError = true) { }

	public static string DumpToString(IntPtr buffer, int length, string stringFormat = "x2") { }

	public static bool FillMemory(IntPtr buffer, int length, byte value, bool throwOnError = true) { }

	public static bool FillMemory(IntPtr buffer, int startIndex, int length, byte value, bool throwOnError = true) { }

	public static bool FillMemory(Byte[] buffer, int length, byte value, bool throwOnError = true) { }

	public static bool FillMemory(Byte[] buffer, int startIndex, int length, byte value, bool throwOnError = true) { }

	public static void FreeHGlobalSafe(ref IntPtr pointer) { }

	public static IntPtr OffsetIntPtr(IntPtr intPtr, int offset) { }

	public static void ZeroFillMemory(IntPtr buffer, int length) { }

}

