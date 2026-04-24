namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct ClanOfficerListResponse_t
{
	public const int k_iCallback = 335; //Field offset: 0x0
	public CSteamID m_steamIDClan; //Field offset: 0x0
	public int m_cOfficers; //Field offset: 0x8
	public byte m_bSuccess; //Field offset: 0xC

}

