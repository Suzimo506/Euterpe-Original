namespace rail;

public class IRailLeaderboardEntriesImpl : RailObject, IRailLeaderboardEntries, IRailComponent
{

	internal IRailLeaderboardEntriesImpl(IntPtr cPtr) { }

	public override RailResult AsyncRequestLeaderboardEntries(RailID player, RequestLeaderboardEntryParam param, string user_data) { }

	protected virtual void Finalize() { }

	public override ulong GetComponentVersion() { }

	public override int GetEntriesCount() { }

	public override RequestLeaderboardEntryParam GetEntriesParam() { }

	public override RailResult GetLeaderboardEntry(int index, LeaderboardEntry leaderboard_entry) { }

	public override string GetLeaderboardName() { }

	public override RailID GetRailID() { }

	public override void Release() { }

}

