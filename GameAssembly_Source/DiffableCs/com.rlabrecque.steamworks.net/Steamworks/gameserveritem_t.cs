namespace Steamworks;

public class gameserveritem_t
{
	public servernetadr_t m_NetAdr; //Field offset: 0x10
	public int m_nPing; //Field offset: 0x18
	public bool m_bHadSuccessfulResponse; //Field offset: 0x1C
	public bool m_bDoNotRefresh; //Field offset: 0x1D
	private Byte[] m_szGameDir; //Field offset: 0x20
	private Byte[] m_szMap; //Field offset: 0x28
	private Byte[] m_szGameDescription; //Field offset: 0x30
	public uint m_nAppID; //Field offset: 0x38
	public int m_nPlayers; //Field offset: 0x3C
	public int m_nMaxPlayers; //Field offset: 0x40
	public int m_nBotPlayers; //Field offset: 0x44
	public bool m_bPassword; //Field offset: 0x48
	public bool m_bSecure; //Field offset: 0x49
	public uint m_ulTimeLastPlayed; //Field offset: 0x4C
	public int m_nServerVersion; //Field offset: 0x50
	private Byte[] m_szServerName; //Field offset: 0x58
	private Byte[] m_szGameTags; //Field offset: 0x60
	public CSteamID m_steamID; //Field offset: 0x68

	public gameserveritem_t() { }

	public string GetGameDescription() { }

	public string GetGameDir() { }

	public string GetGameTags() { }

	public string GetMap() { }

	public string GetServerName() { }

	public void SetGameDescription(string desc) { }

	public void SetGameDir(string dir) { }

	public void SetGameTags(string tags) { }

	public void SetMap(string map) { }

	public void SetServerName(string name) { }

}

