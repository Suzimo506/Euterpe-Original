namespace Steamworks;

public struct ISteamNetworkingConnectionSignaling
{

	public void Release() { }

	public bool SendSignal(HSteamNetConnection hConn, ref SteamNetConnectionInfo_t info, IntPtr pMsg, int cbMsg) { }

}

