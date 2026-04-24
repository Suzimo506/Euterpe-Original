namespace System;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class PlatformNotSupportedException : NotSupportedException
{

	public PlatformNotSupportedException() { }

	public PlatformNotSupportedException(string message) { }

	protected PlatformNotSupportedException(SerializationInfo info, StreamingContext context) { }

}

