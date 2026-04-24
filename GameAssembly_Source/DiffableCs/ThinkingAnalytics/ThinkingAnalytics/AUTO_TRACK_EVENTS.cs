namespace ThinkingAnalytics;

[Flags]
public enum AUTO_TRACK_EVENTS
{
	NONE = 0,
	APP_START = 1,
	APP_END = 2,
	APP_CRASH = 16,
	APP_INSTALL = 32,
	ALL = 51,
}

