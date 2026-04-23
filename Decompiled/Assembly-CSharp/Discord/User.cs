using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x200041C")]
public struct User
{
	[Token(Token = "0x4001705")]
	[FieldOffset(Offset = "0x0")]
	public long Id;

	[Token(Token = "0x4001706")]
	[FieldOffset(Offset = "0x8")]
	public string Username;

	[Token(Token = "0x4001707")]
	[FieldOffset(Offset = "0x10")]
	public string Discriminator;

	[Token(Token = "0x4001708")]
	[FieldOffset(Offset = "0x18")]
	public string Avatar;

	[Token(Token = "0x4001709")]
	[FieldOffset(Offset = "0x20")]
	public bool Bot;
}
