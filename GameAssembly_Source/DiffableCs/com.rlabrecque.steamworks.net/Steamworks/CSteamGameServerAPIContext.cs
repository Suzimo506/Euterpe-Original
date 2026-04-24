namespace Steamworks;

internal static class CSteamGameServerAPIContext
{
	private static IntPtr m_pSteamClient; //Field offset: 0x0
	private static IntPtr m_pSteamGameServer; //Field offset: 0x8
	private static IntPtr m_pSteamUtils; //Field offset: 0x10
	private static IntPtr m_pSteamNetworking; //Field offset: 0x18
	private static IntPtr m_pSteamGameServerStats; //Field offset: 0x20
	private static IntPtr m_pSteamHTTP; //Field offset: 0x28
	private static IntPtr m_pSteamInventory; //Field offset: 0x30
	private static IntPtr m_pSteamUGC; //Field offset: 0x38
	private static IntPtr m_pSteamNetworkingUtils; //Field offset: 0x40
	private static IntPtr m_pSteamNetworkingSockets; //Field offset: 0x48
	private static IntPtr m_pSteamNetworkingMessages; //Field offset: 0x50

	internal static void Clear() { }

	internal static IntPtr GetSteamClient() { }

	internal static IntPtr GetSteamGameServer() { }

	internal static IntPtr GetSteamGameServerStats() { }

	internal static IntPtr GetSteamHTTP() { }

	internal static IntPtr GetSteamInventory() { }

	internal static IntPtr GetSteamNetworking() { }

	internal static IntPtr GetSteamNetworkingMessages() { }

	internal static IntPtr GetSteamNetworkingSockets() { }

	internal static IntPtr GetSteamNetworkingUtils() { }

	internal static IntPtr GetSteamUGC() { }

	internal static IntPtr GetSteamUtils() { }

	internal static bool Init() { }

}

