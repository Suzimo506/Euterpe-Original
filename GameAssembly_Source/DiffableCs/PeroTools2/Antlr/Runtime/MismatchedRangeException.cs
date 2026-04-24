namespace Antlr.Runtime;

public class MismatchedRangeException : RecognitionException
{
	private readonly int _a; //Field offset: 0xB8
	private readonly int _b; //Field offset: 0xBC

	public int A
	{
		 get { } //Length: 7
	}

	public int B
	{
		 get { } //Length: 7
	}

	public MismatchedRangeException() { }

	public MismatchedRangeException(string message) { }

	public MismatchedRangeException(string message, Exception innerException) { }

	public MismatchedRangeException(int a, int b, IIntStream input) { }

	public MismatchedRangeException(string message, int a, int b, IIntStream input) { }

	public MismatchedRangeException(string message, int a, int b, IIntStream input, Exception innerException) { }

	protected MismatchedRangeException(SerializationInfo info, StreamingContext context) { }

	public int get_A() { }

	public int get_B() { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

