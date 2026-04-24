namespace System;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class Lazy
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal T <.cctor>b__27_0() { }

	}

	private class Boxed
	{
		internal T m_value; //Field offset: 0x0

		internal Boxed(T value) { }

	}

	private class LazyInternalExceptionHolder
	{
		internal ExceptionDispatchInfo m_edi; //Field offset: 0x0

		internal LazyInternalExceptionHolder(Exception ex) { }

	}

	private static readonly Func<T> ALREADY_INVOKED_SENTINEL; //Field offset: 0x0
	private object m_boxed; //Field offset: 0x0
	private Func<T> m_valueFactory; //Field offset: 0x0
	private object m_threadSafeObj; //Field offset: 0x0

	public bool IsValueCreated
	{
		 get { } //Length: 88
	}

	internal bool IsValueFaulted
	{
		internal get { } //Length: 74
	}

	internal LazyThreadSafetyMode Mode
	{
		internal get { } //Length: 113
	}

	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public T Value
	{
		 get { } //Length: 325
	}

	internal T ValueForDebugDisplay
	{
		internal get { } //Length: 226
	}

	private static Lazy`1() { }

	public Lazy`1() { }

	public Lazy`1(Func<T> valueFactory) { }

	public Lazy`1(LazyThreadSafetyMode mode) { }

	public Lazy`1(Func<T> valueFactory, LazyThreadSafetyMode mode) { }

	private Boxed<T> CreateValue() { }

	public bool get_IsValueCreated() { }

	internal bool get_IsValueFaulted() { }

	internal LazyThreadSafetyMode get_Mode() { }

	public T get_Value() { }

	internal T get_ValueForDebugDisplay() { }

	private static object GetObjectFromMode(LazyThreadSafetyMode mode) { }

	private T LazyInitValue() { }

	[OnSerializing]
	private void OnSerializing(StreamingContext context) { }

	public virtual string ToString() { }

}

