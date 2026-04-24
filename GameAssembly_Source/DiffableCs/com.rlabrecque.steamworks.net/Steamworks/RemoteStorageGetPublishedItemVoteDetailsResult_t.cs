namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct RemoteStorageGetPublishedItemVoteDetailsResult_t
{
	public const int k_iCallback = 1320; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public PublishedFileId_t m_unPublishedFileId; //Field offset: 0x8
	public int m_nVotesFor; //Field offset: 0x10
	public int m_nVotesAgainst; //Field offset: 0x14
	public int m_nReports; //Field offset: 0x18
	public float m_fScore; //Field offset: 0x1C

}

