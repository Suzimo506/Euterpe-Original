namespace UnityEngine.Rendering;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class DynamicArray
{
	private T[] m_Array; //Field offset: 0x0
	[CompilerGenerated]
	private int <size>k__BackingField; //Field offset: 0x0

	public T Item
	{
		 get { } //Length: 56
	}

	public private int size
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public DynamicArray`1() { }

	public DynamicArray`1(int size) { }

	public int Add(in T value) { }

	public void Clear() { }

	public T get_Item(int index) { }

	[CompilerGenerated]
	public int get_size() { }

	public void Resize(int newSize, bool keepContent = false) { }

	[CompilerGenerated]
	private void set_size(int value) { }

}

