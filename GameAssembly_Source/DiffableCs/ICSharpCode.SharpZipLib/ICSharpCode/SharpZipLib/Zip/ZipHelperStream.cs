namespace ICSharpCode.SharpZipLib.Zip;

internal class ZipHelperStream : Stream
{
	private bool isOwner_; //Field offset: 0x28
	private Stream stream_; //Field offset: 0x30

	public virtual bool CanRead
	{
		 get { } //Length: 39
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 39
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 39
	}

	public virtual long Length
	{
		 get { } //Length: 39
	}

	public virtual long Position
	{
		 get { } //Length: 39
		 set { } //Length: 39
	}

	public ZipHelperStream(Stream stream) { }

	public virtual void Close() { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public long LocateBlockWithSignature(int signature, long endLocation, int minimumBlockSize, int maximumVariableData) { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public int ReadLEInt() { }

	public int ReadLEShort() { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

