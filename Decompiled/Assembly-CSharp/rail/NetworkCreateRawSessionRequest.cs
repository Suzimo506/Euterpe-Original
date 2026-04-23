using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200032E")]
public class NetworkCreateRawSessionRequest : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001298")]
	public RailID local_peer;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001299")]
	public RailGamePeer remote_game_peer;

	[Token(Token = "0x6002E34")]
	[Address(RVA = "0x37E620", Offset = "0x37CE20", Length = "0x8C")]
	public NetworkCreateRawSessionRequest()
	{
	}
}
