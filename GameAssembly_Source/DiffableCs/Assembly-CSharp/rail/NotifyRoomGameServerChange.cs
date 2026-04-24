namespace rail;

public class NotifyRoomGameServerChange : EventBase
{
	public RailID game_server_rail_id; //Field offset: 0x30
	public ulong room_id; //Field offset: 0x38
	public ulong game_server_channel_id; //Field offset: 0x40

	public NotifyRoomGameServerChange() { }

}

