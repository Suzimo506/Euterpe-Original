namespace rail;

public class RailFriendOnLineState
{
	public RailID friend_rail_id; //Field offset: 0x10
	public uint game_define_game_playing_state; //Field offset: 0x18
	public EnumRailPlayerOnLineState friend_online_state; //Field offset: 0x1C

	public RailFriendOnLineState() { }

}

