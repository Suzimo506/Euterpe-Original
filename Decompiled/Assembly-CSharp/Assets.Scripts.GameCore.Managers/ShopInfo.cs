using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x200074C")]
public struct ShopInfo
{
	[Token(Token = "0x4002695")]
	[FieldOffset(Offset = "0x0")]
	public string language;

	[Token(Token = "0x4002696")]
	[FieldOffset(Offset = "0x8")]
	public string name;

	[Token(Token = "0x4002697")]
	[FieldOffset(Offset = "0x10")]
	public string good_link;

	[Token(Token = "0x1700066F")]
	public bool isAlive
	{
		[Address(RVA = "0x5A33B0", Offset = "0x5A1BB0", Length = "0x16")]
		[Token(Token = "0x6004450")]
		get
		{
			return default(bool);
		}
	}
}
