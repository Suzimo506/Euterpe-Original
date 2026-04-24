namespace Antlr.Runtime.Tree;

public abstract class BaseTreeAdaptor : ITreeAdaptor
{
	protected IDictionary<Object, Int32> treeToUniqueIDMap; //Field offset: 0x10
	protected int uniqueNodeID; //Field offset: 0x18

	protected BaseTreeAdaptor() { }

	public override void AddChild(object t, object child) { }

	public override object BecomeRoot(IToken newRoot, object oldRoot) { }

	public override object BecomeRoot(object newRoot, object oldRoot) { }

	public abstract object Create(IToken payload) { }

	public override object Create(IToken fromToken, string text) { }

	public override object Create(int tokenType, IToken fromToken, string text) { }

	public override object Create(int tokenType, IToken fromToken) { }

	public override object Create(int tokenType, string text) { }

	public abstract IToken CreateToken(IToken fromToken) { }

	public abstract IToken CreateToken(int tokenType, string text) { }

	public override object DeleteChild(object t, int i) { }

	public override object DupNode(int type, object treeNode, string text) { }

	public override object DupNode(object treeNode, string text) { }

	public override object DupNode(int type, object treeNode) { }

	public override object DupNode(object treeNode) { }

	public override object DupTree(object tree) { }

	public override object DupTree(object t, object parent) { }

	public override object ErrorNode(ITokenStream input, IToken start, IToken stop, RecognitionException e) { }

	public override object GetChild(object t, int i) { }

	public override int GetChildCount(object t) { }

	public override int GetChildIndex(object t) { }

	public override object GetParent(object t) { }

	public override string GetText(object t) { }

	public abstract IToken GetToken(object t) { }

	public override int GetTokenStartIndex(object t) { }

	public override int GetTokenStopIndex(object t) { }

	protected override ITree GetTree(object t) { }

	public override int GetType(object t) { }

	public override int GetUniqueID(object node) { }

	public override bool IsNil(object tree) { }

	public override object Nil() { }

	public override void ReplaceChildren(object parent, int startChildIndex, int stopChildIndex, object t) { }

	public override object RulePostProcessing(object root) { }

	public override void SetChild(object t, int i, object child) { }

	public override void SetChildIndex(object t, int index) { }

	public override void SetParent(object t, object parent) { }

	public override void SetText(object t, string text) { }

	public override void SetTokenBoundaries(object t, IToken startToken, IToken stopToken) { }

	public override void SetType(object t, int type) { }

}

