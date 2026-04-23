using System;
using Cpp2ILInjected;

namespace Assets.Scripts.Structs;

[Serializable]
[Token(Token = "0x200057A")]
public struct ProductInfo
{
	[Token(Token = "0x400204C")]
	[FieldOffset(Offset = "0x0")]
	public string productId;

	[Token(Token = "0x400204D")]
	[FieldOffset(Offset = "0x8")]
	public string pay_product_id;

	[Token(Token = "0x400204E")]
	[FieldOffset(Offset = "0x10")]
	public int price;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400204F")]
	public DateTime buyTime;

	[Address(RVA = "0x657A60", Offset = "0x656260", Length = "0x2A1")]
	[Token(Token = "0x600386C")]
	public override string ToString()
	{
		return null;
	}

	[Address(RVA = "0x657A30", Offset = "0x656230", Length = "0x2B")]
	[Token(Token = "0x600386D")]
	public string GetPayProductId()
	{
		return null;
	}
}
