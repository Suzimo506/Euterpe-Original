namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct SteamAPICallCompleted_t
{
	public const int k_iCallback = 703; //Field offset: 0x0
	public SteamAPICall_t m_hAsyncCall; //Field offset: 0x0
	public int m_iCallback; //Field offset: 0x8
	public uint m_cubParam; //Field offset: 0xC

}

