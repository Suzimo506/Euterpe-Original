namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct ReservationNotificationCallback_t
{
	public const int k_iCallback = 5303; //Field offset: 0x0
	public PartyBeaconID_t m_ulBeaconID; //Field offset: 0x0
	public CSteamID m_steamIDJoiner; //Field offset: 0x8

}

