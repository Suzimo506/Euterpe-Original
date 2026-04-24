namespace Assets.Scripts.PeroTools.Commons;

[Extension]
public static class LinqUtils
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public Func<T, Boolean> predicate; //Field offset: 0x0
		public int count; //Field offset: 0x0

		public <>c__DisplayClass10_0`1() { }

		internal void <Count>b__0(T element) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public List<T> list; //Field offset: 0x0

		public <>c__DisplayClass17_0`1() { }

		internal void <Cast>b__0(T element) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public Func<T, Int32> predicate; //Field offset: 0x0
		public int max; //Field offset: 0x0

		public <>c__DisplayClass18_0`1() { }

		internal void <Max>b__0(T element) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public Func<T, Single> predicate; //Field offset: 0x0
		public float max; //Field offset: 0x0

		public <>c__DisplayClass19_0`1() { }

		internal void <Max>b__0(T element) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public Func<T, Decimal> predicate; //Field offset: 0x0
		public decimal max; //Field offset: 0x0

		public <>c__DisplayClass20_0`1() { }

		internal void <Max>b__0(T element) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public Func<T, Int32> predicate; //Field offset: 0x0
		public int min; //Field offset: 0x0

		public <>c__DisplayClass21_0`1() { }

		internal void <Min>b__0(T element) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public Func<T, Single> predicate; //Field offset: 0x0
		public float min; //Field offset: 0x0

		public <>c__DisplayClass22_0`1() { }

		internal void <Min>b__0(T element) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public Func<T, Decimal> predicate; //Field offset: 0x0
		public decimal min; //Field offset: 0x0

		public <>c__DisplayClass23_0`1() { }

		internal void <Min>b__0(T element) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public Func<T2, T1> predicate; //Field offset: 0x0
		public List<T1> list; //Field offset: 0x0

		public <>c__DisplayClass24_0`2() { }

		internal void <Select>b__0(T2 element) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public Func<T2, T1> predicate; //Field offset: 0x0
		public List<T1> list; //Field offset: 0x0

		public <>c__DisplayClass25_0`2() { }

		internal void <Select>b__0(T2 element) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public Func<T, Boolean> predicate; //Field offset: 0x0
		public T value; //Field offset: 0x0

		public <>c__DisplayClass27_0`1() { }

		internal void <Single>b__0(T element) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public Func<T, Single> predicate; //Field offset: 0x0
		public float sum; //Field offset: 0x0

		public <>c__DisplayClass28_0`1() { }

		internal void <Sum>b__0(T element) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public Func<T, Int32> predicate; //Field offset: 0x0
		public int sum; //Field offset: 0x0

		public <>c__DisplayClass29_0`1() { }

		internal void <Sum>b__0(T element) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Func<T, Boolean> predicate; //Field offset: 0x0
		public List<T> outArray; //Field offset: 0x0

		public <>c__DisplayClass3_0`1() { }

		internal void <Where>b__0(T element) { }

	}


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
	public static T First(IList<T> array) { }

	[Extension]
	public static void For(IList<T> array, Action<T> predicate) { }

	[Extension]
	public static void For(IEnumerable<T> array, Action<T> predicate) { }

	[Extension]
	public static T Last(IList<T> array) { }

	[Extension]
	public static decimal Max(IList<T> array, Func<T, Decimal> predicate) { }

	[Extension]
	public static float Max(IList<T> array, Func<T, Single> predicate) { }

	[Extension]
	public static int Max(IList<T> array, Func<T, Int32> predicate) { }

	[Extension]
	public static float Min(IList<T> array, Func<T, Single> predicate) { }

	[Extension]
	public static int Min(IList<T> array, Func<T, Int32> predicate) { }

	[Extension]
	public static decimal Min(IList<T> array, Func<T, Decimal> predicate) { }

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

