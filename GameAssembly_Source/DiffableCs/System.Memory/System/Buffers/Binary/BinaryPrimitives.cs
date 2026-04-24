namespace System.Buffers.Binary;

public static class BinaryPrimitives
{

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static ulong ReadUInt64LittleEndian(ReadOnlySpan<Byte> source) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static uint ReverseEndianness(uint value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static ulong ReverseEndianness(ulong value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void WriteUInt32LittleEndian(Span<Byte> destination, uint value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void WriteUInt64LittleEndian(Span<Byte> destination, ulong value) { }

}

