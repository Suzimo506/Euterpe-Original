namespace DG.Tweening.Core;

public static class Debugger
{
	private static int _logPriority; //Field offset: 0x67E90
	private const string _LogPrefix = "<color=#0099bc><b>DOTWEEN ► </b></colo"; //Field offset: 0x67F0C

	public static int logPriority
	{
		 get { } //Length: 52
	}

	public static int get_logPriority() { }

	public static void Log(object message) { }

	public static void LogAddActiveTweenError(string errorInfo, Tween t) { }

	public static void LogError(object message) { }

	public static void LogInvalidTween(Tween t) { }

	public static void LogMissingMaterialProperty(string propertyName) { }

	public static void LogMissingMaterialProperty(int propertyId) { }

	public static void LogNestedTween(Tween t) { }

	public static void LogNonPathTween(Tween t) { }

	public static void LogNullTween(Tween t) { }

	public static void LogRemoveActiveTweenError(string errorInfo, Tween t) { }

	public static void LogReport(object message) { }

	public static void LogSafeModeReport(object message) { }

	public static void LogWarning(object message, Tween t = null) { }

	public static void SetLogPriority(LogBehaviour logBehaviour) { }

}

