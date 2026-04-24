namespace rail;

public class GameServerInfo
{
	public List<RailKeyValue> server_kvs; //Field offset: 0x10
	public RailID owner_rail_id; //Field offset: 0x18
	public string game_server_name; //Field offset: 0x20
	public string server_fullname; //Field offset: 0x28
	public bool is_dedicated; //Field offset: 0x30
	public string server_info; //Field offset: 0x38
	public string server_tags; //Field offset: 0x40
	public string spectator_host; //Field offset: 0x48
	public string server_description; //Field offset: 0x50
	public string server_host; //Field offset: 0x58
	public RailID game_server_rail_id; //Field offset: 0x60
	public bool has_password; //Field offset: 0x68
	public string server_version; //Field offset: 0x70
	public List<String> server_mods; //Field offset: 0x78
	public uint bot_players; //Field offset: 0x80
	public string game_server_map; //Field offset: 0x88
	public uint max_players; //Field offset: 0x90
	public uint current_players; //Field offset: 0x94
	public bool is_friend_only; //Field offset: 0x98

	public GameServerInfo() { }

}

