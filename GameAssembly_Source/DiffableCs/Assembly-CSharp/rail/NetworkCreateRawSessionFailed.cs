namespace rail;

public class NetworkCreateRawSessionFailed : EventBase
{
	public RailID local_peer; //Field offset: 0x30
	public RailGamePeer remote_game_peer; //Field offset: 0x38

	public NetworkCreateRawSessionFailed() { }

}

