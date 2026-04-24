namespace rail;

public class rail_api
{
	public static readonly int USE_MANUAL_ALLOC; //Field offset: 0x0
	public static readonly int RAIL_SDK_PACKING; //Field offset: 0x4

	public static uint kRailMaxGameDefinePlayingStateValue
	{
		 get { } //Length: 72
	}

	public static uint kRailMaxQueryPlayedWithFriendsTimeLimit
	{
		 get { } //Length: 72
	}

	public static uint kRailRoomDataKeyValuePairsLimit
	{
		 get { } //Length: 72
	}

	public static uint kRailRoomDefaultMaxMemberNumber
	{
		 get { } //Length: 72
	}

	private static rail_api() { }

	public rail_api() { }

	public static uint get_kRailMaxGameDefinePlayingStateValue() { }

	public static uint get_kRailMaxQueryPlayedWithFriendsTimeLimit() { }

	public static uint get_kRailRoomDataKeyValuePairsLimit() { }

	public static uint get_kRailRoomDefaultMaxMemberNumber() { }

	public static IRailFactory RailFactory() { }

	public static void RailFinalize() { }

	public static void RailFireEvents() { }

	public static void RailGetSdkVersion(out string version, out string description) { }

	public static bool RailInitialize() { }

	public static bool RailNeedRestartAppForCheckingEnvironment(RailGameID game_id, int argc, String[] argv) { }

}

