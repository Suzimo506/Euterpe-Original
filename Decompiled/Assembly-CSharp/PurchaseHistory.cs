using System;
using Cpp2ILInjected;

[Token(Token = "0x200008D")]
public struct PurchaseHistory
{
	[Token(Token = "0x4000399")]
	[FieldOffset(Offset = "0x0")]
	public string product_id;

	[Token(Token = "0x400039A")]
	[FieldOffset(Offset = "0x8")]
	public DateTime buy_time;
}
