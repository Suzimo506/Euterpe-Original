namespace Steamworks;

public struct ISteamNetworkingSignalingRecvContext
{

	public IntPtr OnConnectRequest(HSteamNetConnection hConn, ref SteamNetworkingIdentity identityPeer, int nLocalVirtualPort) { }

	public void SendRejectionSignal(ref SteamNetworkingIdentity identityPeer, IntPtr pMsg, int cbMsg) { }

}

