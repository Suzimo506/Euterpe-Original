namespace Antlr.Runtime.Tree;

public class CommonTree : BaseTree
{
	private IToken _token; //Field offset: 0x20
	protected int startIndex; //Field offset: 0x28
	protected int stopIndex; //Field offset: 0x2C
	private CommonTree parent; //Field offset: 0x30
	private int childIndex; //Field offset: 0x38

	public virtual int CharPositionInLine
	{
		 get { } //Length: 208
		 set { } //Length: 4
	}

	public virtual int ChildIndex
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public virtual bool IsNil
	{
		 get { } //Length: 9
	}

	public virtual int Line
	{
		 get { } //Length: 207
		 set { } //Length: 4
	}

	public virtual ITree Parent
	{
		 get { } //Length: 5
		 set { } //Length: 144
	}

	public virtual string Text
	{
		 get { } //Length: 72
		 set { } //Length: 3
	}

	public IToken Token
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public virtual int TokenStartIndex
	{
		 get { } //Length: 81
		 set { } //Length: 4
	}

	public virtual int TokenStopIndex
	{
		 get { } //Length: 81
		 set { } //Length: 4
	}

	public virtual int Type
	{
		 get { } //Length: 75
		 set { } //Length: 3
	}

	public CommonTree() { }

	public CommonTree(CommonTree node) { }

	public CommonTree(IToken t) { }

	public virtual ITree DupNode() { }

	public virtual int get_CharPositionInLine() { }

	public virtual int get_ChildIndex() { }

	public virtual bool get_IsNil() { }

	public virtual int get_Line() { }

	public virtual ITree get_Parent() { }

	public virtual string get_Text() { }

	public IToken get_Token() { }

	public virtual int get_TokenStartIndex() { }

	public virtual int get_TokenStopIndex() { }

	public virtual int get_Type() { }

	public virtual void set_CharPositionInLine(int value) { }

	public virtual void set_ChildIndex(int value) { }

	public virtual void set_Line(int value) { }

	public virtual void set_Parent(ITree value) { }

	public virtual void set_Text(string value) { }

	public void set_Token(IToken value) { }

	public virtual void set_TokenStartIndex(int value) { }

	public virtual void set_TokenStopIndex(int value) { }

	public virtual void set_Type(int value) { }

	public override void SetUnknownTokenBoundaries() { }

	public virtual string ToString() { }

}

