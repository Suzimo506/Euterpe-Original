namespace Antlr.Runtime.Tree;

public class TreeVisitor
{
	protected ITreeAdaptor adaptor; //Field offset: 0x10

	public TreeVisitor(ITreeAdaptor adaptor) { }

	public TreeVisitor() { }

	public object Visit(object t, ITreeVisitorAction action) { }

	public object Visit(object t, Func<Object, Object> preAction, Func<Object, Object> postAction) { }

}

