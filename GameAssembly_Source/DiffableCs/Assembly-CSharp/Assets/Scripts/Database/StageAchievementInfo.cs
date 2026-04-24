namespace Assets.Scripts.Database;

public class StageAchievementInfo : BaseDataObject
{
	public string uid; //Field offset: 0x20
	public StageAchievement[] easy; //Field offset: 0x28
	public StageAchievement[] normal; //Field offset: 0x30
	public StageAchievement[] hard; //Field offset: 0x38
	protected StageAchievementExInfo m_ExInfo; //Field offset: 0x40

	public int count
	{
		 get { } //Length: 39
	}

	public StageAchievementExInfo exInfo
	{
		 get { } //Length: 5
	}

	public StageAchievementInfo() { }

	public bool ContainsAchv(int diff) { }

	internal bool DoAchievement(AchievementArgs args, Dictionary<StageAchievement, AchiInfo> buffer) { }

	public int get_count() { }

	public StageAchievementExInfo get_exInfo() { }

	public virtual void Init(int index) { }

	private void InitExInfo() { }

}

