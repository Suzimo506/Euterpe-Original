namespace Antlr.Runtime;

public class UnwantedTokenException : MismatchedTokenException
{

	public override IToken UnexpectedToken
	{
		 get { } //Length: 8
	}

	public UnwantedTokenException() { }

	public UnwantedTokenException(string message) { }

	public UnwantedTokenException(string message, Exception innerException) { }

	public UnwantedTokenException(int expecting, IIntStream input) { }

	public UnwantedTokenException(int expecting, IIntStream input, IList<String> tokenNames) { }

	public UnwantedTokenException(string message, int expecting, IIntStream input, IList<String> tokenNames) { }

	public UnwantedTokenException(string message, int expecting, IIntStream input, IList<String> tokenNames, Exception innerException) { }

	protected UnwantedTokenException(SerializationInfo info, StreamingContext context) { }

	public override IToken get_UnexpectedToken() { }

	public virtual string ToString() { }

}

