using System;
using Cpp2ILInjected;

namespace PeroPeroGames.Containers;

[Token(Token = "0x2000538")]
public struct BitContainer
{
	[Token(Token = "0x4001F63")]
	[FieldOffset(Offset = "0x0")]
	private int m_Value;

	[Address(RVA = "0x9120A0", Offset = "0x9108A0", Length = "0xDD")]
	[Token(Token = "0x6003749")]
	public T ToEnum<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x600374A")]
	[Address(RVA = "0x521930", Offset = "0x520130", Length = "0x3")]
	public BitContainer(int value)
	{
	}

	[Token(Token = "0x600374B")]
	[Address(RVA = "0x521950", Offset = "0x520150", Length = "0x3")]
	public static implicit operator int(BitContainer value)
	{
		return default(int);
	}

	[Token(Token = "0x600374C")]
	[Address(RVA = "0x521950", Offset = "0x520150", Length = "0x3")]
	public static implicit operator BitContainer(int value)
	{
		return default(BitContainer);
	}

	[Token(Token = "0x600374D")]
	[Address(RVA = "0x869E90", Offset = "0x868690", Length = "0x5")]
	public static BitContainer operator +(BitContainer container, int value)
	{
		return default(BitContainer);
	}

	[Token(Token = "0x600374E")]
	[Address(RVA = "0x869EA0", Offset = "0x8686A0", Length = "0x7")]
	public static BitContainer operator -(BitContainer container, int value)
	{
		return default(BitContainer);
	}

	[Address(RVA = "0x869D40", Offset = "0x868540", Length = "0xA")]
	[Token(Token = "0x600374F")]
	public bool Contains(int val)
	{
		return default(bool);
	}

	[Token(Token = "0x6003750")]
	[Address(RVA = "0x869D50", Offset = "0x868550", Length = "0x7")]
	public TypeCode GetTypeCode()
	{
		return default(TypeCode);
	}

	[Token(Token = "0x6003751")]
	[Address(RVA = "0x65E840", Offset = "0x65D040", Length = "0x7")]
	public bool ToBoolean()
	{
		return default(bool);
	}

	[Token(Token = "0x6003752")]
	[Address(RVA = "0x490460", Offset = "0x48EC60", Length = "0x4")]
	public char ToChar()
	{
		return default(char);
	}

	[Address(RVA = "0x65E760", Offset = "0x65CF60", Length = "0x4")]
	[Token(Token = "0x6003753")]
	public sbyte ToSByte()
	{
		return default(sbyte);
	}

	[Address(RVA = "0x65E760", Offset = "0x65CF60", Length = "0x4")]
	[Token(Token = "0x6003754")]
	public byte ToByte()
	{
		return default(byte);
	}

	[Address(RVA = "0x490460", Offset = "0x48EC60", Length = "0x4")]
	[Token(Token = "0x6003755")]
	public short ToInt16()
	{
		return default(short);
	}

	[Token(Token = "0x6003756")]
	[Address(RVA = "0x490460", Offset = "0x48EC60", Length = "0x4")]
	public ushort ToUInt16()
	{
		return default(ushort);
	}

	[Token(Token = "0x6003757")]
	[Address(RVA = "0x484100", Offset = "0x482900", Length = "0x3")]
	public int ToInt32()
	{
		return default(int);
	}

	[Token(Token = "0x6003758")]
	[Address(RVA = "0x484100", Offset = "0x482900", Length = "0x3")]
	public uint ToUInt32()
	{
		return default(uint);
	}

	[Address(RVA = "0x869E70", Offset = "0x868670", Length = "0x4")]
	[Token(Token = "0x6003759")]
	public long ToInt64()
	{
		return default(long);
	}

	[Address(RVA = "0x484100", Offset = "0x482900", Length = "0x3")]
	[Token(Token = "0x600375A")]
	public ulong ToUInt64()
	{
		return default(ulong);
	}

	[Address(RVA = "0x869E80", Offset = "0x868680", Length = "0x8")]
	[Token(Token = "0x600375B")]
	public float ToSingle()
	{
		return default(float);
	}

	[Address(RVA = "0x869E60", Offset = "0x868660", Length = "0x9")]
	[Token(Token = "0x600375C")]
	public double ToDouble()
	{
		return default(double);
	}

	[Address(RVA = "0x869DF0", Offset = "0x8685F0", Length = "0x6E")]
	[Token(Token = "0x600375D")]
	public decimal ToDecimal()
	{
		return default(decimal);
	}

	[Address(RVA = "0x869D60", Offset = "0x868560", Length = "0x8A")]
	[Token(Token = "0x600375E")]
	public DateTime ToDateTime(IFormatProvider provider)
	{
		return default(DateTime);
	}

	[Address(RVA = "0x527C80", Offset = "0x526480", Length = "0x7")]
	[Token(Token = "0x600375F")]
	public override string ToString()
	{
		return null;
	}
}
