using System;
using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Serializable]
[Token(Token = "0x20006B5")]
public struct DiscountInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400241C")]
	public string discountSourceString;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400241D")]
	public string productId;

	[Token(Token = "0x400241E")]
	[FieldOffset(Offset = "0x10")]
	public string pay_product_id;

	[Token(Token = "0x400241F")]
	[FieldOffset(Offset = "0x18")]
	public int discount;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002420")]
	public DateTime startTimeUtc;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002421")]
	public DateTime endTimeUtc;

	[Token(Token = "0x6003EE2")]
	[Address(RVA = "0xFD49C0", Offset = "0xFD31C0", Length = "0x26D")]
	public override string ToString()
	{
		return null;
	}

	[Address(RVA = "0xFD49A0", Offset = "0xFD31A0", Length = "0x16")]
	[Token(Token = "0x6003EE3")]
	public bool IsActive(DateTime utcServerTime)
	{
		return default(bool);
	}
}
