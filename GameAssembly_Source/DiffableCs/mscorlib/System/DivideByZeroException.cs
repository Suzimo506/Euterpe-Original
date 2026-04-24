namespace System;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class DivideByZeroException : ArithmeticException
{

	public DivideByZeroException() { }

	public DivideByZeroException(string message) { }

	public DivideByZeroException(string message, Exception innerException) { }

	protected DivideByZeroException(SerializationInfo info, StreamingContext context) { }

}

