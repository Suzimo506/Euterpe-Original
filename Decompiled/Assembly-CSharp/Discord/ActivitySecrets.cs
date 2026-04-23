using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000424")]
public struct ActivitySecrets
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400171C")]
	public string Match;

	[Token(Token = "0x400171D")]
	[FieldOffset(Offset = "0x8")]
	public string Join;

	[Token(Token = "0x400171E")]
	[FieldOffset(Offset = "0x10")]
	public string Spectate;
}
