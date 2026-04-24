namespace rail;

public interface IRailStatisticHelper
{

	public RailResult AsyncGetNumberOfPlayer(string user_data) { }

	public IRailPlayerStats CreatePlayerStats(RailID player) { }

	public IRailGlobalStats GetGlobalStats() { }

}

