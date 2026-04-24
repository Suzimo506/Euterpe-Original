namespace Steamworks;

public static class SteamRemotePlay
{

	public static bool BGetSessionClientResolution(RemotePlaySessionID_t unSessionID, out int pnResolutionX, out int pnResolutionY) { }

	public static bool BSendRemotePlayTogetherInvite(CSteamID steamIDFriend) { }

	public static ESteamDeviceFormFactor GetSessionClientFormFactor(RemotePlaySessionID_t unSessionID) { }

	public static string GetSessionClientName(RemotePlaySessionID_t unSessionID) { }

	public static uint GetSessionCount() { }

	public static RemotePlaySessionID_t GetSessionID(int iSessionIndex) { }

	public static CSteamID GetSessionSteamID(RemotePlaySessionID_t unSessionID) { }

}

