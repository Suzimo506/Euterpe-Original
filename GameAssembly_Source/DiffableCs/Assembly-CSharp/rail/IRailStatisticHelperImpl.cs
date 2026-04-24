namespace rail;

public class IRailStatisticHelperImpl : RailObject, IRailStatisticHelper
{

	internal IRailStatisticHelperImpl(IntPtr cPtr) { }

	public override RailResult AsyncGetNumberOfPlayer(string user_data) { }

	public override IRailPlayerStats CreatePlayerStats(RailID player) { }

	protected virtual void Finalize() { }

	public override IRailGlobalStats GetGlobalStats() { }

}

