namespace System.Net.Sockets;

public class NetworkStream : Stream
{
	private Socket m_StreamSocket; //Field offset: 0x28
	private bool m_Readable; //Field offset: 0x30
	private bool m_Writeable; //Field offset: 0x31
	private bool m_OwnsSocket; //Field offset: 0x32
	private int m_CloseTimeout; //Field offset: 0x34
	private bool m_CleanedUp; //Field offset: 0x38
	private int m_CurrentReadTimeout; //Field offset: 0x3C
	private int m_CurrentWriteTimeout; //Field offset: 0x40

	public virtual bool CanRead
	{
		 get { } //Length: 5
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 5
	}

	public virtual long Length
	{
		 get { } //Length: 98
	}

	public virtual long Position
	{
		 get { } //Length: 98
		 set { } //Length: 98
	}

	public virtual int ReadTimeout
	{
		 get { } //Length: 129
	}

	public virtual int WriteTimeout
	{
		 get { } //Length: 129
	}

	public NetworkStream(Socket socket) { }

	public NetworkStream(Socket socket, bool ownsSocket) { }

	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual int EndRead(IAsyncResult asyncResult) { }

	public virtual void EndWrite(IAsyncResult asyncResult) { }

	protected virtual void Finalize() { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual int get_ReadTimeout() { }

	public virtual int get_WriteTimeout() { }

	internal void InitNetworkStream(Socket socket, FileAccess Access) { }

	public virtual int Read(out Byte[] buffer, int offset, int size) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int size) { }

}

