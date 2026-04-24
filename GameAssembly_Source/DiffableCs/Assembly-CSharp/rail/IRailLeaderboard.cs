namespace rail;

public interface IRailLeaderboard : IRailComponent
{

	public RailResult AsyncAttachSpaceWork(SpaceWorkID spacework_id, string user_data) { }

	public RailResult AsyncGetLeaderboard(string user_data) { }

	public RailResult AsyncUploadLeaderboard(UploadLeaderboardParam update_param, string user_data) { }

	public IRailLeaderboardEntries CreateLeaderboardEntries() { }

	public RailResult GetLeaderboardDisplayType(out int display_type) { }

	public string GetLeaderboardName() { }

	public RailResult GetLeaderboardParameters(LeaderboardParameters param) { }

	public RailResult GetLeaderboardSortType(out int sort_type) { }

	public int GetTotalEntriesCount() { }

}

