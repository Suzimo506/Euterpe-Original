using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000426")]
public struct Presence
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001729")]
	public Status Status;

	[Token(Token = "0x400172A")]
	[FieldOffset(Offset = "0x8")]
	public Activity Activity;
}
