namespace Antlr3.Runtime.PCL.Output;

public static class OutputStreamHost
{
	private static double _previous_progress; //Field offset: 0x0
	private static IList<IOutputStream> _output_streams; //Field offset: 0x8

	public static IOutputStream Error
	{
		 get { } //Length: 67
	}

	public static IOutputStream Out
	{
		 get { } //Length: 67
	}

	public static IOutputStream get_Error() { }

	public static IOutputStream get_Out() { }

	private static void InitializeIfNeeded() { }

	public static void RegisterOutputStream(IOutputStream output_stream) { }

	public static void ReportProgress(double progress, string key, string message) { }

	public static void ReportProgress(long current, long total, string key, string message) { }

	public static void UnRegisterOutputStream(IOutputStream output_stream) { }

	public static void Write(string text) { }

	public static void Write(string format, Object[] arg) { }

	public static void WriteLine() { }

	public static void WriteLine(string text) { }

	public static void WriteLine(string format, Object[] arg) { }

}

