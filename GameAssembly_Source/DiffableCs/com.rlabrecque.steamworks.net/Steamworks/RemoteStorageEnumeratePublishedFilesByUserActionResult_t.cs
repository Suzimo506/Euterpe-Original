namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct RemoteStorageEnumeratePublishedFilesByUserActionResult_t
{
	public const int k_iCallback = 1328; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public EWorkshopFileAction m_eAction; //Field offset: 0x4
	public int m_nResultsReturned; //Field offset: 0x8
	public int m_nTotalResultCount; //Field offset: 0xC
	public PublishedFileId_t[] m_rgPublishedFileId; //Field offset: 0x10
	public UInt32[] m_rgRTimeUpdated; //Field offset: 0x18

}

