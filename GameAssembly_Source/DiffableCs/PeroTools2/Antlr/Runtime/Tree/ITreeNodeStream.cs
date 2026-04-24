namespace Antlr.Runtime.Tree;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public interface ITreeNodeStream : IIntStream
{

	public object Item
	{
		 get { } //Length: 0
	}

	public ITokenStream TokenStream
	{
		 get { } //Length: 0
	}

	public ITreeAdaptor TreeAdaptor
	{
		 get { } //Length: 0
	}

	public object TreeSource
	{
		 get { } //Length: 0
	}

	public bool UniqueNavigationNodes
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public object get_Item(int i) { }

	public ITokenStream get_TokenStream() { }

	public ITreeAdaptor get_TreeAdaptor() { }

	public object get_TreeSource() { }

	public bool get_UniqueNavigationNodes() { }

	public object LT(int k) { }

	public void ReplaceChildren(object parent, int startChildIndex, int stopChildIndex, object t) { }

	public void set_UniqueNavigationNodes(bool value) { }

	public string ToString(object start, object stop) { }

}

