namespace Antlr.Runtime;

public class MismatchedNotSetException : MismatchedSetException
{

	public MismatchedNotSetException() { }

	public MismatchedNotSetException(string message) { }

	public MismatchedNotSetException(string message, Exception innerException) { }

	public MismatchedNotSetException(BitSet expecting, IIntStream input) { }

	public MismatchedNotSetException(string message, BitSet expecting, IIntStream input) { }

	public MismatchedNotSetException(string message, BitSet expecting, IIntStream input, Exception innerException) { }

	protected MismatchedNotSetException(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

