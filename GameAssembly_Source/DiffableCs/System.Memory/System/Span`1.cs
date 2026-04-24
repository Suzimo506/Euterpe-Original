namespace System;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
[IsByRefLike]
[IsReadOnly]
[Obsolete]
public struct Span
{
	[IsByRefLike]
	[Obsolete]
	internal struct Enumerator
	{
		private readonly Span<T> _span; //Field offset: 0x0
		private int _index; //Field offset: 0x0

		internal Enumerator(Span<T> span) { }

	}

	private readonly Pinnable<T> _pinnable; //Field offset: 0x0
	private readonly IntPtr _byteOffset; //Field offset: 0x0
	private readonly int _length; //Field offset: 0x0

	internal IntPtr ByteOffset
	{
		internal get { } //Length: 5
	}

	public static Span<T> Empty
	{
		 get { } //Length: 36
	}

	public bool IsEmpty
	{
		 get { } //Length: 8
	}

	public T Item
	{
		 get { } //Length: 322
	}

	public int Length
	{
		 get { } //Length: 4
	}

	internal Pinnable<T> Pinnable
	{
		internal get { } //Length: 4
	}

	internal Span`1(Pinnable<T> pinnable, IntPtr byteOffset, int length) { }

	public Span`1(T[] array) { }

	public Span`1(T[] array, int start, int length) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Span`1(Void* pointer, int length) { }

	public void Clear() { }

	public void CopyTo(Span<T> destination) { }

	internal static Span<T> Create(T[] array, int start) { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal T DangerousGetPinnableReference() { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public virtual bool Equals(object obj) { }

	public void Fill(T value) { }

	internal IntPtr get_ByteOffset() { }

	public static Span<T> get_Empty() { }

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

	public static bool op_Equality(Span<T> left, Span<T> right) { }

	public static Span<T> op_Implicit(ArraySegment<T> segment) { }

	public static Span<T> op_Implicit(T[] array) { }

	public static ReadOnlySpan<T> op_Implicit(Span<T> span) { }

	public static bool op_Inequality(Span<T> left, Span<T> right) { }

	public Span<T> Slice(int start) { }

	public Span<T> Slice(int start, int length) { }

	public T[] ToArray() { }

	public virtual string ToString() { }

	public bool TryCopyTo(Span<T> destination) { }

}

