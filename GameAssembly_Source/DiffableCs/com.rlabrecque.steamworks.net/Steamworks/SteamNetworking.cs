namespace Steamworks;

public static class SteamNetworking
{

	public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote) { }

	public static bool AllowP2PPacketRelay(bool bAllow) { }

	public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel) { }

	public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote) { }

	public static SNetSocket_t CreateConnectionSocket(SteamIPAddress_t nIP, ushort nPort, int nTimeoutSec) { }

	public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, SteamIPAddress_t nIP, ushort nPort, bool bAllowUseOfPacketRelay) { }

	public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay) { }

	public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd) { }

	public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd) { }

	public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out SteamIPAddress_t pnIP, out ushort pnPort) { }

	public static int GetMaxPacketSize(SNetSocket_t hSocket) { }

	public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState) { }

	public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket) { }

	public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out SteamIPAddress_t punIPRemote, out ushort punPortRemote) { }

	public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket) { }

	public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize) { }

	public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0) { }

	public static bool ReadP2PPacket(Byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0) { }

	public static bool RetrieveData(SNetListenSocket_t hListenSocket, Byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket) { }

	public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, Byte[] pubDest, uint cubDest, out uint pcubMsgSize) { }

	public static bool SendDataOnSocket(SNetSocket_t hSocket, Byte[] pubData, uint cubData, bool bReliable) { }

	public static bool SendP2PPacket(CSteamID steamIDRemote, Byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0) { }

}

