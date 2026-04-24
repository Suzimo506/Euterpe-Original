namespace Antlr.Runtime;

public class MismatchedTreeNodeException : RecognitionException
{
	private readonly int _expecting; //Field offset: 0xB8

	public int Expecting
	{
		 get { } //Length: 7
	}

	public MismatchedTreeNodeException() { }

	public MismatchedTreeNodeException(string message) { }

	public MismatchedTreeNodeException(string message, Exception innerException) { }

	public MismatchedTreeNodeException(int expecting, ITreeNodeStream input) { }

	public MismatchedTreeNodeException(string message, int expecting, ITreeNodeStream input) { }

	public MismatchedTreeNodeException(string message, int expecting, ITreeNodeStream input, Exception innerException) { }

	protected MismatchedTreeNodeException(SerializationInfo info, StreamingContext context) { }

	public int get_Expecting() { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

