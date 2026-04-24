namespace Newtonsoft.Json.Utilities;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal static class BufferUtils
{

	public static Char[] EnsureBufferSize(IArrayPool<Char> bufferPool, int size, Char[] buffer) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Char[] RentBuffer(IArrayPool<Char> bufferPool, int minSize) { }

	public static void ReturnBuffer(IArrayPool<Char> bufferPool, Char[] buffer) { }

}

