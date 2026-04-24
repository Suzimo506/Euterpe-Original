namespace Unity.Collections;

internal sealed class NativeArrayDebugView
{
	private NativeArray<T> m_Array; //Field offset: 0x0

	public T[] Items
	{
		 get { } //Length: 0
	}

	public NativeArrayDebugView`1(NativeArray<T> array) { }

	public T[] get_Items() { }

}

