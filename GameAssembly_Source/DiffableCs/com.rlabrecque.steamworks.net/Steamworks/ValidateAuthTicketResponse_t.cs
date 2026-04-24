namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct ValidateAuthTicketResponse_t
{
	public const int k_iCallback = 143; //Field offset: 0x0
	public CSteamID m_SteamID; //Field offset: 0x0
	public EAuthSessionResponse m_eAuthSessionResponse; //Field offset: 0x8
	public CSteamID m_OwnerSteamID; //Field offset: 0xC

}

