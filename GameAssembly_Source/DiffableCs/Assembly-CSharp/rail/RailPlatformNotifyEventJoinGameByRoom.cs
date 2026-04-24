namespace rail;

public class RailPlatformNotifyEventJoinGameByRoom : EventBase
{
	public string commandline_info; //Field offset: 0x30
	public ulong room_id; //Field offset: 0x38

	public RailPlatformNotifyEventJoinGameByRoom() { }

}

