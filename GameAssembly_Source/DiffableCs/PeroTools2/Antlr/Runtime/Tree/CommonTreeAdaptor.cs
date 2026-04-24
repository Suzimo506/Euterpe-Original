namespace Antlr.Runtime.Tree;

public class CommonTreeAdaptor : BaseTreeAdaptor
{

	public CommonTreeAdaptor() { }

	public virtual object Create(IToken payload) { }

	public virtual IToken CreateToken(int tokenType, string text) { }

	public virtual IToken CreateToken(IToken fromToken) { }

	public virtual IToken GetToken(object t) { }

}

