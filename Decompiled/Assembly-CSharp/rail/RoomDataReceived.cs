using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200035A")]
public class RoomDataReceived : EventBase
{
	[Token(Token = "0x400146D")]
	[FieldOffset(Offset = "0x30")]
	public uint data_len;

	[Token(Token = "0x400146E")]
	[FieldOffset(Offset = "0x38")]
	public RailID remote_peer;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400146F")]
	public uint message_type;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001470")]
	public string data_buf;

	[Token(Token = "0x6002E8C")]
	[Address(RVA = "0x2721DF0", Offset = "0x27205F0", Length = "0x9D")]
	public RoomDataReceived()
	{
	}
}
