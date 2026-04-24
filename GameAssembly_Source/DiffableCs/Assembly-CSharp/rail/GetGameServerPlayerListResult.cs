namespace rail;

public class GetGameServerPlayerListResult : EventBase
{
	public RailID game_server_id; //Field offset: 0x30
	public List<GameServerPlayerInfo> server_player_info; //Field offset: 0x38

	public GetGameServerPlayerListResult() { }

}

