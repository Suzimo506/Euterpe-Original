using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000314")]
public class RailPurchaseProductInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400125A")]
	public string category;

	[Token(Token = "0x400125B")]
	[FieldOffset(Offset = "0x18")]
	public float original_price;

	[Token(Token = "0x400125C")]
	[FieldOffset(Offset = "0x20")]
	public string description;

	[Token(Token = "0x400125D")]
	[FieldOffset(Offset = "0x28")]
	public RailDiscountInfo discount;

	[Token(Token = "0x400125E")]
	[FieldOffset(Offset = "0x30")]
	public bool is_purchasable;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400125F")]
	public string name;

	[Token(Token = "0x4001260")]
	[FieldOffset(Offset = "0x40")]
	public string currency_type;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001261")]
	public string product_thumbnail;

	[Token(Token = "0x4001262")]
	[FieldOffset(Offset = "0x50")]
	public RailPurchaseProductExtraInfo extra_info;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001263")]
	public uint product_id;

	[Address(RVA = "0x2721010", Offset = "0x271F810", Length = "0x8C")]
	[Token(Token = "0x6002DFE")]
	public RailPurchaseProductInfo()
	{
	}
}
