namespace Assets.Scripts.Database;

internal class DBConfigSteamAchievement : BaseDBConfigObject
{
	private List<SteamAchievementInfo> m_Items; //Field offset: 0x38
	private Dictionary<Int32, SteamAchievementInfo> m_Buffer; //Field offset: 0x40

	protected private List<SteamAchievementInfo> list
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigSteamAchievement() { }

	public virtual void Deserialize(string str) { }

	protected List<SteamAchievementInfo> get_list() { }

	private bool GetAchievementInfo(int id, out SteamAchievementInfo result) { }

	public string GetAPINameById(int id) { }

	public bool GetExInfo(int id, out SteamAchievementExInfo info) { }

	public string GetStateNameById(int id) { }

	private void set_list(List<SteamAchievementInfo> value) { }

	public bool SetExInfo(int id, SteamAchievementExInfo info) { }

}

