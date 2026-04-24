namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct RemoteStoragePublishedFileUpdated_t
{
	public const int k_iCallback = 1330; //Field offset: 0x0
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x0
	public AppId_t m_nAppID; //Field offset: 0x8
	public ulong m_ulUnused; //Field offset: 0x10

}

