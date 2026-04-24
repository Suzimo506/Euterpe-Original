namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct HTTPRequestDataReceived_t
{
	public const int k_iCallback = 2103; //Field offset: 0x0
	public HTTPRequestHandle m_hRequest; //Field offset: 0x0
	public ulong m_ulContextValue; //Field offset: 0x8
	public uint m_cOffset; //Field offset: 0x10
	public uint m_cBytesReceived; //Field offset: 0x14

}

