namespace rail;

public class IRailPlayerStatsImpl : RailObject, IRailPlayerStats, IRailComponent
{

	internal IRailPlayerStatsImpl(IntPtr cPtr) { }

	public override RailResult AsyncRequestStats(string user_data) { }

	public override RailResult AsyncStoreStats(string user_data) { }

	protected virtual void Finalize() { }

	public override ulong GetComponentVersion() { }

	public override RailID GetRailID() { }

	public override RailResult GetStatValue(string name, out int data) { }

	public override RailResult GetStatValue(string name, out double data) { }

	public override void Release() { }

	public override RailResult ResetAllStats() { }

	public override RailResult SetStatValue(string name, int data) { }

	public override RailResult SetStatValue(string name, double data) { }

	public override RailResult UpdateAverageStatValue(string name, double data) { }

}

