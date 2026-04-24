namespace Steamworks;

public static class SteamNetworkingSockets
{

	public static EResult AcceptConnection(HSteamNetConnection hConn) { }

	public static bool CloseConnection(HSteamNetConnection hPeer, int nReason, string pszDebug, bool bEnableLinger) { }

	public static bool CloseListenSocket(HSteamListenSocket hSocket) { }

	public static HSteamNetConnection ConnectByIPAddress(ref SteamNetworkingIPAddr address, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	public static HSteamNetConnection ConnectP2P(ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	public static HSteamNetConnection ConnectP2PCustomSignaling(out ISteamNetworkingConnectionSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	public static HSteamNetConnection ConnectToHostedDedicatedServer(ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	public static HSteamListenSocket CreateHostedDedicatedServerListenSocket(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	public static HSteamListenSocket CreateListenSocketIP(ref SteamNetworkingIPAddr localAddress, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	public static HSteamListenSocket CreateListenSocketP2P(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	public static HSteamNetPollGroup CreatePollGroup() { }

	public static bool CreateSocketPair(out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2) { }

	public static bool DestroyPollGroup(HSteamNetPollGroup hPollGroup) { }

	public static int FindRelayAuthTicketForServer(ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket) { }

	public static EResult FlushMessagesOnConnection(HSteamNetConnection hConn) { }

	public static ESteamNetworkingAvailability GetAuthenticationStatus(out SteamNetAuthenticationStatus_t pDetails) { }

	public static bool GetCertificateRequest(out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg) { }

	public static bool GetConnectionInfo(HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo) { }

	public static bool GetConnectionName(HSteamNetConnection hPeer, out string pszName, int nMaxLen) { }

	public static long GetConnectionUserData(HSteamNetConnection hPeer) { }

	public static int GetDetailedConnectionStatus(HSteamNetConnection hConn, out string pszBuf, int cbBuf) { }

	public static EResult GetGameCoordinatorServerLogin(IntPtr pLoginInfo, out int pcbSignedBlob, IntPtr pBlob) { }

	public static EResult GetHostedDedicatedServerAddress(out SteamDatagramHostedAddress pRouting) { }

	public static SteamNetworkingPOPID GetHostedDedicatedServerPOPID() { }

	public static ushort GetHostedDedicatedServerPort() { }

	public static bool GetIdentity(out SteamNetworkingIdentity pIdentity) { }

	public static bool GetListenSocketAddress(HSteamListenSocket hSocket, out SteamNetworkingIPAddr address) { }

	public static bool GetQuickConnectionStatus(HSteamNetConnection hConn, out SteamNetworkingQuickConnectionStatus pStats) { }

	public static ESteamNetworkingAvailability InitAuthentication() { }

	public static bool ReceivedP2PCustomSignal(IntPtr pMsg, int cbMsg, out ISteamNetworkingSignalingRecvContext pContext) { }

	public static bool ReceivedRelayAuthTicket(IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket) { }

	public static int ReceiveMessagesOnConnection(HSteamNetConnection hConn, IntPtr[] ppOutMessages, int nMaxMessages) { }

	public static int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, IntPtr[] ppOutMessages, int nMaxMessages) { }

	public static void RunCallbacks() { }

	public static void SendMessages(int nMessages, SteamNetworkingMessage_t[] pMessages, Int64[] pOutMessageNumberOrResult) { }

	public static EResult SendMessageToConnection(HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber) { }

	public static bool SetCertificate(IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg) { }

	public static void SetConnectionName(HSteamNetConnection hPeer, string pszName) { }

	public static bool SetConnectionPollGroup(HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup) { }

	public static bool SetConnectionUserData(HSteamNetConnection hPeer, long nUserData) { }

}

