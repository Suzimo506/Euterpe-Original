namespace rail;

public class IRailLeaderboardImpl : RailObject, IRailLeaderboard, IRailComponent
{

	internal IRailLeaderboardImpl(IntPtr cPtr) { }

	public override RailResult AsyncAttachSpaceWork(SpaceWorkID spacework_id, string user_data) { }

	public override RailResult AsyncGetLeaderboard(string user_data) { }

	public override RailResult AsyncUploadLeaderboard(UploadLeaderboardParam update_param, string user_data) { }

	public override IRailLeaderboardEntries CreateLeaderboardEntries() { }

	protected virtual void Finalize() { }

	public override ulong GetComponentVersion() { }

	public override RailResult GetLeaderboardDisplayType(out int display_type) { }

	public override string GetLeaderboardName() { }

	public override RailResult GetLeaderboardParameters(LeaderboardParameters param) { }

	public override RailResult GetLeaderboardSortType(out int sort_type) { }

	public override int GetTotalEntriesCount() { }

	public override void Release() { }

}

