namespace System.Net;

internal class WebConnection
{
	private class AbortHelper
	{
		public WebConnection Connection; //Field offset: 0x10

		public AbortHelper() { }

		public void Abort(object sender, EventArgs args) { }

	}

	private enum NtlmAuthState
	{
		None = 0,
		Challenge = 1,
		Response = 2,
	}

	private ServicePoint sPoint; //Field offset: 0x10
	private Stream nstream; //Field offset: 0x18
	internal Socket socket; //Field offset: 0x20
	private object socketLock; //Field offset: 0x28
	private IWebConnectionState state; //Field offset: 0x30
	private WebExceptionStatus status; //Field offset: 0x38
	private bool keepAlive; //Field offset: 0x3C
	private Byte[] buffer; //Field offset: 0x40
	private EventHandler abortHandler; //Field offset: 0x48
	private AbortHelper abortHelper; //Field offset: 0x50
	internal WebConnectionData Data; //Field offset: 0x58
	private bool chunkedRead; //Field offset: 0x60
	private MonoChunkStream chunkStream; //Field offset: 0x68
	private Queue queue; //Field offset: 0x70
	private bool reused; //Field offset: 0x78
	private int position; //Field offset: 0x7C
	private HttpWebRequest priority_request; //Field offset: 0x80
	private NetworkCredential ntlm_credentials; //Field offset: 0x88
	private bool ntlm_authenticated; //Field offset: 0x90
	private bool unsafe_sharing; //Field offset: 0x91
	private NtlmAuthState connect_ntlm_auth_state; //Field offset: 0x94
	private HttpWebRequest connect_request; //Field offset: 0x98
	private Exception connect_exception; //Field offset: 0xA0
	private MonoTlsStream tlsStream; //Field offset: 0xA8

	internal bool NtlmAuthenticated
	{
		internal get { } //Length: 8
		internal set { } //Length: 7
	}

	internal NetworkCredential NtlmCredential
	{
		internal get { } //Length: 8
		internal set { } //Length: 15
	}

	internal HttpWebRequest PriorityRequest
	{
		internal set { } //Length: 12
	}

	internal bool UnsafeAuthenticatedConnectionSharing
	{
		internal get { } //Length: 8
		internal set { } //Length: 7
	}

	public WebConnection(IWebConnectionState wcs, ServicePoint sPoint) { }

	[CompilerGenerated]
	private void <SendRequest>b__41_0(object o) { }

	private void Abort(object sender, EventArgs args) { }

	internal IAsyncResult BeginRead(HttpWebRequest request, Byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	internal IAsyncResult BeginWrite(HttpWebRequest request, Byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	private bool CanReuse() { }

	internal void Close(bool sendNext) { }

	private bool CompleteChunkedRead() { }

	private void Connect(HttpWebRequest request) { }

	private bool CreateStream(HttpWebRequest request) { }

	private bool CreateTunnel(HttpWebRequest request, Uri connectUri, Stream stream, out Byte[] buffer) { }

	internal int EndRead(HttpWebRequest request, IAsyncResult result) { }

	internal bool EndWrite(HttpWebRequest request, bool throwOnError, IAsyncResult result) { }

	private int EnsureRead(Byte[] buffer, int offset, int size) { }

	private static bool ExpectContent(int statusCode, string method) { }

	private void FlushContents(Stream stream, int contentLength) { }

	internal bool get_NtlmAuthenticated() { }

	internal NetworkCredential get_NtlmCredential() { }

	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	private static int GetResponse(WebConnectionData data, ServicePoint sPoint, Byte[] buffer, int max) { }

	private void HandleError(WebExceptionStatus st, Exception e, string where) { }

	private void InitConnection(HttpWebRequest request) { }

	internal void InitRead() { }

	internal void NextRead() { }

	internal int Read(HttpWebRequest request, Byte[] buffer, int offset, int size) { }

	private void ReadDone(IAsyncResult result) { }

	private WebHeaderCollection ReadHeaders(Stream stream, out Byte[] retBuffer, out int status) { }

	private static bool ReadLine(Byte[] buffer, ref int start, int max, ref string output) { }

	internal void ResetNtlm() { }

	private void SendNext() { }

	internal EventHandler SendRequest(HttpWebRequest request) { }

	internal void set_NtlmAuthenticated(bool value) { }

	internal void set_NtlmCredential(NetworkCredential value) { }

	internal void set_PriorityRequest(HttpWebRequest value) { }

	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }

	internal bool Write(HttpWebRequest request, Byte[] buffer, int offset, int size, ref string err_msg) { }

}

