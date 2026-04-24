namespace Antlr.Runtime;

public class AstParserRuleReturnScope : ParserRuleReturnScope<TToken>, IAstRuleReturnScope<TAstLabel>, IAstRuleReturnScope, IRuleReturnScope
{
	private TAstLabel _tree; //Field offset: 0x0

	private override object Antlr.Runtime.IAstRuleReturnScope.Tree
	{
		private get { } //Length: 5
	}

	public override TAstLabel Tree
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public AstParserRuleReturnScope`2() { }

	private override object Antlr.Runtime.IAstRuleReturnScope.get_Tree() { }

	public override TAstLabel get_Tree() { }

	public void set_Tree(TAstLabel value) { }

}

