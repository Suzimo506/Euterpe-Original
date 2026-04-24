namespace UnityEngine.UIElements;

internal class ObjectPool
{
	private readonly Stack<T> m_Stack; //Field offset: 0x0
	private int m_MaxSize; //Field offset: 0x0

	public int maxSize
	{
		 get { } //Length: 6
		 set { } //Length: 164
	}

	public ObjectPool`1(int maxSize = 100) { }

	public T Get() { }

	public int get_maxSize() { }

	public void Release(T element) { }

	public void set_maxSize(int value) { }

	public int Size() { }

}

