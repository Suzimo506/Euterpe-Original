namespace Antlr.Runtime.Misc;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class FastQueue
{
	internal List<T> _data; //Field offset: 0x0
	internal int _p; //Field offset: 0x0
	[CompilerGenerated]
	private int <Range>k__BackingField; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 51
	}

	public override T Item
	{
		 get { } //Length: 444
	}

	public override int Range
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public FastQueue`1() { }

	public override void Clear() { }

	public override T Dequeue() { }

	public override void Enqueue(T o) { }

	public override int get_Count() { }

	public override T get_Item(int i) { }

	[CompilerGenerated]
	public override int get_Range() { }

	public override T Peek() { }

	[CompilerGenerated]
	protected override void set_Range(int value) { }

	public virtual string ToString() { }

}

