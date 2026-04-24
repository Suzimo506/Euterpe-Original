namespace System;

internal sealed class System_LazyDebugView
{
	private readonly Lazy<T> m_lazy; //Field offset: 0x0

	public bool IsValueCreated
	{
		 get { } //Length: 42
	}

	public bool IsValueFaulted
	{
		 get { } //Length: 43
	}

	public LazyThreadSafetyMode Mode
	{
		 get { } //Length: 43
	}

	public T Value
	{
		 get { } //Length: 43
	}

	public System_LazyDebugView`1(Lazy<T> lazy) { }

	public bool get_IsValueCreated() { }

	public bool get_IsValueFaulted() { }

	public LazyThreadSafetyMode get_Mode() { }

	public T get_Value() { }

}

