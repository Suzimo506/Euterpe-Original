namespace Antlr.Runtime;

public interface ITokenStreamInformation
{

	public IToken LastRealToken
	{
		 get { } //Length: 0
	}

	public IToken LastToken
	{
		 get { } //Length: 0
	}

	public int MaxLookBehind
	{
		 get { } //Length: 0
	}

	public IToken get_LastRealToken() { }

	public IToken get_LastToken() { }

	public int get_MaxLookBehind() { }

}

