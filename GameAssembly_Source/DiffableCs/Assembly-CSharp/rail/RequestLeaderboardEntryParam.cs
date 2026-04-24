namespace rail;

public class RequestLeaderboardEntryParam
{
	public int range_end; //Field offset: 0x10
	public int range_start; //Field offset: 0x14
	public LeaderboardType type; //Field offset: 0x18
	public bool user_coordinate; //Field offset: 0x1C

	public RequestLeaderboardEntryParam() { }

}

