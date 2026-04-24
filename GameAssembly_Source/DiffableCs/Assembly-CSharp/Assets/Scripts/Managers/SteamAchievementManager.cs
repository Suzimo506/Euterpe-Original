namespace Assets.Scripts.Managers;

public abstract class SteamAchievementManager
{
	protected static SteamAchievementManager s_Instance; //Field offset: 0x0
	protected Dictionary<Int32, SteamAchievementState> m_UnlockState; //Field offset: 0x10
	[CompilerGenerated]
	private bool <initialized>k__BackingField; //Field offset: 0x18

	protected bool check_steam_initialized
	{
		 get { } //Length: 143
	}

	public bool initialized
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public static SteamAchievementManager instance
	{
		 get { } //Length: 53
	}

	protected SteamAchievementManager() { }

	protected bool get_check_steam_initialized() { }

	[CompilerGenerated]
	public bool get_initialized() { }

	public static SteamAchievementManager get_instance() { }

	protected abstract string GetApiNameById(int id) { }

	public static T GetInstance() { }

	protected abstract string GetStateNameById(int id) { }

	public abstract void Init() { }

	protected bool IsHidden(string apiName) { }

	protected abstract void RefreshState() { }

	public void SaveUserStat() { }

	[CompilerGenerated]
	protected void set_initialized(bool value) { }

	public override bool SetSteamAchievement(int id, bool enable, bool force = false) { }

	public override void SetSteamAchievementValue(int id, int value) { }

}

