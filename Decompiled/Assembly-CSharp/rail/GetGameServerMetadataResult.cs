using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002F0")]
public class GetGameServerMetadataResult : EventBase
{
	[Token(Token = "0x4001216")]
	[FieldOffset(Offset = "0x30")]
	public RailID game_server_id;

	[Token(Token = "0x4001217")]
	[FieldOffset(Offset = "0x38")]
	public List<RailKeyValue> key_value;

	[Address(RVA = "0xD203C0", Offset = "0xD1EBC0", Length = "0x91")]
	[Token(Token = "0x6002DC7")]
	public GetGameServerMetadataResult()
	{
	}
}
