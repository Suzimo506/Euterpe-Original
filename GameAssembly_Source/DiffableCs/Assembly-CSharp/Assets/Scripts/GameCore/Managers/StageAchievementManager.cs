namespace Assets.Scripts.GameCore.Managers;

public class StageAchievementManager : Singleton<StageAchievementManager>
{
	private SingletonDataObject m_StageAchievement; //Field offset: 0x10
	private List<String> m_StageAchievements; //Field offset: 0x18

	public StageAchievementManager() { }

	public int AddFinishCount(string saveId, int count) { }

	public void Do() { }

	private AchievementArgs GetAchievementArgs() { }

	public int GetFinishCount(string saveId) { }

	private void Init() { }

	public bool IsFinish(string saveId) { }

	private void Reward(string uid) { }

}

