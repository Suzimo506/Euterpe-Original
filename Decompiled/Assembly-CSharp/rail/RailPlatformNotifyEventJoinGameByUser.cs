using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000390")]
public class RailPlatformNotifyEventJoinGameByUser : EventBase
{
	[Token(Token = "0x40014E1")]
	[FieldOffset(Offset = "0x30")]
	public RailID rail_id_to_join;

	[Token(Token = "0x40014E2")]
	[FieldOffset(Offset = "0x38")]
	public string commandline_info;

	[Address(RVA = "0x2720D60", Offset = "0x271F560", Length = "0x9D")]
	[Token(Token = "0x6002EFA")]
	public RailPlatformNotifyEventJoinGameByUser()
	{
	}
}
