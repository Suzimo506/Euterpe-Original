namespace rail;

public interface IRailPlayerAchievement : IRailComponent
{

	public RailResult AsyncRequestAchievement(string user_data) { }

	public RailResult AsyncStoreAchievement(string user_data) { }

	public RailResult AsyncTriggerAchievementProgress(string name, uint current_value, uint max_value, string user_data) { }

	public RailResult AsyncTriggerAchievementProgress(string name, uint current_value, uint max_value) { }

	public RailResult AsyncTriggerAchievementProgress(string name, uint current_value) { }

	public RailResult CancelAchievement(string name) { }

	public RailResult GetAchievementInfo(string name, out string achievement_info) { }

	public RailResult GetAllAchievementsName(List<String> names) { }

	public RailID GetRailID() { }

	public RailResult HasAchieved(string name, out bool achieved) { }

	public RailResult MakeAchievement(string name) { }

	public RailResult ResetAllAchievements() { }

}

