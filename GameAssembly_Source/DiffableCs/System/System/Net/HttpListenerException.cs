namespace System.Net;

public class HttpListenerException : Win32Exception
{

	public HttpListenerException() { }

	public HttpListenerException(int errorCode, string message) { }

	protected HttpListenerException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

