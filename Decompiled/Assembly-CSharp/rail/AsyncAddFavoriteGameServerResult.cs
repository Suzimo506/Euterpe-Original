using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002E2")]
public class AsyncAddFavoriteGameServerResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40011DF")]
	public RailID server_id;

	[Address(RVA = "0xD1F210", Offset = "0xD1DA10", Length = "0x64")]
	[Token(Token = "0x6002DBA")]
	public AsyncAddFavoriteGameServerResult()
	{
	}
}
