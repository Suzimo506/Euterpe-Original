namespace Assets.Scripts.Database;

public class DBConfigLocalStageAchievement : BaseDBConfigObject
{
	private List<LocalStageAchievementInfo> m_Items; //Field offset: 0x38

	private List<LocalStageAchievementInfo> m_List
	{
		private get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigLocalStageAchievement() { }

	public virtual void Deserialize(string str) { }

	private List<LocalStageAchievementInfo> get_m_List() { }

	public LocalStageAchievementInfo GetLocalStageAchievementInfoByIndex(int index) { }

	private void set_m_List(List<LocalStageAchievementInfo> value) { }

}

