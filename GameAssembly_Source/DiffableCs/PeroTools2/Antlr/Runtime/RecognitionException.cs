namespace Antlr.Runtime;

public class RecognitionException : Exception
{
	private IIntStream _input; //Field offset: 0x88
	private int _index; //Field offset: 0x90
	private IToken _token; //Field offset: 0x98
	private object _node; //Field offset: 0xA0
	private int _c; //Field offset: 0xA8
	private int _line; //Field offset: 0xAC
	private int _charPositionInLine; //Field offset: 0xB0
	private bool _approximateLineInfo; //Field offset: 0xB4

	public bool ApproximateLineInfo
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public int Character
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public int CharPositionInLine
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public int Index
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public IIntStream Input
	{
		 get { } //Length: 8
		 set { } //Length: 15
	}

	public int Line
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public object Node
	{
		 get { } //Length: 8
		 set { } //Length: 15
	}

	public IToken Token
	{
		 get { } //Length: 8
		 set { } //Length: 15
	}

	public override int UnexpectedType
	{
		 get { } //Length: 192
	}

	public RecognitionException() { }

	public RecognitionException(IIntStream input) { }

	public RecognitionException(string message) { }

	public RecognitionException(string message, IIntStream input) { }

	public RecognitionException(string message, Exception innerException) { }

	public RecognitionException(string message, IIntStream input, Exception innerException) { }

	protected RecognitionException(SerializationInfo info, StreamingContext context) { }

	protected override void ExtractInformationFromTreeNodeStream(ITreeNodeStream input) { }

	public bool get_ApproximateLineInfo() { }

	public int get_Character() { }

	public int get_CharPositionInLine() { }

	public int get_Index() { }

	public IIntStream get_Input() { }

	public int get_Line() { }

	public object get_Node() { }

	public IToken get_Token() { }

	public override int get_UnexpectedType() { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	protected void set_ApproximateLineInfo(bool value) { }

	protected void set_Character(int value) { }

	public void set_CharPositionInLine(int value) { }

	protected void set_Index(int value) { }

	protected void set_Input(IIntStream value) { }

	public void set_Line(int value) { }

	protected void set_Node(object value) { }

	public void set_Token(IToken value) { }

}

