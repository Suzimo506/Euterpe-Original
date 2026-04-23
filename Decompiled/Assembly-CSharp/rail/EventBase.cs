using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002B2")]
public class EventBase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001094")]
	public RailResult result;

	[Token(Token = "0x4001095")]
	[FieldOffset(Offset = "0x18")]
	public RailGameID game_id;

	[Token(Token = "0x4001096")]
	[FieldOffset(Offset = "0x20")]
	public string user_data;

	[Token(Token = "0x4001097")]
	[FieldOffset(Offset = "0x28")]
	public RailID rail_id;

	[Address(RVA = "0xD1FEA0", Offset = "0xD1E6A0", Length = "0x8C")]
	[Token(Token = "0x6002D18")]
	public EventBase()
	{
	}
}
