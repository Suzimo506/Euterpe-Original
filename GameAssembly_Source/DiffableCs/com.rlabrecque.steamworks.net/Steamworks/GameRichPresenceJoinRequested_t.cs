namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct GameRichPresenceJoinRequested_t
{
	public const int k_iCallback = 337; //Field offset: 0x0
	public CSteamID m_steamIDFriend; //Field offset: 0x0
	private Byte[] m_rgchConnect_; //Field offset: 0x8

	public string m_rgchConnect
	{
		 get { } //Length: 134
		 set { } //Length: 24
	}

	public string get_m_rgchConnect() { }

	public void set_m_rgchConnect(string value) { }

}

