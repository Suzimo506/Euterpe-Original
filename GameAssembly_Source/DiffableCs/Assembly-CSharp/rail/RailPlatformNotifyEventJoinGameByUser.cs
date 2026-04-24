namespace rail;

public class RailPlatformNotifyEventJoinGameByUser : EventBase
{
	public RailID rail_id_to_join; //Field offset: 0x30
	public string commandline_info; //Field offset: 0x38

	public RailPlatformNotifyEventJoinGameByUser() { }

}

