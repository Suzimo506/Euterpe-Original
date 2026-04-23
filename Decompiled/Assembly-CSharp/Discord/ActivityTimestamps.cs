using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000420")]
public struct ActivityTimestamps
{
	[Token(Token = "0x4001712")]
	[FieldOffset(Offset = "0x0")]
	public long Start;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001713")]
	public long End;
}
