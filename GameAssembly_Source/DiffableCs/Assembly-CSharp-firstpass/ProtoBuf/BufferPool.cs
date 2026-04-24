namespace ProtoBuf;

internal sealed class BufferPool
{
	private const int PoolSize = 20; //Field offset: 0x64EBE
	private static readonly Object[] pool; //Field offset: 0x64EC0
	internal const int BufferLength = 1024; //Field offset: 0x2C927B4

	private static BufferPool() { }

	private BufferPool() { }

	internal static void Flush() { }

	internal static Byte[] GetBuffer() { }

	internal static void ReleaseBufferToPool(ref Byte[] buffer) { }

	internal static void ResizeAndFlushLeft(ref Byte[] buffer, int toFitAtLeastBytes, int copyFromIndex, int copyBytes) { }

}

