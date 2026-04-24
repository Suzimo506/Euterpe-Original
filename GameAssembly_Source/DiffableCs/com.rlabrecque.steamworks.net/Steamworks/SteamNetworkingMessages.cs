namespace Steamworks;

public static class SteamNetworkingMessages
{

	public static bool AcceptSessionWithUser(ref SteamNetworkingIdentity identityRemote) { }

	public static bool CloseChannelWithUser(ref SteamNetworkingIdentity identityRemote, int nLocalChannel) { }

	public static bool CloseSessionWithUser(ref SteamNetworkingIdentity identityRemote) { }

	public static ESteamNetworkingConnectionState GetSessionConnectionInfo(ref SteamNetworkingIdentity identityRemote, out SteamNetConnectionInfo_t pConnectionInfo, out SteamNetworkingQuickConnectionStatus pQuickStatus) { }

	public static int ReceiveMessagesOnChannel(int nLocalChannel, IntPtr[] ppOutMessages, int nMaxMessages) { }

	public static EResult SendMessageToUser(ref SteamNetworkingIdentity identityRemote, IntPtr pubData, uint cubData, int nSendFlags, int nRemoteChannel) { }

}

