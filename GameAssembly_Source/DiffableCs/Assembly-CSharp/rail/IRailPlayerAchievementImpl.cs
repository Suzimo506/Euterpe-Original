namespace rail;

public class IRailPlayerAchievementImpl : RailObject, IRailPlayerAchievement, IRailComponent
{

	internal IRailPlayerAchievementImpl(IntPtr cPtr) { }

	public override RailResult AsyncRequestAchievement(string user_data) { }

	public override RailResult AsyncStoreAchievement(string user_data) { }

	public override RailResult AsyncTriggerAchievementProgress(string name, uint current_value, uint max_value, string user_data) { }

	public override RailResult AsyncTriggerAchievementProgress(string name, uint current_value, uint max_value) { }

	public override RailResult AsyncTriggerAchievementProgress(string name, uint current_value) { }

	public override RailResult CancelAchievement(string name) { }

	protected virtual void Finalize() { }

	public override RailResult GetAchievementInfo(string name, out string achievement_info) { }

	public override RailResult GetAllAchievementsName(List<String> names) { }

	public override ulong GetComponentVersion() { }

	public override RailID GetRailID() { }

	public override RailResult HasAchieved(string name, out bool achieved) { }

	public override RailResult MakeAchievement(string name) { }

	public override void Release() { }

	public override RailResult ResetAllAchievements() { }

}

