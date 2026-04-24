namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal static class Logger
{
	private const int screenLogLength = 50; //Field offset: 0x0
	private static List<String> __screenLog; //Field offset: 0x0
	private static GUIText _guiText; //Field offset: 0x8
	private static bool _logToScreen; //Field offset: 0x10

	private static LogLevelFlags logLevel
	{
		private get { } //Length: 393
	}

	public static bool logToScreen
	{
		 get { } //Length: 54
		 set { } //Length: 356
	}

	private static List<String> screenLog
	{
		private get { } //Length: 126
	}

	private static LogLevelFlags get_logLevel() { }

	public static bool get_logToScreen() { }

	private static List<String> get_screenLog() { }

	private static bool IsLoggingAllowed(LogLevel logLevel) { }

	public static void Log(object msg, bool requiredThreadSafety) { }

	public static void Log(object msg) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void Log_VCTest(object o) { }

	public static void LogEditor(object msg) { }

	public static void LogEditor(object msg, bool requiredThreadSafety) { }

	public static void LogError(object msg, bool requiredThreadSafety) { }

	public static void LogError(object msg) { }

	public static void LogErrorEditor(object msg, bool requiredThreadSafety) { }

	public static void LogErrorEditor(object msg) { }

	private static void LogErrorNow(object msg, bool requireThreadSafety) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void LogInit(object o) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void LogInitError(object o) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void LogInitWarning(object o) { }

	private static void LogNow(object msg, bool requireThreadSafety) { }

	private static void LogToScreen(object msg) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void LogUpdate(object o) { }

	public static void LogWarning(object msg, bool requiredThreadSafety) { }

	public static void LogWarning(object msg) { }

	public static void LogWarningEditor(object msg, bool requiredThreadSafety) { }

	public static void LogWarningEditor(object msg) { }

	private static void LogWarningNow(object msg, bool requireThreadSafety) { }

	public static void set_logToScreen(bool value) { }

}

