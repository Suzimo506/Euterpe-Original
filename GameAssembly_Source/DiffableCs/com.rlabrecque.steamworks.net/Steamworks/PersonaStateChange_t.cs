namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct PersonaStateChange_t
{
	public const int k_iCallback = 304; //Field offset: 0x0
	public ulong m_ulSteamID; //Field offset: 0x0
	public EPersonaChange m_nChangeFlags; //Field offset: 0x8

}

