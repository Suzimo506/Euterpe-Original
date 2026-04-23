using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x200042B")]
public struct SkuPrice
{
	[Token(Token = "0x400173A")]
	[FieldOffset(Offset = "0x0")]
	public uint Amount;

	[Token(Token = "0x400173B")]
	[FieldOffset(Offset = "0x8")]
	public string Currency;
}
