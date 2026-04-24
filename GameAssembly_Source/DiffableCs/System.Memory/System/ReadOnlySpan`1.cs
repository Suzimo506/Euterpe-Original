namespace System;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
[IsByRefLike]
[IsReadOnly]
[Obsolete]
public struct ReadOnlySpan
{
	[IsByRefLike]
	[Obsolete]
	internal struct Enumerator
	{
		private readonly ReadOnlySpan<T> _span; //Field offset: 0x0
		private int _index; //Field offset: 0x0

		internal Enumerator(ReadOnlySpan<T> span) { }

	}

	private readonly Pinnable<T> _pinnable; //Field offset: 0x0
	private readonly IntPtr _byteOffset; //Field offset: 0x0
	private readonly int _length; //Field offset: 0x0

	internal IntPtr ByteOffset
	{
		internal get { } //Length: 5
	}

	public static ReadOnlySpan<T> Empty
	{
		 get { } //Length: 36
	}

	public bool IsEmpty
	{
		 get { } //Length: 8
	}

	[IsReadOnly]
	public T Item
	{
		 get { } //Length: 316
	}

	public int Length
	{
		 get { } //Length: 4
	}

	internal Pinnable<T> Pinnable
	{
		internal get { } //Length: 4
	}

	internal ReadOnlySpan`1(Pinnable<T> pinnable, IntPtr byteOffset, int length) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public ReadOnlySpan`1(Void* pointer, int length) { }

	public ReadOnlySpan`1(T[] array, int start, int length) { }

	public ReadOnlySpan`1(T[] array) { }

	public void CopyTo(Span<T> destination) { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal T DangerousGetPinnableReference() { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public virtual bool Equals(object obj) { }

	internal IntPtr get_ByteOffset() { }

	public static ReadOnlySpan<T> get_Empty() { }

	public bool get_IsEmpty() { }

	public T get_Item(int index) { }

	public int get_Length() { }

	internal Pinnable<T> get_Pinnable() { }

	public Enumerator<T> GetEnumerator() { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public virtual int GetHashCode() { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public T GetPinnableReference() { }

	public static bool op_Equality(ReadOnlySpan<T> left, ReadOnlySpan<T> right) { }

	public static ReadOnlySpan<T> op_Implicit(T[] array) { }

	public static ReadOnlySpan<T> op_Implicit(ArraySegment<T> segment) { }

	public static bool op_Inequality(ReadOnlySpan<T> left, ReadOnlySpan<T> right) { }

	public ReadOnlySpan<T> Slice(int start) { }

	public ReadOnlySpan<T> Slice(int start, int length) { }

	public T[] ToArray() { }

	public virtual string ToString() { }

	public bool TryCopyTo(Span<T> destination) { }

}

