namespace System;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
[IsReadOnly]
public struct Memory
{
	private const int RemoveFlagsBitMask = 2147483647; //Field offset: 0x0
	private readonly object _object; //Field offset: 0x0
	private readonly int _index; //Field offset: 0x0
	private readonly int _length; //Field offset: 0x0

	public static Memory<T> Empty
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

	public Span<T> Span
	{
		 get { } //Length: 1091
	}

	public Memory`1(T[] array) { }

	internal Memory`1(T[] array, int start) { }

	public Memory`1(T[] array, int start, int length) { }

	internal Memory`1(MemoryManager<T> manager, int length) { }

	internal Memory`1(MemoryManager<T> manager, int start, int length) { }

	internal Memory`1(object obj, int start, int length) { }

	private static int CombineHashCodes(int left, int right) { }

	private static int CombineHashCodes(int h1, int h2, int h3) { }

	public void CopyTo(Memory<T> destination) { }

	public bool Equals(Memory<T> other) { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual bool Equals(object obj) { }

	public static Memory<T> get_Empty() { }

	public bool get_IsEmpty() { }

	public int get_Length() { }

	public Span<T> get_Span() { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual int GetHashCode() { }

	public static ReadOnlyMemory<T> op_Implicit(Memory<T> memory) { }

	public static Memory<T> op_Implicit(T[] array) { }

	public static Memory<T> op_Implicit(ArraySegment<T> segment) { }

	public MemoryHandle Pin() { }

	public Memory<T> Slice(int start, int length) { }

	public Memory<T> Slice(int start) { }

	public T[] ToArray() { }

	public virtual string ToString() { }

	public bool TryCopyTo(Memory<T> destination) { }

}

