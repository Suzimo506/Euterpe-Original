namespace Steamworks;

public static class GameServer
{

	public static bool BSecure() { }

	public static HSteamPipe GetHSteamPipe() { }

	public static HSteamUser GetHSteamUser() { }

	public static CSteamID GetSteamID() { }

	public static bool Init(uint unIP, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString) { }

	public static void ReleaseCurrentThreadMemory() { }

	public static void RunCallbacks() { }

	public static void Shutdown() { }

}

