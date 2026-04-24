using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002EE")]
public class GameServerStartSessionWithPlayerResponse : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001211")]
	public RailID remote_rail_id;

	[Address(RVA = "0xD20270", Offset = "0xD1EA70", Length = "0x64")]
	[Token(Token = "0x6002DC5")]
	public GameServerStartSessionWithPlayerResponse()
	{
	}
}
