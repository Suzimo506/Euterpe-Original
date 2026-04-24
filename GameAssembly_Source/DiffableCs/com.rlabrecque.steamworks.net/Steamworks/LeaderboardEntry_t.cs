namespace Steamworks;

public struct LeaderboardEntry_t
{
	public CSteamID m_steamIDUser; //Field offset: 0x0
	public int m_nGlobalRank; //Field offset: 0x8
	public int m_nScore; //Field offset: 0xC
	public int m_cDetails; //Field offset: 0x10
	public UGCHandle_t m_hUGC; //Field offset: 0x18

}

