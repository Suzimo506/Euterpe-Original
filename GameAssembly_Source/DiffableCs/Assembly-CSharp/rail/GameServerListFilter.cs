namespace rail;

public class GameServerListFilter
{
	public string tags_not_contained; //Field offset: 0x10
	public EnumRailOptionalValue filter_password; //Field offset: 0x18
	public string filter_game_server_name; //Field offset: 0x20
	public EnumRailOptionalValue filter_friends_created; //Field offset: 0x28
	public string tags_contained; //Field offset: 0x30
	public EnumRailOptionalValue filter_dedicated_server; //Field offset: 0x38
	public List<GameServerListFilterKey> filters; //Field offset: 0x40
	public string filter_game_server_map; //Field offset: 0x48
	public string filter_game_server_host; //Field offset: 0x50
	public RailID owner_id; //Field offset: 0x58

	public GameServerListFilter() { }

}

