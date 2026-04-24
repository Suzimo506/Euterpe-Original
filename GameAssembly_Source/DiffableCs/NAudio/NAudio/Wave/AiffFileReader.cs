namespace NAudio.Wave;

public class AiffFileReader : WaveStream
{
	internal struct AiffChunk
	{
		public string ChunkName; //Field offset: 0x0
		public uint ChunkLength; //Field offset: 0x8
		public uint ChunkStart; //Field offset: 0xC

		public AiffChunk(uint start, string name, uint length) { }

	}

	private readonly WaveFormat waveFormat; //Field offset: 0x28
	private readonly bool ownInput; //Field offset: 0x30
	private readonly long dataPosition; //Field offset: 0x38
	private readonly int dataChunkLength; //Field offset: 0x40
	private readonly List<AiffChunk> chunks; //Field offset: 0x48
	private Stream waveStream; //Field offset: 0x50
	private readonly object lockObject; //Field offset: 0x58

	public virtual long Length
	{
		 get { } //Length: 5
	}

	public virtual long Position
	{
		 get { } //Length: 49
		 set { } //Length: 310
	}

	public virtual WaveFormat WaveFormat
	{
		 get { } //Length: 5
	}

	public AiffFileReader(Stream inputStream) { }

	private static uint ConvertInt(Byte[] buffer) { }

	private static short ConvertShort(Byte[] buffer) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual WaveFormat get_WaveFormat() { }

	public virtual int Read(Byte[] array, int offset, int count) { }

	public static void ReadAiffHeader(Stream stream, out WaveFormat format, out long dataChunkPosition, out int dataChunkLength, List<AiffChunk> chunks) { }

	private static AiffChunk ReadChunkHeader(BinaryReader br) { }

	private static string ReadChunkName(BinaryReader br) { }

	public virtual void set_Position(long value) { }

}

