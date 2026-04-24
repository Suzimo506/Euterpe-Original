namespace Unity.Collections;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeContainer]
[NativeContainerSupportsDeallocateOnJobCompletion]
[NativeContainerSupportsDeferredConvertListToArray]
[NativeContainerSupportsMinMaxWriteRestriction]
public struct NativeArray : IDisposable, IEnumerable<T>, IEnumerable, IEquatable<NativeArray`1<T>>
{
	[ExcludeFromDocs]
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private NativeArray<T> m_Array; //Field offset: 0x0
		private int m_Index; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 12
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 135
		}

		public Enumerator(ref NativeArray<T>& array) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[NativeDisableUnsafePtrRestriction]
	internal Void* m_Buffer; //Field offset: 0x0
	internal int m_Length; //Field offset: 0x0
	internal Allocator m_AllocatorLabel; //Field offset: 0x0

	public bool IsCreated
	{
		 get { } //Length: 8
	}

	public T Item
	{
		 get { } //Length: 135
		[WriteAccessRequired]
		 set { } //Length: 141
	}

	public int Length
	{
		 get { } //Length: 4
	}

	public NativeArray`1(int length, Allocator allocator, NativeArrayOptions options = 1) { }

	private static void Allocate(int length, Allocator allocator, out NativeArray<T>& array) { }

	public static void Copy(NativeArray<T> src, T[] dst, int length) { }

	public static void Copy(NativeArray<T> src, NativeArray<T> dst) { }

	public static void Copy(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }

	public static void Copy(NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length) { }

	[WriteAccessRequired]
	public void CopyFrom(NativeArray<T> array) { }

	private void Deallocate() { }

	[WriteAccessRequired]
	public override void Dispose() { }

	public override bool Equals(NativeArray<T> other) { }

	public virtual bool Equals(object obj) { }

	public bool get_IsCreated() { }

	public T get_Item(int index) { }

	public int get_Length() { }

	public Enumerator<T> GetEnumerator() { }

	public virtual int GetHashCode() { }

	[WriteAccessRequired]
	public void set_Item(int index, T value) { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public T[] ToArray() { }

}

