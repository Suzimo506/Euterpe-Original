namespace Antlr.Runtime;

public class MismatchedTokenException : RecognitionException
{
	private readonly int _expecting; //Field offset: 0xB8
	private readonly ReadOnlyCollection<String> _tokenNames; //Field offset: 0xC0

	public int Expecting
	{
		 get { } //Length: 7
	}

	public ReadOnlyCollection<String> TokenNames
	{
		 get { } //Length: 8
	}

	public MismatchedTokenException() { }

	public MismatchedTokenException(string message) { }

	public MismatchedTokenException(string message, Exception innerException) { }

	public MismatchedTokenException(int expecting, IIntStream input) { }

	public MismatchedTokenException(int expecting, IIntStream input, IList<String> tokenNames) { }

	public MismatchedTokenException(string message, int expecting, IIntStream input, IList<String> tokenNames) { }

	public MismatchedTokenException(string message, int expecting, IIntStream input, IList<String> tokenNames, Exception innerException) { }

	protected MismatchedTokenException(SerializationInfo info, StreamingContext context) { }

	public int get_Expecting() { }

	public ReadOnlyCollection<String> get_TokenNames() { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

