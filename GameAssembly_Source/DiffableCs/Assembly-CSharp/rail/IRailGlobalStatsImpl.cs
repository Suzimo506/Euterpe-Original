namespace rail;

public class IRailGlobalStatsImpl : RailObject, IRailGlobalStats, IRailComponent
{

	internal IRailGlobalStatsImpl(IntPtr cPtr) { }

	public override RailResult AsyncRequestGlobalStats(string user_data) { }

	protected virtual void Finalize() { }

	public override ulong GetComponentVersion() { }

	public override RailResult GetGlobalStatValue(string name, out long data) { }

	public override RailResult GetGlobalStatValue(string name, out double data) { }

	public override RailResult GetGlobalStatValueHistory(string name, Int64[] global_stats_data, uint data_size, out int num_global_stats) { }

	public override RailResult GetGlobalStatValueHistory(string name, Double[] global_stats_data, uint data_size, out int num_global_stats) { }

	public override void Release() { }

}

