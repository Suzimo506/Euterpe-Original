namespace Antlr.Runtime;

public interface IRuleReturnScope : IRuleReturnScope
{

	public TLabel Start
	{
		 get { } //Length: 0
	}

	public TLabel Stop
	{
		 get { } //Length: 0
	}

	public TLabel get_Start() { }

	public TLabel get_Stop() { }

}

