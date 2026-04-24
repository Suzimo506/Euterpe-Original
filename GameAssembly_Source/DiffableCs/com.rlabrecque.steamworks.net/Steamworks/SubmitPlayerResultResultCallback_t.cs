namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct SubmitPlayerResultResultCallback_t
{
	public const int k_iCallback = 5214; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public ulong ullUniqueGameID; //Field offset: 0x8
	public CSteamID steamIDPlayer; //Field offset: 0x10

}

