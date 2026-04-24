namespace Steamworks;

internal static class CSteamAPIContext
{
	private static IntPtr m_pSteamClient; //Field offset: 0x0
	private static IntPtr m_pSteamUser; //Field offset: 0x8
	private static IntPtr m_pSteamFriends; //Field offset: 0x10
	private static IntPtr m_pSteamUtils; //Field offset: 0x18
	private static IntPtr m_pSteamMatchmaking; //Field offset: 0x20
	private static IntPtr m_pSteamUserStats; //Field offset: 0x28
	private static IntPtr m_pSteamApps; //Field offset: 0x30
	private static IntPtr m_pSteamMatchmakingServers; //Field offset: 0x38
	private static IntPtr m_pSteamNetworking; //Field offset: 0x40
	private static IntPtr m_pSteamRemoteStorage; //Field offset: 0x48
	private static IntPtr m_pSteamScreenshots; //Field offset: 0x50
	private static IntPtr m_pSteamGameSearch; //Field offset: 0x58
	private static IntPtr m_pSteamHTTP; //Field offset: 0x60
	private static IntPtr m_pController; //Field offset: 0x68
	private static IntPtr m_pSteamUGC; //Field offset: 0x70
	private static IntPtr m_pSteamAppList; //Field offset: 0x78
	private static IntPtr m_pSteamMusic; //Field offset: 0x80
	private static IntPtr m_pSteamMusicRemote; //Field offset: 0x88
	private static IntPtr m_pSteamHTMLSurface; //Field offset: 0x90
	private static IntPtr m_pSteamInventory; //Field offset: 0x98
	private static IntPtr m_pSteamVideo; //Field offset: 0xA0
	private static IntPtr m_pSteamParentalSettings; //Field offset: 0xA8
	private static IntPtr m_pSteamInput; //Field offset: 0xB0
	private static IntPtr m_pSteamParties; //Field offset: 0xB8
	private static IntPtr m_pSteamRemotePlay; //Field offset: 0xC0
	private static IntPtr m_pSteamNetworkingUtils; //Field offset: 0xC8
	private static IntPtr m_pSteamNetworkingSockets; //Field offset: 0xD0
	private static IntPtr m_pSteamNetworkingMessages; //Field offset: 0xD8

	internal static void Clear() { }

	internal static IntPtr GetSteamAppList() { }

	internal static IntPtr GetSteamApps() { }

	internal static IntPtr GetSteamClient() { }

	internal static IntPtr GetSteamController() { }

	internal static IntPtr GetSteamFriends() { }

	internal static IntPtr GetSteamGameSearch() { }

	internal static IntPtr GetSteamHTMLSurface() { }

	internal static IntPtr GetSteamHTTP() { }

	internal static IntPtr GetSteamInput() { }

	internal static IntPtr GetSteamInventory() { }

	internal static IntPtr GetSteamMatchmaking() { }

	internal static IntPtr GetSteamMatchmakingServers() { }

	internal static IntPtr GetSteamMusic() { }

	internal static IntPtr GetSteamMusicRemote() { }

	internal static IntPtr GetSteamNetworking() { }

	internal static IntPtr GetSteamNetworkingMessages() { }

	internal static IntPtr GetSteamNetworkingSockets() { }

	internal static IntPtr GetSteamNetworkingUtils() { }

	internal static IntPtr GetSteamParentalSettings() { }

	internal static IntPtr GetSteamParties() { }

	internal static IntPtr GetSteamRemotePlay() { }

	internal static IntPtr GetSteamRemoteStorage() { }

	internal static IntPtr GetSteamScreenshots() { }

	internal static IntPtr GetSteamUGC() { }

	internal static IntPtr GetSteamUser() { }

	internal static IntPtr GetSteamUserStats() { }

	internal static IntPtr GetSteamUtils() { }

	internal static IntPtr GetSteamVideo() { }

	internal static bool Init() { }

}

