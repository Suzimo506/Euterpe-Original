namespace rail;

public class IRailFactoryImpl : RailObject, IRailFactory
{

	internal IRailFactoryImpl(IntPtr cPtr) { }

	protected virtual void Finalize() { }

	public override IRailAchievementHelper RailAchievementHelper() { }

	public override IRailApps RailApps() { }

	public override IRailAssetsHelper RailAssetsHelper() { }

	public override IRailBrowserHelper RailBrowserHelper() { }

	public override IRailDlcHelper RailDlcHelper() { }

	public override IRailFloatingWindow RailFloatingWindow() { }

	public override IRailFriends RailFriends() { }

	public override IRailGame RailGame() { }

	public override IRailGameServerHelper RailGameServerHelper() { }

	public override IRailGroupChatHelper RailGroupChatHelper() { }

	public override IRailHttpSessionHelper RailHttpSessionHelper() { }

	public override IRailIMEHelper RailIMETextInputHelper() { }

	public override IRailInGameCoin RailInGameCoin() { }

	public override IRailInGamePurchase RailInGamePurchase() { }

	public override IRailInGameStorePurchaseHelper RailInGameStorePurchaseHelper() { }

	public override IRailLeaderboardHelper RailLeaderboardHelper() { }

	public override IRailNetwork RailNetworkHelper() { }

	public override IRailPlayer RailPlayer() { }

	public override IRailRoomHelper RailRoomHelper() { }

	public override IRailScreenshotHelper RailScreenshotHelper() { }

	public override IRailSmallObjectServiceHelper RailSmallObjectServiceHelper() { }

	public override IRailStatisticHelper RailStatisticHelper() { }

	public override IRailStorageHelper RailStorageHelper() { }

	public override IRailSystemHelper RailSystemHelper() { }

	public override IRailTextInputHelper RailTextInputHelper() { }

	public override IRailUsersHelper RailUsersHelper() { }

	public override IRailUserSpaceHelper RailUserSpaceHelper() { }

	public override IRailUtils RailUtils() { }

	public override IRailVoiceHelper RailVoiceHelper() { }

	public override IRailZoneServerHelper RailZoneServerHelper() { }

}

