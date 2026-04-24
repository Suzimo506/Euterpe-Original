namespace Antlr.Runtime.Tree;

public class TreeIterator : IEnumerator<Object>, IEnumerator, IDisposable
{
	protected ITreeAdaptor adaptor; //Field offset: 0x10
	protected object root; //Field offset: 0x18
	protected object tree; //Field offset: 0x20
	protected bool firstTime; //Field offset: 0x28
	private bool reachedEof; //Field offset: 0x29
	public object up; //Field offset: 0x30
	public object down; //Field offset: 0x38
	public object eof; //Field offset: 0x40
	protected Queue<Object> nodes; //Field offset: 0x48
	[CompilerGenerated]
	private object <Current>k__BackingField; //Field offset: 0x50

	public private override object Current
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public TreeIterator(CommonTree tree) { }

	public TreeIterator(ITreeAdaptor adaptor, object tree) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public override object get_Current() { }

	public override bool MoveNext() { }

	public override void Reset() { }

	[CompilerGenerated]
	private void set_Current(object value) { }

}

