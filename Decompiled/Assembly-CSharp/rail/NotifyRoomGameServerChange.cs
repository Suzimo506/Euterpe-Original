using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000355")]
public class NotifyRoomGameServerChange : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400145D")]
	public RailID game_server_rail_id;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400145E")]
	public ulong room_id;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400145F")]
	public ulong game_server_channel_id;

	[Token(Token = "0x6002E87")]
	[Address(RVA = "0x37E720", Offset = "0x37CF20", Length = "0x64")]
	public NotifyRoomGameServerChange()
	{
	}
}
