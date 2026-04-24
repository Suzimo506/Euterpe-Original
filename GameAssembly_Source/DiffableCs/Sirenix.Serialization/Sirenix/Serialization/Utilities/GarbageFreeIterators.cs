namespace Sirenix.Serialization.Utilities;

[Extension]
internal static class GarbageFreeIterators
{
	internal struct DictionaryIterator : IDisposable
	{
		private Dictionary<T1, T2> dictionary; //Field offset: 0x0
		private Enumerator<T1, T2> enumerator; //Field offset: 0x0
		private bool isNull; //Field offset: 0x0

		public KeyValuePair<T1, T2> Current
		{
			 get { } //Length: 55
		}

		public DictionaryIterator`2(Dictionary<T1, T2> dictionary) { }

		public override void Dispose() { }

		public KeyValuePair<T1, T2> get_Current() { }

		public DictionaryIterator<T1, T2> GetEnumerator() { }

		public bool MoveNext() { }

	}

	internal struct DictionaryValueIterator : IDisposable
	{
		private Dictionary<T1, T2> dictionary; //Field offset: 0x0
		private Enumerator<T1, T2> enumerator; //Field offset: 0x0
		private bool isNull; //Field offset: 0x0

		public T2 Current
		{
			 get { } //Length: 77
		}

		public DictionaryValueIterator`2(Dictionary<T1, T2> dictionary) { }

		public override void Dispose() { }

		public T2 get_Current() { }

		public DictionaryValueIterator<T1, T2> GetEnumerator() { }

		public bool MoveNext() { }

	}

	internal struct HashsetIterator : IDisposable
	{
		private bool isNull; //Field offset: 0x0
		private HashSet<T> hashset; //Field offset: 0x0
		private Enumerator<T> enumerator; //Field offset: 0x0

		public T Current
		{
			 get { } //Length: 37
		}

		public HashsetIterator`1(HashSet<T> hashset) { }

		public override void Dispose() { }

		public T get_Current() { }

		public HashsetIterator<T> GetEnumerator() { }

		public bool MoveNext() { }

	}

	internal struct ListIterator : IDisposable
	{
		private bool isNull; //Field offset: 0x0
		private List<T> list; //Field offset: 0x0
		private Enumerator<T> enumerator; //Field offset: 0x0

		public T Current
		{
			 get { } //Length: 37
		}

		public ListIterator`1(List<T> list) { }

		public override void Dispose() { }

		public T get_Current() { }

		public ListIterator<T> GetEnumerator() { }

		public bool MoveNext() { }

	}


	[Extension]
	public static ListIterator<T> GFIterator(List<T> list) { }

	[Extension]
	public static DictionaryIterator<T1, T2> GFIterator(Dictionary<T1, T2> dictionary) { }

	[Extension]
	public static HashsetIterator<T> GFIterator(HashSet<T> hashset) { }

	[Extension]
	public static DictionaryValueIterator<T1, T2> GFValueIterator(Dictionary<T1, T2> dictionary) { }

}

