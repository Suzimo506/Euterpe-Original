namespace rail;

public class LeaderboardReceived : EventBase
{
	public string leaderboard_name; //Field offset: 0x30
	public bool does_exist; //Field offset: 0x38

	public LeaderboardReceived() { }

}

