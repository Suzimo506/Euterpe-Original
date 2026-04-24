namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct ItemInstalled_t
{
	public const int k_iCallback = 3405; //Field offset: 0x0
	public AppId_t m_unAppID; //Field offset: 0x0
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8

}

