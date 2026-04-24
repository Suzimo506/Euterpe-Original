namespace Steamworks;

public static class SteamNetworkingUtils
{

	public static IntPtr AllocateMessage(int cbAllocateBuffer) { }

	public static bool CheckPingDataUpToDate(float flMaxAgeSeconds) { }

	public static void ConvertPingLocationToString(ref SteamNetworkPingLocation_t location, out string pszBuf, int cchBufSize) { }

	public static int EstimatePingTimeBetweenTwoLocations(ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2) { }

	public static int EstimatePingTimeFromLocalHost(ref SteamNetworkPingLocation_t remoteLocation) { }

	public static ESteamNetworkingGetConfigValueResult GetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, ref ulong cbResult) { }

	public static bool GetConfigValueInfo(ESteamNetworkingConfigValue eValue, IntPtr pOutName, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope, out ESteamNetworkingConfigValue pOutNextValue) { }

	public static int GetDirectPingToPOP(SteamNetworkingPOPID popID) { }

	public static ESteamNetworkingConfigValue GetFirstConfigValue() { }

	public static float GetLocalPingLocation(out SteamNetworkPingLocation_t result) { }

	public static SteamNetworkingMicroseconds GetLocalTimestamp() { }

	public static int GetPingToDataCenter(SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP) { }

	public static int GetPOPCount() { }

	public static int GetPOPList(out SteamNetworkingPOPID list, int nListSz) { }

	public static ESteamNetworkingAvailability GetRelayNetworkStatus(out SteamRelayNetworkStatus_t pDetails) { }

	public static void InitRelayNetworkAccess() { }

	public static bool ParsePingLocationString(string pszString, out SteamNetworkPingLocation_t result) { }

	public static bool SetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg) { }

	public static void SetDebugOutputFunction(ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc) { }

	public static bool SteamNetworkingIdentity_ParseString(out SteamNetworkingIdentity pIdentity, string pszStr) { }

	public static void SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity identity, out string buf, uint cbBuf) { }

	public static bool SteamNetworkingIPAddr_ParseString(out SteamNetworkingIPAddr pAddr, string pszStr) { }

	public static void SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr addr, out string buf, uint cbBuf, bool bWithPort) { }

}

