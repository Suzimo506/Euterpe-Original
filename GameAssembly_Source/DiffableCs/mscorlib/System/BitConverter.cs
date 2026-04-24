namespace System;

public static class BitConverter
{
	public static readonly bool IsLittleEndian; //Field offset: 0x6AE50

	private static BitConverter() { }

	private static bool AmILittleEndian() { }

	public static long DoubleToInt64Bits(double value) { }

	public static Byte[] GetBytes(char value) { }

	public static Byte[] GetBytes(short value) { }

	public static Byte[] GetBytes(int value) { }

	public static Byte[] GetBytes(long value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Byte[] GetBytes(ushort value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Byte[] GetBytes(uint value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Byte[] GetBytes(ulong value) { }

	public static Byte[] GetBytes(float value) { }

	public static Byte[] GetBytes(double value) { }

	public static Byte[] GetBytes(bool value) { }

	private static char GetHexValue(int i) { }

	public static double Int64BitsToDouble(long value) { }

	public static short ToInt16(Byte[] value, int startIndex) { }

	public static int ToInt32(Byte[] value, int startIndex) { }

	public static long ToInt64(Byte[] value, int startIndex) { }

	public static float ToSingle(Byte[] value, int startIndex) { }

	public static string ToString(Byte[] value, int startIndex, int length) { }

	public static string ToString(Byte[] value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static ushort ToUInt16(Byte[] value, int startIndex) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static uint ToUInt32(Byte[] value, int startIndex) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static ulong ToUInt64(Byte[] value, int startIndex) { }

}

