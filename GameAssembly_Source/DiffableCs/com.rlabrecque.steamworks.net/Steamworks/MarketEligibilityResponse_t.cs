namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct MarketEligibilityResponse_t
{
	public const int k_iCallback = 166; //Field offset: 0x0
	public bool m_bAllowed; //Field offset: 0x0
	public EMarketNotAllowedReasonFlags m_eNotAllowedReason; //Field offset: 0x4
	public RTime32 m_rtAllowedAtTime; //Field offset: 0x8
	public int m_cdaySteamGuardRequiredDays; //Field offset: 0xC
	public int m_cdayNewDeviceCooldown; //Field offset: 0x10

}

