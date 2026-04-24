namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct GetAppDependenciesResult_t
{
	public const int k_iCallback = 3416; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8
	public AppId_t[] m_rgAppIDs; //Field offset: 0x10
	public uint m_nNumAppDependencies; //Field offset: 0x18
	public uint m_nTotalNumAppDependencies; //Field offset: 0x1C

}

