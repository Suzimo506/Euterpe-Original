namespace rail;

public class RailPlatformNotifyEventJoinGameByGameServer : EventBase
{
	public string commandline_info; //Field offset: 0x30
	public RailID gameserver_railid; //Field offset: 0x38

	public RailPlatformNotifyEventJoinGameByGameServer() { }

}

