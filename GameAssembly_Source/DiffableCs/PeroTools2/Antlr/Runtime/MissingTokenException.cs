namespace Antlr.Runtime;

public class MissingTokenException : MismatchedTokenException
{
	private readonly object _inserted; //Field offset: 0xC8

	public override int MissingType
	{
		 get { } //Length: 7
	}

	public MissingTokenException() { }

	public MissingTokenException(string message) { }

	public MissingTokenException(string message, Exception innerException) { }

	public MissingTokenException(int expecting, IIntStream input, object inserted) { }

	public MissingTokenException(int expecting, IIntStream input, object inserted, IList<String> tokenNames) { }

	public MissingTokenException(string message, int expecting, IIntStream input, object inserted, IList<String> tokenNames) { }

	public MissingTokenException(string message, int expecting, IIntStream input, object inserted, IList<String> tokenNames, Exception innerException) { }

	protected MissingTokenException(SerializationInfo info, StreamingContext context) { }

	public override int get_MissingType() { }

	public virtual string ToString() { }

}

