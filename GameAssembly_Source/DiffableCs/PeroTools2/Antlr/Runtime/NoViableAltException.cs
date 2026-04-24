namespace Antlr.Runtime;

public class NoViableAltException : RecognitionException
{
	private readonly string _grammarDecisionDescription; //Field offset: 0xB8
	private readonly int _decisionNumber; //Field offset: 0xC0
	private readonly int _stateNumber; //Field offset: 0xC4

	public int DecisionNumber
	{
		 get { } //Length: 7
	}

	public string GrammarDecisionDescription
	{
		 get { } //Length: 8
	}

	public int StateNumber
	{
		 get { } //Length: 7
	}

	public NoViableAltException() { }

	public NoViableAltException(string grammarDecisionDescription) { }

	public NoViableAltException(string message, string grammarDecisionDescription) { }

	public NoViableAltException(string message, string grammarDecisionDescription, Exception innerException) { }

	public NoViableAltException(string grammarDecisionDescription, int decisionNumber, int stateNumber, IIntStream input) { }

	public NoViableAltException(string message, string grammarDecisionDescription, int decisionNumber, int stateNumber, IIntStream input) { }

	public NoViableAltException(string message, string grammarDecisionDescription, int decisionNumber, int stateNumber, IIntStream input, int k) { }

	public NoViableAltException(string grammarDecisionDescription, int decisionNumber, int stateNumber, IIntStream input, int k) { }

	public NoViableAltException(string message, string grammarDecisionDescription, int decisionNumber, int stateNumber, IIntStream input, Exception innerException) { }

	protected NoViableAltException(SerializationInfo info, StreamingContext context) { }

	public int get_DecisionNumber() { }

	public string get_GrammarDecisionDescription() { }

	public int get_StateNumber() { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

