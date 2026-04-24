namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct GSClientGroupStatus_t
{
	public const int k_iCallback = 208; //Field offset: 0x0
	public CSteamID m_SteamIDUser; //Field offset: 0x0
	public CSteamID m_SteamIDGroup; //Field offset: 0x8
	public bool m_bMember; //Field offset: 0x10
	public bool m_bOfficer; //Field offset: 0x11

}

