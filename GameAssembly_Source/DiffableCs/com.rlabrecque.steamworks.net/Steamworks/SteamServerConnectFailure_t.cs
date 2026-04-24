namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct SteamServerConnectFailure_t
{
	public const int k_iCallback = 102; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public bool m_bStillRetrying; //Field offset: 0x4

}

