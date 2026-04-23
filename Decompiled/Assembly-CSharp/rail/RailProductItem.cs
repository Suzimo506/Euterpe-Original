using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200027D")]
public class RailProductItem
{
	[Token(Token = "0x4001000")]
	[FieldOffset(Offset = "0x10")]
	public uint product_id;

	[Token(Token = "0x4001001")]
	[FieldOffset(Offset = "0x14")]
	public uint quantity;

	[Token(Token = "0x6002CB8")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RailProductItem()
	{
	}
}
