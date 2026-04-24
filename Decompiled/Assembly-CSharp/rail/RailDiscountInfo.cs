using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200030D")]
public class RailDiscountInfo
{
	[Token(Token = "0x400124C")]
	[FieldOffset(Offset = "0x10")]
	public PurchaseProductDiscountType type;

	[Token(Token = "0x400124D")]
	[FieldOffset(Offset = "0x14")]
	public uint start_time;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400124E")]
	public float off;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400124F")]
	public float discount_price;

	[Token(Token = "0x4001250")]
	[FieldOffset(Offset = "0x20")]
	public uint end_time;

	[Token(Token = "0x6002DF7")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RailDiscountInfo()
	{
	}
}
