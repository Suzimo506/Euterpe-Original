namespace PeroTools2.Commons;

[Extension]
public static class LinqUtils
{

	[Extension]
	public static List<T> Cast(IList<T> array) { }

	[Extension]
	public static List<T> Cast(IList array) { }

	[Extension]
	public static bool Contains(IList<T> array, T predicate) { }

	[Extension]
	public static int Count(IList<T> array, Func<T, Boolean> predicate) { }

	[Extension]
	public static bool Exists(IList<T> array, Func<T, Boolean> predicate) { }

	[Extension]
	public static T Find(IList<T> array, Func<T, Boolean> predicate) { }

	[Extension]
	public static int FindIndex(IList<T> array, Func<T, Boolean> predicate) { }

	[Extension]
	public static T First(IList<T> array, Func<T, Boolean> predicate) { }

	[Extension]
	public static T First(IList<T> array) { }

	[Extension]
	public static T Last(IList<T> array) { }

	[Extension]
	public static int Max(IList<T> array, Func<T, Int32> predicate) { }

	[Extension]
	public static float Max(IList<T> array, Func<T, Single> predicate) { }

	[Extension]
	public static decimal Max(IList<T> array, Func<T, Decimal> predicate) { }

	[Extension]
	public static int Min(IList<T> array, Func<T, Int32> predicate) { }

	[Extension]
	public static decimal Min(IList<T> array, Func<T, Decimal> predicate) { }

	[Extension]
	public static float Min(IList<T> array, Func<T, Single> predicate) { }

	[Extension]
	public static List<T> OfType(IList array) { }

	[Extension]
	public static List<T> Reverse(IList<T> array) { }

	[Extension]
	public static List<T1> Select(IList<T2> array, Func<T2, T1> predicate) { }

	[Extension]
	public static List<T1> Select(IEnumerable<T2> array, Func<T2, T1> predicate) { }

	[Extension]
	public static void SelectNoAlloc(IList<T2> array, List<T1> list, Func<T2, T1> predicate) { }

	[Extension]
	public static T Single(IList<T> array, Func<T, Boolean> predicate) { }

	[Extension]
	public static int Sum(IList<T> array, Func<T, Int32> predicate) { }

	[Extension]
	public static float Sum(IList<T> array, Func<T, Single> predicate) { }

	[Extension]
	public static T[] ToArray(IList<T> array) { }

	[Extension]
	public static T[] ToArray(IEnumerable<T> array) { }

	[Extension]
	public static List<T> ToList(IEnumerable<T> array) { }

	[Extension]
	public static List<T> Where(IEnumerable<T> array, Func<T, Boolean> predicate) { }

	[Extension]
	public static List<T> Where(IList<T> array, Func<T, Boolean> predicate) { }

}

