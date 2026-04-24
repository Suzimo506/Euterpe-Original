namespace PeroTools2.Managers;

public static class ArrayPool
{
	public static int capacity; //Field offset: 0x0
	private static readonly Pool<T[]> s_ArrayPool; //Field offset: 0x0

	private static ArrayPool`1() { }

	private static void Clear(T[] array) { }

	private static T[] Create() { }

	public static T[] Get() { }

	public static void Release(T[] list) { }

}

