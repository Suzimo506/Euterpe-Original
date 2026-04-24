namespace rail;

public class LeaderboardData
{
	public string additional_infomation; //Field offset: 0x10
	public double score; //Field offset: 0x18
	public int rank; //Field offset: 0x20
	public SpaceWorkID spacework_id; //Field offset: 0x28

	public LeaderboardData() { }

}

