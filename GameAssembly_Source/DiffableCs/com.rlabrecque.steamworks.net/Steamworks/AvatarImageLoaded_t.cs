namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct AvatarImageLoaded_t
{
	public const int k_iCallback = 334; //Field offset: 0x0
	public CSteamID m_steamID; //Field offset: 0x0
	public int m_iImage; //Field offset: 0x8
	public int m_iWide; //Field offset: 0xC
	public int m_iTall; //Field offset: 0x10

}

