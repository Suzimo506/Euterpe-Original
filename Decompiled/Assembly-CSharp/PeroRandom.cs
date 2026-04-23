using Cpp2ILInjected;

[Token(Token = "0x200007C")]
public class PeroRandom
{
	[Token(Token = "0x4000329")]
	[FieldOffset(Offset = "0x10")]
	private int[] m_RandomArray;

	[Token(Token = "0x400032A")]
	[FieldOffset(Offset = "0x18")]
	private int m_Index;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400032B")]
	private int m_Length;

	[Address(RVA = "0x4F7690", Offset = "0x4F5E90", Length = "0x2D")]
	[Token(Token = "0x60003A3")]
	public PeroRandom(int length)
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x4F7440", Offset = "0x4F5C40", Length = "0x19A")]
	public void Reset(int length)
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x4F75E0", Offset = "0x4F5DE0", Length = "0xAB")]
	public void Shuffle()
	{
	}

	[Address(RVA = "0x4F73D0", Offset = "0x4F5BD0", Length = "0x64")]
	[Token(Token = "0x60003A6")]
	public int Next()
	{
		return default(int);
	}
}
