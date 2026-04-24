namespace PeroPeroGames.DataStatistics;

public class ThinkingDataAnalyticsManager : DataStatisticsManager
{
	private const string app_id = "374bfde32ff3436890ff977bc94f8015"; //Field offset: 0x0

	public ThinkingDataAnalyticsManager() { }

	public virtual void Init() { }

	private void InitSDK() { }

	private void InitSteam() { }

	protected virtual void OnLogin(string peroUid) { }

	protected virtual void OnLogout() { }

	private void RefreshLoginInfo(string peroUid) { }

	private void UploadDriverOffset(int offset) { }

}

