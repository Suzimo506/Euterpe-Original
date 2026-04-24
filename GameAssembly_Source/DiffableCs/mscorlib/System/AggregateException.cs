namespace System;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class AggregateException : Exception
{
	private ReadOnlyCollection<Exception> m_innerExceptions; //Field offset: 0x88

	private int InnerExceptionCount
	{
		private get { } //Length: 70
	}

	public ReadOnlyCollection<Exception> InnerExceptions
	{
		 get { } //Length: 8
	}

	public AggregateException() { }

	public AggregateException(IEnumerable<Exception> innerExceptions) { }

	public AggregateException(Exception[] innerExceptions) { }

	public AggregateException(string message, IEnumerable<Exception> innerExceptions) { }

	public AggregateException(string message, Exception[] innerExceptions) { }

	private AggregateException(string message, IList<Exception> innerExceptions) { }

	internal AggregateException(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	internal AggregateException(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	private AggregateException(string message, IList<ExceptionDispatchInfo> innerExceptionInfos) { }

	protected AggregateException(SerializationInfo info, StreamingContext context) { }

	public AggregateException Flatten() { }

	private int get_InnerExceptionCount() { }

	public ReadOnlyCollection<Exception> get_InnerExceptions() { }

	public virtual Exception GetBaseException() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

