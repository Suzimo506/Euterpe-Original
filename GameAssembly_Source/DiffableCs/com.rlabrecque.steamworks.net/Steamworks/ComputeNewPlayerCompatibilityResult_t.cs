namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct ComputeNewPlayerCompatibilityResult_t
{
	public const int k_iCallback = 211; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public int m_cPlayersThatDontLikeCandidate; //Field offset: 0x4
	public int m_cPlayersThatCandidateDoesntLike; //Field offset: 0x8
	public int m_cClanPlayersThatDontLikeCandidate; //Field offset: 0xC
	public CSteamID m_SteamIDCandidate; //Field offset: 0x10

}

