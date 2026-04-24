namespace NAudio.Wave;

public class BlockAlignReductionStream : WaveStream
{
	private WaveStream sourceStream; //Field offset: 0x28
	private long position; //Field offset: 0x30
	private readonly CircularBuffer circularBuffer; //Field offset: 0x38
	private long bufferStartPosition; //Field offset: 0x40
	private Byte[] sourceBuffer; //Field offset: 0x48
	private readonly object lockObject; //Field offset: 0x50

	public virtual int BlockAlign
	{
		 get { } //Length: 99
	}

	private long BufferEndPosition
	{
		private get { } //Length: 31
	}

	public virtual long Length
	{
		 get { } //Length: 39
	}

	public virtual long Position
	{
		 get { } //Length: 5
		 set { } //Length: 449
	}

	public virtual WaveFormat WaveFormat
	{
		 get { } //Length: 39
	}

	public BlockAlignReductionStream(WaveStream sourceStream) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual int get_BlockAlign() { }

	private long get_BufferEndPosition() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual WaveFormat get_WaveFormat() { }

	private Byte[] GetSourceBuffer(int size) { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual void set_Position(long value) { }

}

