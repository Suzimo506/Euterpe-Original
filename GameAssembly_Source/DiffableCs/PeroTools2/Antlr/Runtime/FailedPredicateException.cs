namespace Antlr.Runtime;

public class FailedPredicateException : RecognitionException
{
	private readonly string _ruleName; //Field offset: 0xB8
	private readonly string _predicateText; //Field offset: 0xC0

	public string PredicateText
	{
		 get { } //Length: 8
	}

	public string RuleName
	{
		 get { } //Length: 8
	}

	public FailedPredicateException() { }

	public FailedPredicateException(string message) { }

	public FailedPredicateException(string message, Exception innerException) { }

	public FailedPredicateException(IIntStream input, string ruleName, string predicateText) { }

	public FailedPredicateException(string message, IIntStream input, string ruleName, string predicateText) { }

	public FailedPredicateException(string message, IIntStream input, string ruleName, string predicateText, Exception innerException) { }

	protected FailedPredicateException(SerializationInfo info, StreamingContext context) { }

	public string get_PredicateText() { }

	public string get_RuleName() { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

