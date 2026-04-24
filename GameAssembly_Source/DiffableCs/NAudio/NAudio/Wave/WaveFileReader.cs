namespace NAudio.Wave;

public class WaveFileReader : WaveStream
{
	private readonly WaveFormat waveFormat; //Field offset: 0x28
	private readonly bool ownInput; //Field offset: 0x30
	private readonly long dataPosition; //Field offset: 0x38
	private readonly long dataChunkLength; //Field offset: 0x40
	private readonly List<RiffChunk> chunks; //Field offset: 0x48
	private readonly object lockObject; //Field offset: 0x50
	private Stream waveStream; //Field offset: 0x58

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

	public WaveFileReader(Stream inputStream) { }

	private WaveFileReader(Stream inputStream, bool ownInput) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual WaveFormat get_WaveFormat() { }

	public virtual int Read(Byte[] array, int offset, int count) { }

	public virtual void set_Position(long value) { }

}

