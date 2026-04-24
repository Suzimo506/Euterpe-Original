namespace System.Buffers;

[EventSource]
internal sealed class ArrayPoolEventSource : EventSource
{
	public enum BufferAllocatedReason
	{
		Pooled = 0,
		OverMaximumSize = 1,
		PoolExhausted = 2,
	}

	internal static readonly ArrayPoolEventSource Log; //Field offset: 0x2C927B4

	private static ArrayPoolEventSource() { }

	public ArrayPoolEventSource() { }

	[Event(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal void BufferAllocated(int bufferId, int bufferSize, int poolId, int bucketId, BufferAllocatedReason reason) { }

	[Event(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal void BufferRented(int bufferId, int bufferSize, int poolId, int bucketId) { }

	[Event(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal void BufferReturned(int bufferId, int bufferSize, int poolId) { }

}

