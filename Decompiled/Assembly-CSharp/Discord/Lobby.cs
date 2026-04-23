using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000428")]
public struct Lobby
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400172E")]
	public long Id;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400172F")]
	public LobbyType Type;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001730")]
	public long OwnerId;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001731")]
	public string Secret;

	[Token(Token = "0x4001732")]
	[FieldOffset(Offset = "0x20")]
	public uint Capacity;

	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001733")]
	public bool Locked;
}
