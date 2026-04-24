namespace System;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
[IsReadOnly]
public struct ReadOnlyMemory
{
	internal const int RemoveFlagsBitMask = 2147483647; //Field offset: 0x0
	private readonly object _object; //Field offset: 0x0
	private readonly int _index; //Field offset: 0x0
	private readonly int _length; //Field offset: 0x0

	public static ReadOnlyMemory<T> Empty
	{
		 get { } //Length: 10
	}

	public bool IsEmpty
	{
		 get { } //Length: 11
	}

	public int Length
	{
		 get { } //Length: 8
	}

	public ReadOnlySpan<T> Span
	{
		 get { } //Length: 1187
	}

	public ReadOnlyMemory`1(T[] array) { }

	public ReadOnlyMemory`1(T[] array, int start, int length) { }

	internal ReadOnlyMemory`1(object obj, int start, int length) { }

	private static int CombineHashCodes(int left, int right) { }

	private static int CombineHashCodes(int h1, int h2, int h3) { }

	public void CopyTo(Memory<T> destination) { }

	public bool Equals(ReadOnlyMemory<T> other) { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual bool Equals(object obj) { }

	public static ReadOnlyMemory<T> get_Empty() { }

	public bool get_IsEmpty() { }

	public int get_Length() { }

	public ReadOnlySpan<T> get_Span() { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual int GetHashCode() { }

	internal object GetObjectStartLength(out int start, out int length) { }

	public static ReadOnlyMemory<T> op_Implicit(ArraySegment<T> segment) { }

	public static ReadOnlyMemory<T> op_Implicit(T[] array) { }

	public MemoryHandle Pin() { }

	public ReadOnlyMemory<T> Slice(int start) { }

	public ReadOnlyMemory<T> Slice(int start, int length) { }

	public T[] ToArray() { }

	public virtual string ToString() { }

	public bool TryCopyTo(Memory<T> destination) { }

}

