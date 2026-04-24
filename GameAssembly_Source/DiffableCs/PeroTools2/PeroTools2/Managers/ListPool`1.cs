namespace PeroTools2.Managers;

public static class ListPool
{
	public static int capacity; //Field offset: 0x0
	private static readonly Pool<List`1<T>> s_ListPool; //Field offset: 0x0

	private static ListPool`1() { }

	private static void Clear(List<T> l) { }

	private static List<T> Create() { }

	public static List<T> Get() { }

	public static void Release(List<T> list) { }

}

