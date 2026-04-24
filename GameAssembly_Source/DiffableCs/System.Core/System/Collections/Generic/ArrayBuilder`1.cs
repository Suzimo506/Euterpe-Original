namespace System.Collections.Generic;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal struct ArrayBuilder
{
	private T[] _array; //Field offset: 0x0
	private int _count; //Field offset: 0x0

	public int Capacity
	{
		 get { } //Length: 13
	}

	public int Count
	{
		 get { } //Length: 4
	}

	public T Item
	{
		 get { } //Length: 52
	}

	public ArrayBuilder`1(int capacity) { }

	public void Add(T item) { }

	private void EnsureCapacity(int minimum) { }

	public int get_Capacity() { }

	public int get_Count() { }

	public T get_Item(int index) { }

	public T[] ToArray() { }

	public void UncheckedAdd(T item) { }

}

