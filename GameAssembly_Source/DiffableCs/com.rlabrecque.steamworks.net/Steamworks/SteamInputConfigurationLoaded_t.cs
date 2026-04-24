namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct SteamInputConfigurationLoaded_t
{
	public const int k_iCallback = 2803; //Field offset: 0x0
	public AppId_t m_unAppID; //Field offset: 0x0
	public InputHandle_t m_ulDeviceHandle; //Field offset: 0x8
	public CSteamID m_ulMappingCreator; //Field offset: 0x10
	public uint m_unMajorRevision; //Field offset: 0x18
	public uint m_unMinorRevision; //Field offset: 0x1C
	public bool m_bUsesSteamInputAPI; //Field offset: 0x20
	public bool m_bUsesGamepadAPI; //Field offset: 0x21

}

