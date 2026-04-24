namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct LeaderboardScoreUploaded_t
{
	public const int k_iCallback = 1106; //Field offset: 0x0
	public byte m_bSuccess; //Field offset: 0x0
	public SteamLeaderboard_t m_hSteamLeaderboard; //Field offset: 0x8
	public int m_nScore; //Field offset: 0x10
	public byte m_bScoreChanged; //Field offset: 0x14
	public int m_nGlobalRankNew; //Field offset: 0x18
	public int m_nGlobalRankPrevious; //Field offset: 0x1C

}

