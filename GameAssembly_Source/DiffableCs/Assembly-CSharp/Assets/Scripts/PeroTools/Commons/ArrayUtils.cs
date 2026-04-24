namespace Assets.Scripts.PeroTools.Commons;

[Extension]
public static class ArrayUtils
{

	[Extension]
	public static T[] Add(T[] array, T value) { }

	public static void Add(ref T[] array, T value) { }

	[Extension]
	public static bool CanMoveBack(T[] array, T value) { }

	[Extension]
	public static bool CanMoveForw(T[] array, T value) { }

	[Extension]
	public static bool Contains(T[] array, T value) { }

	[Extension]
	public static T FindOne(T[] array, Predicate<T> callback) { }

	[Extension]
	public static int IndexOf(T[] array, T value) { }

	[Extension]
	public static void Init(T[] array) { }

	[Extension]
	public static T[] Insert(T[] array, int index, T value) { }

	[Extension]
	public static void MoveBack(T[] array, T value) { }

	[Extension]
	public static void MoveForw(T[] array, T value) { }

	public static List<T> NewList(int count, T defaultValue = null) { }

	[Extension]
	public static T[] Remove(T[] array, int index) { }

	public static void Remove(ref T[] array, int index) { }

	[Extension]
	public static void Remove(Stack<T> stack, Predicate<T> value) { }

	[Extension]
	public static T[] Remove(T[] array, T value) { }

	public static void Remove(ref T[] array, T value) { }

	[Extension]
	public static T SafeGet(IList<T> list, int index) { }

	[Extension]
	public static void Swap(IList<T> array, int left, int right) { }

	[Extension]
	public static void Swap(T[] array, int left, int right) { }

	[Extension]
	public static T[] ToRefArray(List<T> list) { }

	[Extension]
	public static bool TryGetKey(Dictionary<T, U> dic, U value, out T key) { }

	[Extension]
	public static bool TryGetValue(IList<T> list, int index, out T value) { }

}

