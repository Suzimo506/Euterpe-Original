namespace rail;

public interface IRailGlobalAchievement : IRailComponent
{

	public RailResult AsyncRequestAchievement(string user_data) { }

	public RailResult GetGlobalAchievedPercent(string name, out double percent) { }

	public RailResult GetGlobalAchievedPercentDescending(int index, out string name, out double percent) { }

}

