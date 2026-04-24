namespace ThinkingAnalytics.TAException;

public class ThinkingSDKExceptionHandler
{
	public static bool IsQuitWhenException; //Field offset: 0x0
	public static bool IsRegistered; //Field offset: 0x1
	private static IAutoTrackEventCallback mEventCallback; //Field offset: 0x8
	private static Dictionary<String, Object> mProperties; //Field offset: 0x10

	private static void _LogHandler(string logString, string stackTrace, LogType type) { }

	private static void _UncaughtExceptionHandler(object sender, UnhandledExceptionEventArgs args) { }

	private static Dictionary<String, Object> MergeProperties(Dictionary<String, Object> properties) { }

	public static void RegisterTAExceptionHandler(IAutoTrackEventCallback eventCallback) { }

	public static void RegisterTAExceptionHandler(Dictionary<String, Object> properties) { }

	public static void SetAutoTrackProperties(Dictionary<String, Object> properties) { }

}

