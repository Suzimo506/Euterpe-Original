namespace System.Buffers;

public abstract class MemoryManager : IDisposable, IPinnable
{

	public override Memory<T> Memory
	{
		 get { } //Length: 127
	}

	protected abstract void Dispose(bool disposing) { }

	public override Memory<T> get_Memory() { }

	public abstract Span<T> GetSpan() { }

	public abstract MemoryHandle Pin(int elementIndex = 0) { }

	private override void System.IDisposable.Dispose() { }

	protected private override bool TryGetArray(out ArraySegment<T>& segment) { }

	public abstract void Unpin() { }

}

