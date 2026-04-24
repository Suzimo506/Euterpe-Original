using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x200041F")]
public struct ImageDimensions
{
	[Token(Token = "0x4001710")]
	[FieldOffset(Offset = "0x0")]
	public uint Width;

	[Token(Token = "0x4001711")]
	[FieldOffset(Offset = "0x4")]
	public uint Height;
}
