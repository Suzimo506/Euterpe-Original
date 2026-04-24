namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct RemoteStorageEnumerateWorkshopFilesResult_t
{
	public const int k_iCallback = 1319; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public int m_nResultsReturned; //Field offset: 0x4
	public int m_nTotalResultCount; //Field offset: 0x8
	public PublishedFileId_t[] m_rgPublishedFileId; //Field offset: 0x10
	public Single[] m_rgScore; //Field offset: 0x18
	public AppId_t m_nAppId; //Field offset: 0x20
	public uint m_unStartIndex; //Field offset: 0x24

}

