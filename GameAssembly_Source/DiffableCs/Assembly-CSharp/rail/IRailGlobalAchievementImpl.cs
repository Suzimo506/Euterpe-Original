namespace rail;

public class IRailGlobalAchievementImpl : RailObject, IRailGlobalAchievement, IRailComponent
{

	internal IRailGlobalAchievementImpl(IntPtr cPtr) { }

	public override RailResult AsyncRequestAchievement(string user_data) { }

	protected virtual void Finalize() { }

	public override ulong GetComponentVersion() { }

	public override RailResult GetGlobalAchievedPercent(string name, out double percent) { }

	public override RailResult GetGlobalAchievedPercentDescending(int index, out string name, out double percent) { }

	public override void Release() { }

}

