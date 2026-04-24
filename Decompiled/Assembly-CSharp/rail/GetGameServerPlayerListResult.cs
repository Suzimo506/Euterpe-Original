using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002F1")]
public class GetGameServerPlayerListResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001218")]
	public RailID game_server_id;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001219")]
	public List<GameServerPlayerInfo> server_player_info;

	[Address(RVA = "0xD20460", Offset = "0xD1EC60", Length = "0x91")]
	[Token(Token = "0x6002DC8")]
	public GetGameServerPlayerListResult()
	{
	}
}
