namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct FriendsIsFollowing_t
{
	public const int k_iCallback = 345; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public CSteamID m_steamID; //Field offset: 0x4
	public bool m_bIsFollowing; //Field offset: 0xC

}

