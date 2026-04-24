namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct GSReputation_t
{
	public const int k_iCallback = 209; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public uint m_unReputationScore; //Field offset: 0x4
	public bool m_bBanned; //Field offset: 0x8
	public uint m_unBannedIP; //Field offset: 0xC
	public ushort m_usBannedPort; //Field offset: 0x10
	public ulong m_ulBannedGameID; //Field offset: 0x18
	public uint m_unBanExpires; //Field offset: 0x20

}

