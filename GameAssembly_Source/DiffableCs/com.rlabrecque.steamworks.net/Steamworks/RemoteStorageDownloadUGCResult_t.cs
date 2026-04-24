namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct RemoteStorageDownloadUGCResult_t
{
	public const int k_iCallback = 1317; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public UGCHandle_t m_hFile; //Field offset: 0x8
	public AppId_t m_nAppID; //Field offset: 0x10
	public int m_nSizeInBytes; //Field offset: 0x14
	private Byte[] m_pchFileName_; //Field offset: 0x18
	public ulong m_ulSteamIDOwner; //Field offset: 0x20

	public string m_pchFileName
	{
		 get { } //Length: 11
		 set { } //Length: 24
	}

	public string get_m_pchFileName() { }

	public void set_m_pchFileName(string value) { }

}

