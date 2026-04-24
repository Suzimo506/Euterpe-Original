using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000305")]
public class RailCoins
{
	[Token(Token = "0x4001235")]
	[FieldOffset(Offset = "0x10")]
	public float total_price;

	[Token(Token = "0x4001236")]
	[FieldOffset(Offset = "0x14")]
	public uint coin_class_id;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001237")]
	public uint quantity;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002DED")]
	public RailCoins()
	{
	}
}
