namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct SubmitItemUpdateResult_t
{
	public const int k_iCallback = 3404; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public bool m_bUserNeedsToAcceptWorkshopLegalAgreement; //Field offset: 0x4
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8

}

