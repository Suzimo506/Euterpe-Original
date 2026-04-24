namespace Steamworks;

public struct SteamNetworkingQuickConnectionStatus
{
	public ESteamNetworkingConnectionState m_eState; //Field offset: 0x0
	public int m_nPing; //Field offset: 0x4
	public float m_flConnectionQualityLocal; //Field offset: 0x8
	public float m_flConnectionQualityRemote; //Field offset: 0xC
	public float m_flOutPacketsPerSec; //Field offset: 0x10
	public float m_flOutBytesPerSec; //Field offset: 0x14
	public float m_flInPacketsPerSec; //Field offset: 0x18
	public float m_flInBytesPerSec; //Field offset: 0x1C
	public int m_nSendRateBytesPerSecond; //Field offset: 0x20
	public int m_cbPendingUnreliable; //Field offset: 0x24
	public int m_cbPendingReliable; //Field offset: 0x28
	public int m_cbSentUnackedReliable; //Field offset: 0x2C
	public SteamNetworkingMicroseconds m_usecQueueTime; //Field offset: 0x30
	public UInt32[] reserved; //Field offset: 0x38

}

