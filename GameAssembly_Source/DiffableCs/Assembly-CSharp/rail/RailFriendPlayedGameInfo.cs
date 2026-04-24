namespace rail;

public class RailFriendPlayedGameInfo
{
	public bool in_room; //Field offset: 0x10
	public List<UInt64> room_id_list; //Field offset: 0x18
	public RailID friend_id; //Field offset: 0x20
	public List<UInt64> game_server_id_list; //Field offset: 0x28
	public RailGameID game_id; //Field offset: 0x30
	public bool in_game_server; //Field offset: 0x38
	public RailFriendPlayedGamePlayState friend_played_game_play_state; //Field offset: 0x3C

	public RailFriendPlayedGameInfo() { }

}

