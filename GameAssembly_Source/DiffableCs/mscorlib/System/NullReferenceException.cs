namespace System;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class NullReferenceException : SystemException
{

	public NullReferenceException() { }

	public NullReferenceException(string message) { }

	public NullReferenceException(string message, Exception innerException) { }

	protected NullReferenceException(SerializationInfo info, StreamingContext context) { }

}

