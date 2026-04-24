namespace System.Diagnostics.Tracing;

public class EventSourceException : Exception
{

	public EventSourceException() { }

	public EventSourceException(string message, Exception innerException) { }

	protected EventSourceException(SerializationInfo info, StreamingContext context) { }

	internal EventSourceException(Exception innerException) { }

}

