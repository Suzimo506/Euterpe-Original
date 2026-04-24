namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct WorkshopEULAStatus_t
{
	public const int k_iCallback = 3420; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public AppId_t m_nAppID; //Field offset: 0x4
	public uint m_unVersion; //Field offset: 0x8
	public RTime32 m_rtAction; //Field offset: 0xC
	public bool m_bAccepted; //Field offset: 0x10
	public bool m_bNeedsAction; //Field offset: 0x11

}

