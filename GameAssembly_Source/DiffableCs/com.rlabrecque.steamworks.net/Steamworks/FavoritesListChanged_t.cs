namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct FavoritesListChanged_t
{
	public const int k_iCallback = 502; //Field offset: 0x0
	public uint m_nIP; //Field offset: 0x0
	public uint m_nQueryPort; //Field offset: 0x4
	public uint m_nConnPort; //Field offset: 0x8
	public uint m_nAppID; //Field offset: 0xC
	public uint m_nFlags; //Field offset: 0x10
	public bool m_bAdd; //Field offset: 0x14
	public AccountID_t m_unAccountId; //Field offset: 0x18

}

