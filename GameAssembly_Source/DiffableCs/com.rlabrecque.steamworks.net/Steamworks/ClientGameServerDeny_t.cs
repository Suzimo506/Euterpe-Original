namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct ClientGameServerDeny_t
{
	public const int k_iCallback = 113; //Field offset: 0x0
	public uint m_uAppID; //Field offset: 0x0
	public uint m_unGameServerIP; //Field offset: 0x4
	public ushort m_usGameServerPort; //Field offset: 0x8
	public ushort m_bSecure; //Field offset: 0xA
	public uint m_uReason; //Field offset: 0xC

}

