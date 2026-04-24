namespace Antlr.Runtime;

public interface ITokenSource
{

	public string SourceName
	{
		 get { } //Length: 0
	}

	public String[] TokenNames
	{
		 get { } //Length: 0
	}

	public string get_SourceName() { }

	public String[] get_TokenNames() { }

	public IToken NextToken() { }

}

