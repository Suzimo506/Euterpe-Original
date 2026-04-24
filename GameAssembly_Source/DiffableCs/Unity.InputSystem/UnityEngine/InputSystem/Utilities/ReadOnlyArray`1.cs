namespace UnityEngine.InputSystem.Utilities;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct ReadOnlyArray : IReadOnlyList<TValue>, IEnumerable<TValue>, IEnumerable, IReadOnlyCollection<TValue>
{
	internal struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
	{
		private readonly TValue[] m_Array; //Field offset: 0x0
		private readonly int m_IndexStart; //Field offset: 0x0
		private readonly int m_IndexEnd; //Field offset: 0x0
		private int m_Index; //Field offset: 0x0

		public override TValue Current
		{
			 get { } //Length: 139
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 62
		}

		internal Enumerator(TValue[] array, int index, int length) { }

		public override void Dispose() { }

		public override TValue get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	internal TValue[] m_Array; //Field offset: 0x0
	internal int m_StartIndex; //Field offset: 0x0
	internal int m_Length; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 4
	}

	public override TValue Item
	{
		 get { } //Length: 193
	}

	public ReadOnlyArray`1(TValue[] array) { }

	public ReadOnlyArray`1(TValue[] array, int index, int length) { }

	public override int get_Count() { }

	public override TValue get_Item(int index) { }

	public Enumerator<TValue> GetEnumerator() { }

	public int IndexOf(Predicate<TValue> predicate) { }

	public static ReadOnlyArray<TValue> op_Implicit(TValue[] array) { }

	private override IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public TValue[] ToArray() { }

}

