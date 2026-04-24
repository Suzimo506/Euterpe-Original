namespace Antlr.Runtime;

public class EarlyExitException : RecognitionException
{
	private readonly int _decisionNumber; //Field offset: 0xB8

	public int DecisionNumber
	{
		 get { } //Length: 7
	}

	public EarlyExitException() { }

	public EarlyExitException(string message) { }

	public EarlyExitException(string message, Exception innerException) { }

	public EarlyExitException(int decisionNumber, IIntStream input) { }

	public EarlyExitException(string message, int decisionNumber, IIntStream input) { }

	public EarlyExitException(string message, int decisionNumber, IIntStream input, Exception innerException) { }

	protected EarlyExitException(SerializationInfo info, StreamingContext context) { }

	public int get_DecisionNumber() { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

