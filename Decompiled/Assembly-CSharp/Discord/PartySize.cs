using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000422")]
public struct PartySize
{
	[Token(Token = "0x4001718")]
	[FieldOffset(Offset = "0x0")]
	public int CurrentSize;

	[Token(Token = "0x4001719")]
	[FieldOffset(Offset = "0x4")]
	public int MaxSize;
}
