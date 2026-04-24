namespace Antlr.Runtime;

public interface ITokenStream : IIntStream
{

	public int Range
	{
		 get { } //Length: 0
	}

	public ITokenSource TokenSource
	{
		 get { } //Length: 0
	}

	public IToken Get(int i) { }

	public int get_Range() { }

	public ITokenSource get_TokenSource() { }

	public IToken LT(int k) { }

	public string ToString(int start, int stop) { }

	public string ToString(IToken start, IToken stop) { }

}

