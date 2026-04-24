namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct RemoteStorageFileReadAsyncComplete_t
{
	public const int k_iCallback = 1332; //Field offset: 0x0
	public SteamAPICall_t m_hFileReadAsync; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x8
	public uint m_nOffset; //Field offset: 0xC
	public uint m_cubRead; //Field offset: 0x10

}

