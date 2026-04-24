namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct GSClientAchievementStatus_t
{
	public const int k_iCallback = 206; //Field offset: 0x0
	public ulong m_SteamID; //Field offset: 0x0
	private Byte[] m_pchAchievement_; //Field offset: 0x8
	public bool m_bUnlocked; //Field offset: 0x10

	public string m_pchAchievement
	{
		 get { } //Length: 134
		 set { } //Length: 24
	}

	public string get_m_pchAchievement() { }

	public void set_m_pchAchievement(string value) { }

}

