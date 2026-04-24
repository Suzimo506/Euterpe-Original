namespace Assets.Scripts.Database;

public class DBConfigStageAchievement : BaseDBConfigLocalObject<DBConfigLocalStageAchievement, LocalStageAchievementInfo>
{
	private List<StageAchievementInfo> m_Items; //Field offset: 0x40

	private List<StageAchievementInfo> m_List
	{
		private get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigStageAchievement() { }

	public virtual void Deserialize(string str) { }

	private List<StageAchievementInfo> get_m_List() { }

	public StageAchievementInfo GetAchievementInfoByIndex(int index) { }

	public StageAchievementInfo GetAchievementInfoByMusicUid(string musicUid) { }

	private void set_m_List(List<StageAchievementInfo> value) { }

}

