using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002F2")]
public class SetGameServerMetadataResult : EventBase
{
	[Token(Token = "0x400121A")]
	[FieldOffset(Offset = "0x30")]
	public RailID game_server_id;

	[Address(RVA = "0x2722100", Offset = "0x2720900", Length = "0x9D")]
	[Token(Token = "0x6002DC9")]
	public SetGameServerMetadataResult()
	{
	}
}
