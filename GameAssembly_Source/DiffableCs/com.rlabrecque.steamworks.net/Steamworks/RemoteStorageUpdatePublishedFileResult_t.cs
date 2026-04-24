namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct RemoteStorageUpdatePublishedFileResult_t
{
	public const int k_iCallback = 1316; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8
	public bool m_bUserNeedsToAcceptWorkshopLegalAgreement; //Field offset: 0x10

}

