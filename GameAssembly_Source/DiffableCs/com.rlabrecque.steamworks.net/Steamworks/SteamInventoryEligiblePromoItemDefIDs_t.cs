namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct SteamInventoryEligiblePromoItemDefIDs_t
{
	public const int k_iCallback = 4703; //Field offset: 0x0
	public EResult m_result; //Field offset: 0x0
	public CSteamID m_steamID; //Field offset: 0x4
	public int m_numEligiblePromoItemDefs; //Field offset: 0xC
	public bool m_bCachedData; //Field offset: 0x10

}

