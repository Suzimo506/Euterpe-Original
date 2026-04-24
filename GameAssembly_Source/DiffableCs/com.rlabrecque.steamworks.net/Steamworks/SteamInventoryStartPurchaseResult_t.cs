namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct SteamInventoryStartPurchaseResult_t
{
	public const int k_iCallback = 4704; //Field offset: 0x0
	public EResult m_result; //Field offset: 0x0
	public ulong m_ulOrderID; //Field offset: 0x8
	public ulong m_ulTransID; //Field offset: 0x10

}

