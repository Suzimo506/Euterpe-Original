namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct FriendsGetFollowerCount_t
{
	public const int k_iCallback = 344; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public CSteamID m_steamID; //Field offset: 0x4
	public int m_nCount; //Field offset: 0xC

}

