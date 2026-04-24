namespace Antlr.Runtime.Tree;

public class CommonTreeNodeStream : LookaheadStream<Object>, ITreeNodeStream, IIntStream
{
	public const int DEFAULT_INITIAL_BUFFER_SIZE = 100; //Field offset: 0x0
	public const int INITIAL_CALL_STACK_SIZE = 10; //Field offset: 0x0
	private object _root; //Field offset: 0x40
	protected ITokenStream tokens; //Field offset: 0x48
	private ITreeAdaptor _adaptor; //Field offset: 0x50
	private TreeIterator _it; //Field offset: 0x58
	private Stack<Int32> _calls; //Field offset: 0x60
	private bool _hasNilRoot; //Field offset: 0x68
	private int _level; //Field offset: 0x6C

	public override string SourceName
	{
		 get { } //Length: 120
	}

	public override ITokenStream TokenStream
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public override ITreeAdaptor TreeAdaptor
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public override object TreeSource
	{
		 get { } //Length: 5
	}

	public override bool UniqueNavigationNodes
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	public CommonTreeNodeStream(object tree) { }

	public CommonTreeNodeStream(ITreeAdaptor adaptor, object tree) { }

	public override string get_SourceName() { }

	public override ITokenStream get_TokenStream() { }

	public override ITreeAdaptor get_TreeAdaptor() { }

	public override object get_TreeSource() { }

	public override bool get_UniqueNavigationNodes() { }

	public virtual bool IsEndOfFile(object o) { }

	public override int LA(int i) { }

	public virtual object NextElement() { }

	public override int Pop() { }

	public override void Push(int index) { }

	public override void ReplaceChildren(object parent, int startChildIndex, int stopChildIndex, object t) { }

	public override void Reset() { }

	public override void set_TokenStream(ITokenStream value) { }

	public override void set_TreeAdaptor(ITreeAdaptor value) { }

	public override void set_UniqueNavigationNodes(bool value) { }

	public override string ToString(object start, object stop) { }

	public override string ToTokenTypeString() { }

}

