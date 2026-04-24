namespace Antlr.Runtime.Tree;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class BufferedTreeNodeStream : ITreeNodeStream, IIntStream, ITokenStreamInformation
{
	internal sealed class StreamIterator : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private BufferedTreeNodeStream _outer; //Field offset: 0x10
		private int _index; //Field offset: 0x18

		public override object Current
		{
			 get { } //Length: 153
		}

		public StreamIterator(BufferedTreeNodeStream outer) { }

		public override void Dispose() { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	public const int DEFAULT_INITIAL_BUFFER_SIZE = 100; //Field offset: 0x0
	public const int INITIAL_CALL_STACK_SIZE = 10; //Field offset: 0x0
	protected object down; //Field offset: 0x10
	protected object up; //Field offset: 0x18
	protected object eof; //Field offset: 0x20
	protected IList nodes; //Field offset: 0x28
	protected object root; //Field offset: 0x30
	protected ITokenStream tokens; //Field offset: 0x38
	private ITreeAdaptor adaptor; //Field offset: 0x40
	private bool uniqueNavigationNodes; //Field offset: 0x48
	protected int p; //Field offset: 0x4C
	protected int lastMarker; //Field offset: 0x50
	protected Stack<Int32> calls; //Field offset: 0x58

	public override int Count
	{
		 get { } //Length: 127
	}

	public override int Index
	{
		 get { } //Length: 4
	}

	public override object Item
	{
		 get { } //Length: 138
	}

	public override IToken LastRealToken
	{
		 get { } //Length: 415
	}

	public override IToken LastToken
	{
		 get { } //Length: 130
	}

	public override int MaxLookBehind
	{
		 get { } //Length: 6
	}

	public override string SourceName
	{
		 get { } //Length: 90
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
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public BufferedTreeNodeStream(object tree) { }

	public BufferedTreeNodeStream(ITreeAdaptor adaptor, object tree) { }

	public BufferedTreeNodeStream(ITreeAdaptor adaptor, object tree, int initialBufferSize) { }

	protected override void AddNavigationNode(int ttype) { }

	public override void Consume() { }

	public override void FillBuffer(object t) { }

	protected override void FillBuffer() { }

	public override int get_Count() { }

	public override int get_Index() { }

	public override object get_Item(int i) { }

	public override IToken get_LastRealToken() { }

	public override IToken get_LastToken() { }

	public override int get_MaxLookBehind() { }

	public override string get_SourceName() { }

	public override ITokenStream get_TokenStream() { }

	public override ITreeAdaptor get_TreeAdaptor() { }

	public override object get_TreeSource() { }

	public override bool get_UniqueNavigationNodes() { }

	public override object GetCurrentSymbol() { }

	protected override int GetNodeIndex(object node) { }

	public override IEnumerator<Object> Iterator() { }

	public override int LA(int i) { }

	protected override object LB(int k) { }

	public override object LT(int k) { }

	public override int Mark() { }

	public override int Pop() { }

	public override void Push(int index) { }

	public override void Release(int marker) { }

	public override void ReplaceChildren(object parent, int startChildIndex, int stopChildIndex, object t) { }

	public override void Reset() { }

	public override void Rewind(int marker) { }

	public override void Rewind() { }

	public override void Seek(int index) { }

	public override void set_TokenStream(ITokenStream value) { }

	public override void set_TreeAdaptor(ITreeAdaptor value) { }

	public override void set_UniqueNavigationNodes(bool value) { }

	public override string ToString(object start, object stop) { }

	public override string ToTokenString(int start, int stop) { }

	public override string ToTokenTypeString() { }

}

