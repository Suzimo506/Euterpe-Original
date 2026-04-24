namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct HTTPRequestCompleted_t
{
	public const int k_iCallback = 2101; //Field offset: 0x0
	public HTTPRequestHandle m_hRequest; //Field offset: 0x0
	public ulong m_ulContextValue; //Field offset: 0x8
	public bool m_bRequestSuccessful; //Field offset: 0x10
	public EHTTPStatusCode m_eStatusCode; //Field offset: 0x14
	public uint m_unBodySize; //Field offset: 0x18

}

