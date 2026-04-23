using System.Collections.Generic;
using Assets.Scripts.Structs;
using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006D9")]
public struct TransactionResult
{
	[Token(Token = "0x400249F")]
	[FieldOffset(Offset = "0x0")]
	public TransactionState state;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40024A0")]
	public ProductInfo productInfo;

	[Token(Token = "0x40024A1")]
	[FieldOffset(Offset = "0x28")]
	public List<ProductInfo> products;

	[Token(Token = "0x40024A2")]
	[FieldOffset(Offset = "0x30")]
	public string receipt;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40024A3")]
	public string msg;

	[Token(Token = "0x40024A4")]
	[FieldOffset(Offset = "0x40")]
	public uint arg;

	[Token(Token = "0x40024A5")]
	[FieldOffset(Offset = "0x44")]
	public bool isFirstPurchase;

	[Token(Token = "0x40024A6")]
	[FieldOffset(Offset = "0x48")]
	public string orderId;
}
