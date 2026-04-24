namespace System;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
[IsByRefLike]
[IsReadOnly]
[Obsolete]
public struct ReadOnlySpan
{
	private readonly Pinnable<T> _pinnable; //Field offset: 0x0
	private readonly IntPtr _byteOffset; //Field offset: 0x0
	private readonly int _length; //Field offset: 0x0

	internal IntPtr ByteOffset
	{
		internal get { } //Length: 5
	}

	private string DebuggerDisplay
	{
		private get { } //Length: 204
	}

	public T Item
	{
		 get { } //Length: 308
	}

	public int Length
	{
		 get { } //Length: 4
	}

	internal Pinnable<T> Pinnable
	{
		internal get { } //Length: 4
	}

	public ReadOnlySpan`1(T[] array) { }

	public ReadOnlySpan`1(Void* pointer, int length) { }

	public T DangerousGetPinnableReference() { }

	[Obsolete]
	public virtual bool Equals(object obj) { }

	internal IntPtr get_ByteOffset() { }

	private string get_DebuggerDisplay() { }

	public T get_Item(int index) { }

	public int get_Length() { }

	internal Pinnable<T> get_Pinnable() { }

	[Obsolete]
	public virtual int GetHashCode() { }

}

