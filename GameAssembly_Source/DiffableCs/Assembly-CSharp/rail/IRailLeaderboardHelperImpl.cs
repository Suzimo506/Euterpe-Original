namespace rail;

public class IRailLeaderboardHelperImpl : RailObject, IRailLeaderboardHelper
{

	internal IRailLeaderboardHelperImpl(IntPtr cPtr) { }

	public override IRailLeaderboard AsyncCreateLeaderboard(string leaderboard_name, LeaderboardSortType sort_type, LeaderboardDisplayType display_type, string user_data, out RailResult result) { }

	protected virtual void Finalize() { }

	public override IRailLeaderboard OpenLeaderboard(string leaderboard_name) { }

}

