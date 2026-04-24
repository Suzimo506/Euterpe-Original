namespace Antlr.Runtime.Tree;

public interface ITreeAdaptor
{

	public void AddChild(object t, object child) { }

	public object BecomeRoot(IToken newRoot, object oldRoot) { }

	public object BecomeRoot(object newRoot, object oldRoot) { }

	public object Create(int tokenType, string text) { }

	public object Create(IToken payload) { }

	public object Create(IToken fromToken, string text) { }

	public object Create(int tokenType, IToken fromToken, string text) { }

	public object Create(int tokenType, IToken fromToken) { }

	public object DeleteChild(object t, int i) { }

	public object DupNode(object treeNode) { }

	public object DupNode(int type, object treeNode) { }

	public object DupNode(object treeNode, string text) { }

	public object DupNode(int type, object treeNode, string text) { }

	public object DupTree(object tree) { }

	public object ErrorNode(ITokenStream input, IToken start, IToken stop, RecognitionException e) { }

	public object GetChild(object t, int i) { }

	public int GetChildCount(object t) { }

	public int GetChildIndex(object t) { }

	public object GetParent(object t) { }

	public string GetText(object t) { }

	public IToken GetToken(object t) { }

	public int GetTokenStartIndex(object t) { }

	public int GetTokenStopIndex(object t) { }

	public int GetType(object t) { }

	public int GetUniqueID(object node) { }

	public bool IsNil(object tree) { }

	public object Nil() { }

	public void ReplaceChildren(object parent, int startChildIndex, int stopChildIndex, object t) { }

	public object RulePostProcessing(object root) { }

	public void SetChild(object t, int i, object child) { }

	public void SetChildIndex(object t, int index) { }

	public void SetParent(object t, object parent) { }

	public void SetText(object t, string text) { }

	public void SetTokenBoundaries(object t, IToken startToken, IToken stopToken) { }

	public void SetType(object t, int type) { }

}

