namespace System.Runtime.InteropServices;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ExternalException : SystemException
{

	public ExternalException() { }

	public ExternalException(string message) { }

	public ExternalException(string message, Exception inner) { }

	public ExternalException(string message, int errorCode) { }

	protected ExternalException(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

