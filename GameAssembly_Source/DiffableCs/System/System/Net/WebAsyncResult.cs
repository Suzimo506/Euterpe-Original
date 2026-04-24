namespace System.Net;

internal class WebAsyncResult : SimpleAsyncResult
{
	private int nbytes; //Field offset: 0x50
	private IAsyncResult innerAsyncResult; //Field offset: 0x58
	private HttpWebResponse response; //Field offset: 0x60
	private Stream writeStream; //Field offset: 0x68
	private Byte[] buffer; //Field offset: 0x70
	private int offset; //Field offset: 0x78
	private int size; //Field offset: 0x7C
	public bool EndCalled; //Field offset: 0x80
	public bool AsyncWriteAll; //Field offset: 0x81
	public HttpWebRequest AsyncObject; //Field offset: 0x88

	internal Byte[] Buffer
	{
		internal get { } //Length: 5
	}

	internal IAsyncResult InnerAsyncResult
	{
		internal get { } //Length: 5
		internal set { } //Length: 12
	}

	internal int NBytes
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	internal int Offset
	{
		internal get { } //Length: 4
	}

	internal HttpWebResponse Response
	{
		internal get { } //Length: 5
	}

	internal int Size
	{
		internal get { } //Length: 4
	}

	public WebAsyncResult(AsyncCallback cb, object state) { }

	public WebAsyncResult(HttpWebRequest request, AsyncCallback cb, object state) { }

	public WebAsyncResult(AsyncCallback cb, object state, Byte[] buffer, int offset, int size) { }

	internal void DoCallback() { }

	internal Byte[] get_Buffer() { }

	internal IAsyncResult get_InnerAsyncResult() { }

	internal int get_NBytes() { }

	internal int get_Offset() { }

	internal HttpWebResponse get_Response() { }

	internal int get_Size() { }

	internal void Reset() { }

	internal void set_InnerAsyncResult(IAsyncResult value) { }

	internal void set_NBytes(int value) { }

	internal void SetCompleted(bool synch, int nbytes) { }

	internal void SetCompleted(bool synch, Stream writeStream) { }

	internal void SetCompleted(bool synch, HttpWebResponse response) { }

}

