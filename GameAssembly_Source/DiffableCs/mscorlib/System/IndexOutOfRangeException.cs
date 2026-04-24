namespace System;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class IndexOutOfRangeException : SystemException
{

	public IndexOutOfRangeException() { }

	public IndexOutOfRangeException(string message) { }

	public IndexOutOfRangeException(string message, Exception innerException) { }

	internal IndexOutOfRangeException(SerializationInfo info, StreamingContext context) { }

}

