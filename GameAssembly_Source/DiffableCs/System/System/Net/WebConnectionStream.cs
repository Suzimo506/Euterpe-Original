namespace System.Net;

internal class WebConnectionStream : Stream
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass75_0
	{
		public WebConnectionStream <>4__this; //Field offset: 0x10
		public bool setInternalLength; //Field offset: 0x18

		public <>c__DisplayClass75_0() { }

		internal bool <SetHeadersAsync>b__0(SimpleAsyncResult r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass76_0
	{
		public WebConnectionStream <>4__this; //Field offset: 0x10
		public SimpleAsyncResult result; //Field offset: 0x18

		public <>c__DisplayClass76_0() { }

		internal void <SetHeadersAsync>b__0(IAsyncResult r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass80_0
	{
		public SimpleAsyncResult result; //Field offset: 0x10
		public WebConnectionStream <>4__this; //Field offset: 0x18
		public int length; //Field offset: 0x20
		public Byte[] bytes; //Field offset: 0x28
		public AsyncCallback <>9__1; //Field offset: 0x30

		public <>c__DisplayClass80_0() { }

		internal void <WriteRequestAsync>b__0(SimpleAsyncResult inner) { }

		internal void <WriteRequestAsync>b__1(IAsyncResult r) { }

	}

	private static Byte[] crlf; //Field offset: 0x0
	private bool isRead; //Field offset: 0x28
	private WebConnection cnc; //Field offset: 0x30
	private HttpWebRequest request; //Field offset: 0x38
	private Byte[] readBuffer; //Field offset: 0x40
	private int readBufferOffset; //Field offset: 0x48
	private int readBufferSize; //Field offset: 0x4C
	private int stream_length; //Field offset: 0x50
	private long contentLength; //Field offset: 0x58
	private long totalRead; //Field offset: 0x60
	internal long totalWritten; //Field offset: 0x68
	private bool nextReadCalled; //Field offset: 0x70
	private int pendingReads; //Field offset: 0x74
	private int pendingWrites; //Field offset: 0x78
	private ManualResetEvent pending; //Field offset: 0x80
	private bool allowBuffering; //Field offset: 0x88
	private bool sendChunked; //Field offset: 0x89
	private MemoryStream writeBuffer; //Field offset: 0x90
	private bool requestWritten; //Field offset: 0x98
	private Byte[] headers; //Field offset: 0xA0
	private bool disposed; //Field offset: 0xA8
	private bool headersSent; //Field offset: 0xA9
	private object locker; //Field offset: 0xB0
	private bool initRead; //Field offset: 0xB8
	private bool read_eof; //Field offset: 0xB9
	private bool complete_request_written; //Field offset: 0xBA
	private int read_timeout; //Field offset: 0xBC
	private int write_timeout; //Field offset: 0xC0
	private AsyncCallback cb_wrapper; //Field offset: 0xC8
	internal bool IgnoreIOErrors; //Field offset: 0xD0
	[CompilerGenerated]
	private bool <GetResponseOnClose>k__BackingField; //Field offset: 0xD1

	public virtual bool CanRead
	{
		 get { } //Length: 17
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 20
	}

	internal bool CompleteRequestWritten
	{
		internal get { } //Length: 8
	}

	internal WebConnection Connection
	{
		internal get { } //Length: 5
	}

	internal bool GetResponseOnClose
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	public virtual long Length
	{
		 get { } //Length: 92
	}

	public virtual long Position
	{
		 get { } //Length: 73
		 set { } //Length: 73
	}

	internal Byte[] ReadBuffer
	{
		internal set { } //Length: 12
	}

	internal int ReadBufferOffset
	{
		internal set { } //Length: 4
	}

	internal int ReadBufferSize
	{
		internal set { } //Length: 4
	}

	public virtual int ReadTimeout
	{
		 get { } //Length: 7
	}

	internal bool RequestWritten
	{
		internal get { } //Length: 8
	}

	internal bool SendChunked
	{
		internal set { } //Length: 7
	}

	internal Byte[] WriteBuffer
	{
		internal get { } //Length: 42
	}

	internal int WriteBufferLength
	{
		internal get { } //Length: 35
	}

	public virtual int WriteTimeout
	{
		 get { } //Length: 7
	}

	private static WebConnectionStream() { }

	public WebConnectionStream(WebConnection cnc, WebConnectionData data) { }

	public WebConnectionStream(WebConnection cnc, HttpWebRequest request) { }

	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	private bool CheckAuthHeader(string headerName) { }

	internal void CheckComplete() { }

	internal void CheckResponseInBuffer() { }

	private void CheckWriteOverflow(long contentLength, long totalWritten, long size) { }

	public virtual void Close() { }

	public virtual int EndRead(IAsyncResult r) { }

	public virtual void EndWrite(IAsyncResult r) { }

	public virtual void Flush() { }

	internal void ForceCompletion() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	internal bool get_CompleteRequestWritten() { }

	internal WebConnection get_Connection() { }

	[CompilerGenerated]
	internal bool get_GetResponseOnClose() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual int get_ReadTimeout() { }

	internal bool get_RequestWritten() { }

	internal Byte[] get_WriteBuffer() { }

	internal int get_WriteBufferLength() { }

	public virtual int get_WriteTimeout() { }

	internal void InternalClose() { }

	private bool IsNtlmAuth() { }

	internal void KillBuffer() { }

	public virtual int Read(Byte[] buffer, int offset, int size) { }

	internal void ReadAll() { }

	private void ReadCallbackWrapper(IAsyncResult r) { }

	public virtual long Seek(long a, SeekOrigin b) { }

	public virtual void set_Position(long value) { }

	internal void set_ReadBuffer(Byte[] value) { }

	internal void set_ReadBufferOffset(int value) { }

	internal void set_ReadBufferSize(int value) { }

	internal void set_SendChunked(bool value) { }

	private bool SetHeadersAsync(SimpleAsyncResult result, bool setInternalLength) { }

	internal void SetHeadersAsync(bool setInternalLength, SimpleAsyncCallback callback) { }

	public virtual void SetLength(long a) { }

	public virtual void Write(Byte[] buffer, int offset, int size) { }

	private void WriteAsyncCB(IAsyncResult r) { }

	private void WriteCallbackWrapper(IAsyncResult r) { }

	internal bool WriteRequestAsync(SimpleAsyncResult result) { }

}

