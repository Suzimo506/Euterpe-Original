namespace Steamworks;

public struct SteamNetworkingMessage_t
{
	public IntPtr m_pData; //Field offset: 0x0
	public int m_cbSize; //Field offset: 0x8
	public HSteamNetConnection m_conn; //Field offset: 0xC
	public SteamNetworkingIdentity m_identityPeer; //Field offset: 0x10
	public long m_nConnUserData; //Field offset: 0x20
	public SteamNetworkingMicroseconds m_usecTimeReceived; //Field offset: 0x28
	public long m_nMessageNumber; //Field offset: 0x30
	public IntPtr m_pfnFreeData; //Field offset: 0x38
	internal IntPtr m_pfnRelease; //Field offset: 0x40
	public int m_nChannel; //Field offset: 0x48
	public int m_nFlags; //Field offset: 0x4C
	public long m_nUserData; //Field offset: 0x50

	public static SteamNetworkingMessage_t FromIntPtr(IntPtr pointer) { }

	public static void Release(IntPtr pointer) { }

	public void Release() { }

}

