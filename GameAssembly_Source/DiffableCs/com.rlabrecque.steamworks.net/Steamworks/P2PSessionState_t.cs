namespace Steamworks;

public struct P2PSessionState_t
{
	public byte m_bConnectionActive; //Field offset: 0x0
	public byte m_bConnecting; //Field offset: 0x1
	public byte m_eP2PSessionError; //Field offset: 0x2
	public byte m_bUsingRelay; //Field offset: 0x3
	public int m_nBytesQueuedForSend; //Field offset: 0x4
	public int m_nPacketsQueuedForSend; //Field offset: 0x8
	public uint m_nRemoteIP; //Field offset: 0xC
	public ushort m_nRemotePort; //Field offset: 0x10

}

