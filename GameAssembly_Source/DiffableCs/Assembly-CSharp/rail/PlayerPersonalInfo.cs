namespace rail;

public class PlayerPersonalInfo
{
	public RailResult error_code; //Field offset: 0x10
	public string avatar_url; //Field offset: 0x18
	public uint rail_level; //Field offset: 0x20
	public RailID rail_id; //Field offset: 0x28
	public string rail_name; //Field offset: 0x30
	public string email_address; //Field offset: 0x38

	public PlayerPersonalInfo() { }

}

