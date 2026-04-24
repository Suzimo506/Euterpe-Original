using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200032D")]
public class NetworkCreateRawSessionFailed : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001296")]
	public RailID local_peer;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001297")]
	public RailGamePeer remote_game_peer;

	[Token(Token = "0x6002E33")]
	[Address(RVA = "0x37E590", Offset = "0x37CD90", Length = "0x8C")]
	public NetworkCreateRawSessionFailed()
	{
	}
}
