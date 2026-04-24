namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct TimedTrialStatus_t
{
	public const int k_iCallback = 1030; //Field offset: 0x0
	public AppId_t m_unAppID; //Field offset: 0x0
	public bool m_bIsOffline; //Field offset: 0x4
	public uint m_unSecondsAllowed; //Field offset: 0x8
	public uint m_unSecondsPlayed; //Field offset: 0xC

}

