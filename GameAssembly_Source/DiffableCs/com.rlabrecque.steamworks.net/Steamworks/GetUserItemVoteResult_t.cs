namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct GetUserItemVoteResult_t
{
	public const int k_iCallback = 3409; //Field offset: 0x0
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x8
	public bool m_bVotedUp; //Field offset: 0xC
	public bool m_bVotedDown; //Field offset: 0xD
	public bool m_bVoteSkipped; //Field offset: 0xE

}

