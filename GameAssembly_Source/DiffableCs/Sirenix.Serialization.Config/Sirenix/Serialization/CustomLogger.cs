namespace Sirenix.Serialization;

public class CustomLogger : ILogger
{
	private Action<String> logWarningDelegate; //Field offset: 0x10
	private Action<String> logErrorDelegate; //Field offset: 0x18
	private Action<Exception> logExceptionDelegate; //Field offset: 0x20

	public CustomLogger(Action<String> logWarningDelegate, Action<String> logErrorDelegate, Action<Exception> logExceptionDelegate) { }

	public override void LogError(string error) { }

	public override void LogException(Exception exception) { }

	public override void LogWarning(string warning) { }

}

