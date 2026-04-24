namespace UnityEngine.ResourceManagement.Util;

internal static class GlobalLinkedListNodeCache
{
	private static LinkedListNodeCache<T> m_globalCache; //Field offset: 0x0

	public static LinkedListNode<T> Acquire(T val) { }

	public static void Release(LinkedListNode<T> node) { }

}

