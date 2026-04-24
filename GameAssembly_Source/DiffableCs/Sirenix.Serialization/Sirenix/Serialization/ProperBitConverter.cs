namespace Sirenix.Serialization;

public static class ProperBitConverter
{
	private struct DecimalByteUnion
	{
		public byte Byte0; //Field offset: 0x0
		public decimal Value; //Field offset: 0x0
		public byte Byte1; //Field offset: 0x1
		public byte Byte2; //Field offset: 0x2
		public byte Byte3; //Field offset: 0x3
		public byte Byte4; //Field offset: 0x4
		public byte Byte5; //Field offset: 0x5
		public byte Byte6; //Field offset: 0x6
		public byte Byte7; //Field offset: 0x7
		public byte Byte8; //Field offset: 0x8
		public byte Byte9; //Field offset: 0x9
		public byte Byte10; //Field offset: 0xA
		public byte Byte11; //Field offset: 0xB
		public byte Byte12; //Field offset: 0xC
		public byte Byte13; //Field offset: 0xD
		public byte Byte14; //Field offset: 0xE
		public byte Byte15; //Field offset: 0xF

	}

	private struct DoubleByteUnion
	{
		public byte Byte0; //Field offset: 0x0
		public double Value; //Field offset: 0x0
		public byte Byte1; //Field offset: 0x1
		public byte Byte2; //Field offset: 0x2
		public byte Byte3; //Field offset: 0x3
		public byte Byte4; //Field offset: 0x4
		public byte Byte5; //Field offset: 0x5
		public byte Byte6; //Field offset: 0x6
		public byte Byte7; //Field offset: 0x7

	}

	private struct GuidByteUnion
	{
		public byte Byte0; //Field offset: 0x0
		public Guid Value; //Field offset: 0x0
		public byte Byte1; //Field offset: 0x1
		public byte Byte2; //Field offset: 0x2
		public byte Byte3; //Field offset: 0x3
		public byte Byte4; //Field offset: 0x4
		public byte Byte5; //Field offset: 0x5
		public byte Byte6; //Field offset: 0x6
		public byte Byte7; //Field offset: 0x7
		public byte Byte8; //Field offset: 0x8
		public byte Byte9; //Field offset: 0x9
		public byte Byte10; //Field offset: 0xA
		public byte Byte11; //Field offset: 0xB
		public byte Byte12; //Field offset: 0xC
		public byte Byte13; //Field offset: 0xD
		public byte Byte14; //Field offset: 0xE
		public byte Byte15; //Field offset: 0xF

	}

	private struct SingleByteUnion
	{
		public byte Byte0; //Field offset: 0x0
		public float Value; //Field offset: 0x0
		public byte Byte1; //Field offset: 0x1
		public byte Byte2; //Field offset: 0x2
		public byte Byte3; //Field offset: 0x3

	}

	private static readonly UInt32[] ByteToHexCharLookupLowerCase; //Field offset: 0x0
	private static readonly UInt32[] ByteToHexCharLookupUpperCase; //Field offset: 0x8
	private static readonly Byte[] HexToByteLookup; //Field offset: 0x10

	private static ProperBitConverter() { }

	public static string BytesToHexString(Byte[] bytes, bool lowerCaseHexChars = true) { }

	private static UInt32[] CreateByteToHexLookup(bool upperCase) { }

	public static void GetBytes(Byte[] buffer, int index, short value) { }

	public static void GetBytes(Byte[] buffer, int index, decimal value) { }

	public static void GetBytes(Byte[] buffer, int index, double value) { }

	public static void GetBytes(Byte[] buffer, int index, float value) { }

	public static void GetBytes(Byte[] buffer, int index, ulong value) { }

	public static void GetBytes(Byte[] buffer, int index, long value) { }

	public static void GetBytes(Byte[] buffer, int index, uint value) { }

	public static void GetBytes(Byte[] buffer, int index, int value) { }

	public static void GetBytes(Byte[] buffer, int index, Guid value) { }

	public static void GetBytes(Byte[] buffer, int index, ushort value) { }

	public static Byte[] HexStringToBytes(string hex) { }

	public static decimal ToDecimal(Byte[] buffer, int index) { }

	public static double ToDouble(Byte[] buffer, int index) { }

	public static Guid ToGuid(Byte[] buffer, int index) { }

	public static short ToInt16(Byte[] buffer, int index) { }

	public static int ToInt32(Byte[] buffer, int index) { }

	public static long ToInt64(Byte[] buffer, int index) { }

	public static float ToSingle(Byte[] buffer, int index) { }

	public static ushort ToUInt16(Byte[] buffer, int index) { }

	public static uint ToUInt32(Byte[] buffer, int index) { }

	public static ulong ToUInt64(Byte[] buffer, int index) { }

}

