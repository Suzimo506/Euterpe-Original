namespace rail;

public class LeaderboardUploaded : EventBase
{
	public int old_rank; //Field offset: 0x30
	public string leaderboard_name; //Field offset: 0x38
	public double score; //Field offset: 0x40
	public bool better_score; //Field offset: 0x48
	public int new_rank; //Field offset: 0x4C

	public LeaderboardUploaded() { }

}

