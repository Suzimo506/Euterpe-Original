using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002E4")]
public class AsyncRemoveFavoriteGameServerResult : EventBase
{
	[Token(Token = "0x40011E1")]
	[FieldOffset(Offset = "0x30")]
	public RailID server_id;

	[Token(Token = "0x6002DBC")]
	[Address(RVA = "0xD1F5C0", Offset = "0xD1DDC0", Length = "0x64")]
	public AsyncRemoveFavoriteGameServerResult()
	{
	}
}
