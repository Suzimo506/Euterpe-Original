namespace rail;

public interface IRailPlayerStats : IRailComponent
{

	public RailResult AsyncRequestStats(string user_data) { }

	public RailResult AsyncStoreStats(string user_data) { }

	public RailID GetRailID() { }

	public RailResult GetStatValue(string name, out int data) { }

	public RailResult GetStatValue(string name, out double data) { }

	public RailResult ResetAllStats() { }

	public RailResult SetStatValue(string name, int data) { }

	public RailResult SetStatValue(string name, double data) { }

	public RailResult UpdateAverageStatValue(string name, double data) { }

}

