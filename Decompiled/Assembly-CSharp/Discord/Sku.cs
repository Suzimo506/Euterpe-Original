using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x200042C")]
public struct Sku
{
	[Token(Token = "0x400173C")]
	[FieldOffset(Offset = "0x0")]
	public long Id;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400173D")]
	public SkuType Type;

	[Token(Token = "0x400173E")]
	[FieldOffset(Offset = "0x10")]
	public string Name;

	[Token(Token = "0x400173F")]
	[FieldOffset(Offset = "0x18")]
	public SkuPrice Price;
}
