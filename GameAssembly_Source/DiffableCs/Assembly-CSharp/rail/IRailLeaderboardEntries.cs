namespace rail;

public interface IRailLeaderboardEntries : IRailComponent
{

	public RailResult AsyncRequestLeaderboardEntries(RailID player, RequestLeaderboardEntryParam param, string user_data) { }

	public int GetEntriesCount() { }

	public RequestLeaderboardEntryParam GetEntriesParam() { }

	public RailResult GetLeaderboardEntry(int index, LeaderboardEntry leaderboard_entry) { }

	public string GetLeaderboardName() { }

	public RailID GetRailID() { }

}

