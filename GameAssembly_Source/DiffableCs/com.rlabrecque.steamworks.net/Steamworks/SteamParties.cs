namespace Steamworks;

public static class SteamParties
{

	public static void CancelReservation(PartyBeaconID_t ulBeacon, CSteamID steamIDUser) { }

	public static SteamAPICall_t ChangeNumOpenSlots(PartyBeaconID_t ulBeacon, uint unOpenSlots) { }

	public static SteamAPICall_t CreateBeacon(uint unOpenSlots, ref SteamPartyBeaconLocation_t pBeaconLocation, string pchConnectString, string pchMetadata) { }

	public static bool DestroyBeacon(PartyBeaconID_t ulBeacon) { }

	public static bool GetAvailableBeaconLocations(SteamPartyBeaconLocation_t[] pLocationList, uint uMaxNumLocations) { }

	public static PartyBeaconID_t GetBeaconByIndex(uint unIndex) { }

	public static bool GetBeaconDetails(PartyBeaconID_t ulBeaconID, out CSteamID pSteamIDBeaconOwner, out SteamPartyBeaconLocation_t pLocation, out string pchMetadata, int cchMetadata) { }

	public static bool GetBeaconLocationData(SteamPartyBeaconLocation_t BeaconLocation, ESteamPartyBeaconLocationData eData, out string pchDataStringOut, int cchDataStringOut) { }

	public static uint GetNumActiveBeacons() { }

	public static bool GetNumAvailableBeaconLocations(out uint puNumLocations) { }

	public static SteamAPICall_t JoinParty(PartyBeaconID_t ulBeaconID) { }

	public static void OnReservationCompleted(PartyBeaconID_t ulBeacon, CSteamID steamIDUser) { }

}

