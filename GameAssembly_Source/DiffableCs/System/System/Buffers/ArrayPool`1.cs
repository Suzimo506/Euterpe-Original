namespace System.Buffers;

internal abstract class ArrayPool
{
	private static ArrayPool<T> s_sharedInstance; //Field offset: 0x0

	public static ArrayPool<T> Shared
	{
		 get { } //Length: 185
	}

	protected ArrayPool`1() { }

	public static ArrayPool<T> Create() { }

	private static ArrayPool<T> EnsureSharedCreated() { }

	public static ArrayPool<T> get_Shared() { }

	public abstract T[] Rent(int minimumLength) { }

	public abstract void Return(T[] array, bool clearArray = false) { }

}

