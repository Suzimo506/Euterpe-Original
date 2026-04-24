using Cpp2ILInjected;

namespace GameLogic;

[Token(Token = "0x20004A7")]
public class GameMissPlay
{
	[Token(Token = "0x400190B")]
	[FieldOffset(Offset = "0x10")]
	private decimal m_MissHardTime;

	[Token(Token = "0x60034E0")]
	[Address(RVA = "0x8F9DA0", Offset = "0x8F85A0", Length = "0x61")]
	public void Init()
	{
	}

	[Token(Token = "0x60034E1")]
	[Address(RVA = "0x8FA530", Offset = "0x8F8D30", Length = "0x8")]
	public void SetMissHardTime(decimal t)
	{
	}

	[Address(RVA = "0x674C60", Offset = "0x673460", Length = "0xB")]
	[Token(Token = "0x60034E2")]
	public decimal GetMissHardTime()
	{
		return default(decimal);
	}

	[Token(Token = "0x60034E3")]
	[Address(RVA = "0x8F9E10", Offset = "0x8F8610", Length = "0x713")]
	public bool MissCube(int idx, decimal currentTick)
	{
		return default(bool);
	}

	[Address(RVA = "0x8FA540", Offset = "0x8F8D40", Length = "0x1AF")]
	[Token(Token = "0x60034E4")]
	public bool SkillMiss(int idx)
	{
		return default(bool);
	}

	[Token(Token = "0x60034E5")]
	[Address(RVA = "0x8FA6F0", Offset = "0x8F8EF0", Length = "0x6A")]
	public GameMissPlay()
	{
	}
}
