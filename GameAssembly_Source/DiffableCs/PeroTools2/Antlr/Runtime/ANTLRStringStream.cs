namespace Antlr.Runtime;

public class ANTLRStringStream : ICharStream, IIntStream
{
	protected Char[] data; //Field offset: 0x10
	protected int n; //Field offset: 0x18
	protected int p; //Field offset: 0x1C
	private int line; //Field offset: 0x20
	private int charPositionInLine; //Field offset: 0x24
	protected int markDepth; //Field offset: 0x28
	protected IList<CharStreamState> markers; //Field offset: 0x30
	protected int lastMarker; //Field offset: 0x38
	public string name; //Field offset: 0x40

	public override int CharPositionInLine
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public override int Count
	{
		 get { } //Length: 4
	}

	public override int Index
	{
		 get { } //Length: 4
	}

	public override int Line
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public override string SourceName
	{
		 get { } //Length: 5
	}

	public ANTLRStringStream(string input) { }

	public ANTLRStringStream(string input, string sourceName) { }

	public ANTLRStringStream(Char[] data, int numberOfActualCharsInArray) { }

	public ANTLRStringStream(Char[] data, int numberOfActualCharsInArray, string sourceName) { }

	protected ANTLRStringStream() { }

	public override void Consume() { }

	public override int get_CharPositionInLine() { }

	public override int get_Count() { }

	public override int get_Index() { }

	public override int get_Line() { }

	public override string get_SourceName() { }

	public override int LA(int i) { }

	public override int LT(int i) { }

	public override int Mark() { }

	public override void Release(int marker) { }

	public override void Reset() { }

	public override void Rewind(int m) { }

	public override void Rewind() { }

	public override void Seek(int index) { }

	public override void set_CharPositionInLine(int value) { }

	public override void set_Line(int value) { }

	public override string Substring(int start, int length) { }

	public virtual string ToString() { }

}

