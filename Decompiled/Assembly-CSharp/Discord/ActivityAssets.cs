using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000421")]
public struct ActivityAssets
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001714")]
	public string LargeImage;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001715")]
	public string LargeText;

	[Token(Token = "0x4001716")]
	[FieldOffset(Offset = "0x10")]
	public string SmallImage;

	[Token(Token = "0x4001717")]
	[FieldOffset(Offset = "0x18")]
	public string SmallText;
}
