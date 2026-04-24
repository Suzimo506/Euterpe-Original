namespace NexPlugin;

public static class Common
{
	[Flags]
	internal enum DispachFlag
	{
		ContinueWhenEmpty = 1,
		DispatchKeepAliveOnly = 2,
	}

	internal enum NotificationEvents
	{
		ParticipationEvent = 3,
		OwnershipChangeEvent = 4,
		GatheringUnregistered = 109,
		HostChangeEvent = 110,
		GameNotificationLogout = 111,
		SubscriptionEvent = 112,
		GameServerMaintenance = 113,
		MaintenanceAnnouncement = 114,
		RoundStarted = 116,
		FirstRoundReportReceived = 117,
		RoundSummarized = 118,
		MatchmakeSystemConfigurationNotification = 119,
		MatchmakeSessionSystemPasswordSet = 120,
		MatchmakeSessionSystemPasswordClear = 121,
		AddedToGathering = 122,
		UserStatusUpdatedEvent = 128,
	}

	internal enum ParticipationEvents
	{
		Participate = 1,
		Disconnect = 7,
		EndParticipation = 8,
	}

	[Flags]
	internal enum ThreadMode
	{
		ThreadModeSafeTransportBuffer = 1,
		ThreadModeUnsafeTransportBuffer = 2,
	}

	public const uint INFINITE_TIME_INTERVAL = 2147483647; //Field offset: 0x0

}

