using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x200080D")]
public class DBRandom : BaseDatabase
{
	[Token(Token = "0x2000D09")]
	public enum RandomType
	{
		[Token(Token = "0x4003EA3")]
		Loading,
		[Token(Token = "0x4003EA4")]
		Count
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40029F5")]
	private PeroRandom[] m_PeroRandoms;

	[Address(RVA = "0x102D7F0", Offset = "0x102BFF0", Length = "0xF6")]
	[Token(Token = "0x60048E0")]
	public void InitDatabase()
	{
	}

	[Address(RVA = "0x102D8F0", Offset = "0x102C0F0", Length = "0x40")]
	[Token(Token = "0x60048E1")]
	public int Next(RandomType randomType)
	{
		return default(int);
	}

	[Token(Token = "0x60048E2")]
	[Address(RVA = "0x102D940", Offset = "0x102C140", Length = "0xC7")]
	public void Reset(RandomType randomType)
	{
	}

	[Token(Token = "0x60048E3")]
	[Address(RVA = "0x102DA10", Offset = "0x102C210", Length = "0x40")]
	public void Shuffle(RandomType randomType)
	{
	}

	[Token(Token = "0x60048E4")]
	[Address(RVA = "0x102D7F0", Offset = "0x102BFF0", Length = "0xF6")]
	private void ResetAll()
	{
	}

	[Token(Token = "0x60048E5")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x60048E6")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void Release()
	{
	}

	[Address(RVA = "0x102DA60", Offset = "0x102C260", Length = "0x51")]
	[Token(Token = "0x60048E7")]
	public DBRandom()
	{
	}
}
