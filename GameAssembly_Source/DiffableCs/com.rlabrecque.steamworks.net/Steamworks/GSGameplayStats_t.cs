namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct GSGameplayStats_t
{
	public const int k_iCallback = 207; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public int m_nRank; //Field offset: 0x4
	public uint m_unTotalConnects; //Field offset: 0x8
	public uint m_unTotalMinutesPlayed; //Field offset: 0xC

}

