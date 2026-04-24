using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002E6")]
public class CreateGameServerResult : EventBase
{
	[Token(Token = "0x40011E4")]
	[FieldOffset(Offset = "0x30")]
	public RailID game_server_id;

	[Address(RVA = "0xD1F900", Offset = "0xD1E100", Length = "0x64")]
	[Token(Token = "0x6002DBE")]
	public CreateGameServerResult()
	{
	}
}
