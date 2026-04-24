namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams;

public class InflaterInputStream : Stream
{
	protected Inflater inf; //Field offset: 0x28
	protected InflaterInputBuffer inputBuffer; //Field offset: 0x30
	private Stream baseInputStream; //Field offset: 0x38
	private bool isClosed; //Field offset: 0x40
	private bool isStreamOwner; //Field offset: 0x41

	public virtual bool CanRead
	{
		 get { } //Length: 39
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 3
	}

	public virtual long Length
	{
		 get { } //Length: 27
	}

	public virtual long Position
	{
		 get { } //Length: 39
		 set { } //Length: 81
	}

	public InflaterInputStream(Stream baseInputStream, Inflater inf) { }

	public InflaterInputStream(Stream baseInputStream, Inflater inflater, int bufferSize) { }

	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	public virtual void Close() { }

	protected void Fill() { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

	public virtual void WriteByte(byte value) { }

}

