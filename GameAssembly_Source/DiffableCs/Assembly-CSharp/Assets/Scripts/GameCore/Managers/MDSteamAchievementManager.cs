namespace Assets.Scripts.GameCore.Managers;

internal class MDSteamAchievementManager : SteamAchievementManager
{
	private DBConfigSteamAchievement m_DBConfigSteamAchievement; //Field offset: 0x20
	private int m_NonHiddenCount; //Field offset: 0x28
	private int m_FinishNonHiddenCount; //Field offset: 0x2C

	public MDSteamAchievementManager() { }

	public void BattleEndDo(ref GlobalAchievementArgs args) { }

	private void CheckBattleAchievement(int id, ref GlobalAchievementArgs args) { }

	private void CheckOrderAchievement() { }

	protected virtual string GetApiNameById(int id) { }

	protected virtual string GetStateNameById(int id) { }

	public virtual void Init() { }

	private void InitUserData() { }

	public void ItemDo(int characterUnlockCount, int elfinUnlockCount, int loadingUnlockCount) { }

	private void Private_RefreshState(bool init) { }

	protected virtual void RefreshState() { }

	public void SetSpecialSteamAchievement(int id, bool enable = true) { }

	private void SteamBattleAchievementCheck(ref GlobalAchievementArgs args) { }

	public void TutorialDo() { }

}

