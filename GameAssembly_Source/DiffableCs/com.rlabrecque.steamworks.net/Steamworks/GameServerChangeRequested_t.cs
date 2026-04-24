namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct GameServerChangeRequested_t
{
	public const int k_iCallback = 332; //Field offset: 0x0
	private Byte[] m_rgchServer_; //Field offset: 0x0
	private Byte[] m_rgchPassword_; //Field offset: 0x8

	public string m_rgchPassword
	{
		 get { } //Length: 134
		 set { } //Length: 22
	}

	public string m_rgchServer
	{
		 get { } //Length: 134
		 set { } //Length: 21
	}

	public string get_m_rgchPassword() { }

	public string get_m_rgchServer() { }

	public void set_m_rgchPassword(string value) { }

	public void set_m_rgchServer(string value) { }

}

