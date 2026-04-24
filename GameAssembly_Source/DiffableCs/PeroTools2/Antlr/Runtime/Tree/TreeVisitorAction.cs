namespace Antlr.Runtime.Tree;

public class TreeVisitorAction : ITreeVisitorAction
{
	private Func<Object, Object> _preAction; //Field offset: 0x10
	private Func<Object, Object> _postAction; //Field offset: 0x18

	public TreeVisitorAction(Func<Object, Object> preAction, Func<Object, Object> postAction) { }

	public override object Post(object t) { }

	public override object Pre(object t) { }

}

