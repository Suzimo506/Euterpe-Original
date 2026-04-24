namespace PeroPeroGames.DataStatistics;

public abstract class DataStatisticsManager
{
	protected static DataStatisticsManager s_Instance; //Field offset: 0x0
	protected bool m_Init; //Field offset: 0x10

	public static DataStatisticsManager instance
	{
		 get { } //Length: 53
	}

	public bool isInit
	{
		 get { } //Length: 5
	}

	protected string platform
	{
		 get { } //Length: 43
	}

	protected DataStatisticsManager() { }

	public static DataStatisticsManager get_instance() { }

	public bool get_isInit() { }

	protected string get_platform() { }

	public override void Init() { }

	public static T Instance() { }

	private void OnLogin() { }

	protected abstract void OnLogin(string peroUid) { }

	protected abstract void OnLogout() { }

}

