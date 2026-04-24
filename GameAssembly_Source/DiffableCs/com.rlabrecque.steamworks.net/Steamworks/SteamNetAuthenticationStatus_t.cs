namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct SteamNetAuthenticationStatus_t
{
	public const int k_iCallback = 1222; //Field offset: 0x0
	public ESteamNetworkingAvailability m_eAvail; //Field offset: 0x0
	private Byte[] m_debugMsg_; //Field offset: 0x8

	public string m_debugMsg
	{
		 get { } //Length: 11
		 set { } //Length: 24
	}

	public string get_m_debugMsg() { }

	public void set_m_debugMsg(string value) { }

}

