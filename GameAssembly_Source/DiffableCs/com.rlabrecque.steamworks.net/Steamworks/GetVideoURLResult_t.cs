namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct GetVideoURLResult_t
{
	public const int k_iCallback = 4611; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public AppId_t m_unVideoAppID; //Field offset: 0x4
	private Byte[] m_rgchURL_; //Field offset: 0x8

	public string m_rgchURL
	{
		 get { } //Length: 134
		 set { } //Length: 24
	}

	public string get_m_rgchURL() { }

	public void set_m_rgchURL(string value) { }

}

