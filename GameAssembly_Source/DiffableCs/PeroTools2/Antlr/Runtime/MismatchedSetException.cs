namespace Antlr.Runtime;

public class MismatchedSetException : RecognitionException
{
	private readonly BitSet _expecting; //Field offset: 0xB8

	public BitSet Expecting
	{
		 get { } //Length: 8
	}

	public MismatchedSetException() { }

	public MismatchedSetException(string message) { }

	public MismatchedSetException(string message, Exception innerException) { }

	public MismatchedSetException(BitSet expecting, IIntStream input) { }

	public MismatchedSetException(string message, BitSet expecting, IIntStream input) { }

	public MismatchedSetException(string message, BitSet expecting, IIntStream input, Exception innerException) { }

	protected MismatchedSetException(SerializationInfo info, StreamingContext context) { }

	public BitSet get_Expecting() { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

