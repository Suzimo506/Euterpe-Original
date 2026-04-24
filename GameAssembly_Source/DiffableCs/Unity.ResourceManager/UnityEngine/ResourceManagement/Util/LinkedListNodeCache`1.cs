namespace UnityEngine.ResourceManagement.Util;

public class LinkedListNodeCache
{
	private int m_NodesCreated; //Field offset: 0x0
	private LinkedList<T> m_NodeCache; //Field offset: 0x0

	internal int CachedNodeCount
	{
		internal get { } //Length: 33
	}

	internal int CreatedNodeCount
	{
		internal get { } //Length: 4
	}

	public LinkedListNodeCache`1() { }

	public LinkedListNode<T> Acquire(T val) { }

	internal int get_CachedNodeCount() { }

	internal int get_CreatedNodeCount() { }

	public void Release(LinkedListNode<T> node) { }

}

