namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct MicroTxnAuthorizationResponse_t
{
	public const int k_iCallback = 152; //Field offset: 0x0
	public uint m_unAppID; //Field offset: 0x0
	public ulong m_ulOrderID; //Field offset: 0x8
	public byte m_bAuthorized; //Field offset: 0x10

}

