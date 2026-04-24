namespace Sirenix.Serialization;

public interface ILogger
{

	public void LogError(string error) { }

	public void LogException(Exception exception) { }

	public void LogWarning(string warning) { }

}

