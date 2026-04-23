using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006DB")]
public struct Receipt
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40024AD")]
	public bool isValid;

	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x40024AE")]
	public bool isPurchased;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40024AF")]
	public string transaction_id;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40024B0")]
	public string product_id;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40024B1")]
	public string package_name;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40024B2")]
	public string token;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40024B3")]
	public bool isSandBox;

	[Token(Token = "0x40024B4")]
	[FieldOffset(Offset = "0x30")]
	public string purchase_date_string;

	[Address(RVA = "0x658360", Offset = "0x656B60", Length = "0x317")]
	[Token(Token = "0x600400E")]
	public override string ToString()
	{
		return null;
	}
}
