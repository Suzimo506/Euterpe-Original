namespace rail;

public interface IRailGlobalStats : IRailComponent
{

	public RailResult AsyncRequestGlobalStats(string user_data) { }

	public RailResult GetGlobalStatValue(string name, out long data) { }

	public RailResult GetGlobalStatValue(string name, out double data) { }

	public RailResult GetGlobalStatValueHistory(string name, Int64[] global_stats_data, uint data_size, out int num_global_stats) { }

	public RailResult GetGlobalStatValueHistory(string name, Double[] global_stats_data, uint data_size, out int num_global_stats) { }

}

