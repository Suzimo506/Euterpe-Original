namespace System.Buffers;

internal sealed class DefaultArrayPool : ArrayPool<T>
{
	private sealed class Bucket
	{
		internal readonly int _bufferLength; //Field offset: 0x0
		private readonly T[][] _buffers; //Field offset: 0x0
		private readonly int _poolId; //Field offset: 0x0
		private SpinLock _lock; //Field offset: 0x0
		private int _index; //Field offset: 0x0

		internal int Id
		{
			internal get { } //Length: 35
		}

		internal Bucket(int bufferLength, int numberOfBuffers, int poolId) { }

		internal int get_Id() { }

		internal T[] Rent() { }

		internal void Return(T[] array) { }

	}

	private static T[] s_emptyArray; //Field offset: 0x0
	private readonly Bucket<T>[] _buckets; //Field offset: 0x0

	private int Id
	{
		private get { } //Length: 35
	}

	internal DefaultArrayPool`1() { }

	internal DefaultArrayPool`1(int maxArrayLength, int maxArraysPerBucket) { }

	private int get_Id() { }

	public virtual T[] Rent(int minimumLength) { }

	public virtual void Return(T[] array, bool clearArray = false) { }

}

