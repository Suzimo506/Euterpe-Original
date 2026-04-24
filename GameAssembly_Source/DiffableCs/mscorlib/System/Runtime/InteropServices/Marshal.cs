namespace System.Runtime.InteropServices;

public static class Marshal
{
	public static readonly int SystemMaxDBCSCharSize; //Field offset: 0x0
	public static readonly int SystemDefaultCharSize; //Field offset: 0x4

	private static Marshal() { }

	public static IntPtr AllocCoTaskMem(int cb) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static IntPtr AllocHGlobal(int cb) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static IntPtr AllocHGlobal(IntPtr cb) { }

	private static void ClearUnicode(IntPtr ptr) { }

	public static void Copy(Byte[] source, int startIndex, IntPtr destination, int length) { }

	public static void Copy(Int32[] source, int startIndex, IntPtr destination, int length) { }

	public static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length) { }

	public static void Copy(IntPtr source, Byte[] destination, int startIndex, int length) { }

	public static void Copy(IntPtr source, Char[] destination, int startIndex, int length) { }

	public static void Copy(IntPtr source, Int32[] destination, int startIndex, int length) { }

	internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length) { }

	internal static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length) { }

	public static void FreeBSTR(IntPtr ptr) { }

	public static void FreeCoTaskMem(IntPtr ptr) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void FreeHGlobal(IntPtr hglobal) { }

	public static Delegate GetDelegateForFunctionPointer(IntPtr ptr, Type t) { }

	private static Delegate GetDelegateForFunctionPointerInternal(IntPtr ptr, Type t) { }

	public static IntPtr GetFunctionPointerForDelegate(TDelegate d) { }

	public static IntPtr GetFunctionPointerForDelegate(Delegate d) { }

	private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d) { }

	public static int GetHRForException(Exception e) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static int GetLastWin32Error() { }

	public static IntPtr OffsetOf(Type t, string fieldName) { }

	public static string PtrToStringAnsi(IntPtr ptr) { }

	public static string PtrToStringUni(IntPtr ptr) { }

	public static string PtrToStringUni(IntPtr ptr, int len) { }

	[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static object PtrToStructure(IntPtr ptr, Type structureType) { }

	public static T PtrToStructure(IntPtr ptr) { }

	public static byte ReadByte(IntPtr ptr, int ofs) { }

	public static short ReadInt16(IntPtr ptr, int ofs) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static int ReadInt32(IntPtr ptr, int ofs) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static int ReadInt32(IntPtr ptr) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static long ReadInt64(IntPtr ptr) { }

	public static long ReadInt64(IntPtr ptr, int ofs) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static IntPtr ReadIntPtr(IntPtr ptr) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static int Release(IntPtr pUnk) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static int ReleaseInternal(IntPtr pUnk) { }

	public static IntPtr SecureStringToCoTaskMemUnicode(SecureString s) { }

	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s) { }

	[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static int SizeOf(object structure) { }

	public static int SizeOf(Type t) { }

	public static int SizeOf(T structure) { }

	[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld) { }

	public static void StructureToPtr(T structure, IntPtr ptr, bool fDeleteOld) { }

	public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index) { }

	public static IntPtr UnsafeAddrOfPinnedArrayElement(T[] arr, int index) { }

	public static void WriteByte(IntPtr ptr, int ofs, byte val) { }

	public static void WriteByte(IntPtr ptr, byte val) { }

	public static void WriteInt16(IntPtr ptr, int ofs, short val) { }

	public static void WriteInt32(IntPtr ptr, int val) { }

	public static void WriteInt32(IntPtr ptr, int ofs, int val) { }

	public static void WriteInt64(IntPtr ptr, int ofs, long val) { }

	public static void WriteInt64(IntPtr ptr, long val) { }

	public static void WriteIntPtr(IntPtr ptr, IntPtr val) { }

	public static void ZeroFreeGlobalAllocUnicode(IntPtr s) { }

}

