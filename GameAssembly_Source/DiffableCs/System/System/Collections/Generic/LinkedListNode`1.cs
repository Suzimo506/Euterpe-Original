namespace System.Collections.Generic;

public sealed class LinkedListNode
{
	internal LinkedList<T> list; //Field offset: 0x0
	internal LinkedListNode<T> next; //Field offset: 0x0
	internal LinkedListNode<T> prev; //Field offset: 0x0
	internal T item; //Field offset: 0x0

	public LinkedList<T> List
	{
		 get { } //Length: 5
	}

	public LinkedListNode<T> Next
	{
		 get { } //Length: 40
	}

	public LinkedListNode<T> Previous
	{
		 get { } //Length: 40
	}

	public T Value
	{
		 get { } //Length: 5
		 set { } //Length: 17
	}

	public LinkedListNode`1(T value) { }

	internal LinkedListNode`1(LinkedList<T> list, T value) { }

	public LinkedList<T> get_List() { }

	public LinkedListNode<T> get_Next() { }

	public LinkedListNode<T> get_Previous() { }

	public T get_Value() { }

	internal void Invalidate() { }

	public void set_Value(T value) { }

}

