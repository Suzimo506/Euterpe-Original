namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct SteamRelayNetworkStatus_t
{
	public const int k_iCallback = 1281; //Field offset: 0x0
	public ESteamNetworkingAvailability m_eAvail; //Field offset: 0x0
	public int m_bPingMeasurementInProgress; //Field offset: 0x4
	public ESteamNetworkingAvailability m_eAvailNetworkConfig; //Field offset: 0x8
	public ESteamNetworkingAvailability m_eAvailAnyRelay; //Field offset: 0xC
	private Byte[] m_debugMsg_; //Field offset: 0x10

	public string m_debugMsg
	{
		 get { } //Length: 11
		 set { } //Length: 24
	}

	public string get_m_debugMsg() { }

	public void set_m_debugMsg(string value) { }

}

