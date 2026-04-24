namespace NVorbis;

internal class BufferedReadStream : Stream
{
	private Stream _baseStream; //Field offset: 0x28
	private StreamReadBuffer _buffer; //Field offset: 0x30
	private long _readPosition; //Field offset: 0x38
	private object _localLock; //Field offset: 0x40
	private Thread _owningThread; //Field offset: 0x48
	private int _lockCount; //Field offset: 0x50
	[CompilerGenerated]
	private bool <CloseBaseStream>k__BackingField; //Field offset: 0x54

	public virtual bool CanRead
	{
		 get { } //Length: 3
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 3
	}

	public bool CloseBaseStream
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public virtual long Length
	{
		 get { } //Length: 39
	}

	public virtual long Position
	{
		 get { } //Length: 5
		 set { } //Length: 20
	}

	public BufferedReadStream(Stream baseStream) { }

	public BufferedReadStream(Stream baseStream, int initialSize, int maxBufferSize, bool minimalRead) { }

	private void CheckLock() { }

	public void DiscardThrough(long offset) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	[CompilerGenerated]
	public bool get_CloseBaseStream() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual int ReadByte() { }

	public void ReleaseLock() { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	[CompilerGenerated]
	public void set_CloseBaseStream(bool value) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public void TakeLock() { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

