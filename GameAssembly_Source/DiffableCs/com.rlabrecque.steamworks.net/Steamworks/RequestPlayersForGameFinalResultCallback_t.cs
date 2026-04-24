namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct RequestPlayersForGameFinalResultCallback_t
{
	public const int k_iCallback = 5213; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public ulong m_ullSearchID; //Field offset: 0x8
	public ulong m_ullUniqueGameID; //Field offset: 0x10

}

