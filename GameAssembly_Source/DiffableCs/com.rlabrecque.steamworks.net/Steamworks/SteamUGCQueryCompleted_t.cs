namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct SteamUGCQueryCompleted_t
{
	public const int k_iCallback = 3401; //Field offset: 0x0
	public UGCQueryHandle_t m_handle; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x8
	public uint m_unNumResultsReturned; //Field offset: 0xC
	public uint m_unTotalMatchingResults; //Field offset: 0x10
	public bool m_bCachedData; //Field offset: 0x14
	private Byte[] m_rgchNextCursor_; //Field offset: 0x18

	public string m_rgchNextCursor
	{
		 get { } //Length: 11
		 set { } //Length: 24
	}

	public string get_m_rgchNextCursor() { }

	public void set_m_rgchNextCursor(string value) { }

}

