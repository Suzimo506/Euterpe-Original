namespace Antlr.Runtime.Tree;

public class CommonErrorNode : CommonTree
{
	public IIntStream input; //Field offset: 0x40
	public IToken start; //Field offset: 0x48
	public IToken stop; //Field offset: 0x50
	public RecognitionException trappedException; //Field offset: 0x58

	public virtual bool IsNil
	{
		 get { } //Length: 3
	}

	public virtual string Text
	{
		 get { } //Length: 794
		 set { } //Length: 3
	}

	public virtual int Type
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	public CommonErrorNode(ITokenStream input, IToken start, IToken stop, RecognitionException e) { }

	public virtual bool get_IsNil() { }

	public virtual string get_Text() { }

	public virtual int get_Type() { }

	public virtual void set_Text(string value) { }

	public virtual void set_Type(int value) { }

	public virtual string ToString() { }

}

