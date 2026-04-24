namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct UserAchievementIconFetched_t
{
	public const int k_iCallback = 1109; //Field offset: 0x0
	public CGameID m_nGameID; //Field offset: 0x0
	private Byte[] m_rgchAchievementName_; //Field offset: 0x8
	public bool m_bAchieved; //Field offset: 0x10
	public int m_nIconHandle; //Field offset: 0x14

	public string m_rgchAchievementName
	{
		 get { } //Length: 11
		 set { } //Length: 24
	}

	public string get_m_rgchAchievementName() { }

	public void set_m_rgchAchievementName(string value) { }

}

