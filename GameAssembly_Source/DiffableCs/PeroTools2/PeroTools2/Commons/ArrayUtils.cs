namespace PeroTools2.Commons;

[Extension]
public static class ArrayUtils
{

	[Extension]
	public static T[] Add(T[] array, T value) { }

	public static void Add(ref T[] array, T value) { }

	[Extension]
	public static bool Contains(T[] array, T value) { }

	[Extension]
	public static int IndexOf(T[] array, T value) { }

	[Extension]
	public static T[] Insert(T[] array, int index, T value) { }

	[Extension]
	public static void Remove(Stack<T> stack, Predicate<T> value) { }

	[Extension]
	public static T[] Remove(T[] array, T value) { }

	public static void Remove(ref T[] array, T value) { }

	[Extension]
	public static T[] RemoveAt(T[] array, int index) { }

	public static void RemoveAt(ref T[] array, int index) { }

}

