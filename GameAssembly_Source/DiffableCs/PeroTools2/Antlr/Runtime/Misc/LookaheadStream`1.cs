namespace Antlr.Runtime.Misc;

public abstract class LookaheadStream : FastQueue<T>
{
	private int _currentElementIndex; //Field offset: 0x0
	private T _previousElement; //Field offset: 0x0
	private T _eof; //Field offset: 0x0
	private int _lastMarker; //Field offset: 0x0
	private int _markDepth; //Field offset: 0x0

	public virtual int Count
	{
		 get { } //Length: 81
	}

	public T EndOfFile
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public override int Index
	{
		 get { } //Length: 4
	}

	protected LookaheadStream`1() { }

	public virtual void Clear() { }

	public override void Consume() { }

	public virtual T Dequeue() { }

	public override void Fill(int n) { }

	public virtual int get_Count() { }

	public T get_EndOfFile() { }

	public override int get_Index() { }

	public abstract bool IsEndOfFile(T o) { }

	protected override T LB(int k) { }

	public override T LT(int k) { }

	public override int Mark() { }

	public abstract T NextElement() { }

	public override void Release(int marker) { }

	public override void Rewind(int marker) { }

	public override void Rewind() { }

	public override void Seek(int index) { }

	protected void set_EndOfFile(T value) { }

	protected override void SyncAhead(int need) { }

}

