namespace Sirenix.Serialization;

public sealed class Buffer : IDisposable
{
	private static readonly object LOCK; //Field offset: 0x0
	private static readonly List<Buffer`1<T>> FreeBuffers; //Field offset: 0x0
	private int count; //Field offset: 0x0
	private T[] array; //Field offset: 0x0
	private bool isFree; //Field offset: 0x0

	public T[] Array
	{
		 get { } //Length: 116
	}

	public int Count
	{
		 get { } //Length: 115
	}

	public bool IsFree
	{
		 get { } //Length: 24
	}

	private static Buffer`1() { }

	private Buffer`1(int count) { }

	public static Buffer<T> Claim(int minimumCapacity) { }

	public override void Dispose() { }

	public static void Free(Buffer<T> buffer) { }

	public void Free() { }

	public T[] get_Array() { }

	public int get_Count() { }

	public bool get_IsFree() { }

	private static int NextPowerOfTwo(int v) { }

}

