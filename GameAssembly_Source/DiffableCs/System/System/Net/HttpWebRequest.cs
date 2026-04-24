namespace System.Net;

public class HttpWebRequest : WebRequest, ISerializable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass238_0
	{
		public WebAsyncResult aread; //Field offset: 0x10
		public HttpWebRequest <>4__this; //Field offset: 0x18

		public <>c__DisplayClass238_0() { }

		internal void <BeginGetResponse>b__0(SimpleAsyncResult inner) { }

	}

	private struct AuthorizationState
	{
		private readonly HttpWebRequest request; //Field offset: 0x0
		private readonly bool isProxy; //Field offset: 0x8
		private bool isCompleted; //Field offset: 0x9
		private NtlmAuthState ntlm_auth_state; //Field offset: 0xC

		public bool IsCompleted
		{
			 get { } //Length: 5
		}

		public bool IsNtlmAuthenticated
		{
			 get { } //Length: 17
		}

		public NtlmAuthState NtlmAuthState
		{
			 get { } //Length: 4
		}

		public AuthorizationState(HttpWebRequest request, bool isProxy) { }

		public bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

		public bool get_IsCompleted() { }

		public bool get_IsNtlmAuthenticated() { }

		public NtlmAuthState get_NtlmAuthState() { }

		public void Reset() { }

		public virtual string ToString() { }

	}

	private enum NtlmAuthState
	{
		None = 0,
		Challenge = 1,
		Response = 2,
	}

	private static int defaultMaxResponseHeadersLength; //Field offset: 0x0
	private Uri requestUri; //Field offset: 0x38
	private Uri actualUri; //Field offset: 0x40
	private bool hostChanged; //Field offset: 0x48
	private bool allowAutoRedirect; //Field offset: 0x49
	private bool allowBuffering; //Field offset: 0x4A
	private X509CertificateCollection certificates; //Field offset: 0x50
	private string connectionGroup; //Field offset: 0x58
	private bool haveContentLength; //Field offset: 0x60
	private long contentLength; //Field offset: 0x68
	private HttpContinueDelegate continueDelegate; //Field offset: 0x70
	private CookieContainer cookieContainer; //Field offset: 0x78
	private ICredentials credentials; //Field offset: 0x80
	private bool haveResponse; //Field offset: 0x88
	private bool haveRequest; //Field offset: 0x89
	private bool requestSent; //Field offset: 0x8A
	private WebHeaderCollection webHeaders; //Field offset: 0x90
	private bool keepAlive; //Field offset: 0x98
	private int maxAutoRedirect; //Field offset: 0x9C
	private string mediaType; //Field offset: 0xA0
	private string method; //Field offset: 0xA8
	private string initialMethod; //Field offset: 0xB0
	private bool pipelined; //Field offset: 0xB8
	private bool preAuthenticate; //Field offset: 0xB9
	private bool usedPreAuth; //Field offset: 0xBA
	private Version version; //Field offset: 0xC0
	private bool force_version; //Field offset: 0xC8
	private Version actualVersion; //Field offset: 0xD0
	private IWebProxy proxy; //Field offset: 0xD8
	private bool sendChunked; //Field offset: 0xE0
	private ServicePoint servicePoint; //Field offset: 0xE8
	private int timeout; //Field offset: 0xF0
	private WebConnectionStream writeStream; //Field offset: 0xF8
	private HttpWebResponse webResponse; //Field offset: 0x100
	private WebAsyncResult asyncWrite; //Field offset: 0x108
	private WebAsyncResult asyncRead; //Field offset: 0x110
	private EventHandler abortHandler; //Field offset: 0x118
	private int aborted; //Field offset: 0x120
	private bool gotRequestStream; //Field offset: 0x124
	private int redirects; //Field offset: 0x128
	private bool expectContinue; //Field offset: 0x12C
	private Byte[] bodyBuffer; //Field offset: 0x130
	private int bodyBufferLength; //Field offset: 0x138
	private bool getResponseCalled; //Field offset: 0x13C
	private Exception saved_exc; //Field offset: 0x140
	private object locker; //Field offset: 0x148
	private bool finished_reading; //Field offset: 0x150
	internal WebConnection WebConnection; //Field offset: 0x158
	private DecompressionMethods auto_decomp; //Field offset: 0x160
	private int readWriteTimeout; //Field offset: 0x164
	private MonoTlsProvider tlsProvider; //Field offset: 0x168
	private MonoTlsSettings tlsSettings; //Field offset: 0x170
	private ServerCertValidationCallback certValidationCallback; //Field offset: 0x178
	private AuthorizationState auth_state; //Field offset: 0x180
	private AuthorizationState proxy_auth_state; //Field offset: 0x190
	private string host; //Field offset: 0x1A0
	internal Action<Stream> ResendContentFactory; //Field offset: 0x1A8
	[CompilerGenerated]
	private bool <ThrowOnError>k__BackingField; //Field offset: 0x1B0
	private bool unsafe_auth_blah; //Field offset: 0x1B1
	[CompilerGenerated]
	private bool <ReuseConnection>k__BackingField; //Field offset: 0x1B2
	internal WebConnection StoredConnection; //Field offset: 0x1B8

	internal bool Aborted
	{
		internal get { } //Length: 35
	}

	public internal Uri Address
	{
		 get { } //Length: 5
		internal set { } //Length: 12
	}

	public override bool AllowWriteStreamBuffering
	{
		 get { } //Length: 5
	}

	internal Uri AuthUri
	{
		internal get { } //Length: 5
	}

	public DecompressionMethods AutomaticDecompression
	{
		 get { } //Length: 7
	}

	public X509CertificateCollection ClientCertificates
	{
		 get { } //Length: 106
	}

	public virtual long ContentLength
	{
		 get { } //Length: 5
	}

	public virtual ICredentials Credentials
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	internal bool ExpectContinue
	{
		internal get { } //Length: 8
		internal set { } //Length: 7
	}

	internal bool FinishedReading
	{
		internal get { } //Length: 8
		internal set { } //Length: 7
	}

	public virtual WebHeaderCollection Headers
	{
		 get { } //Length: 8
	}

	public string Host
	{
		 get { } //Length: 46
	}

	internal bool InternalAllowBuffering
	{
		internal get { } //Length: 16
	}

	internal long InternalContentLength
	{
		internal set { } //Length: 5
	}

	public bool KeepAlive
	{
		 get { } //Length: 8
	}

	public virtual string Method
	{
		 get { } //Length: 8
		 set { } //Length: 376
	}

	private bool MethodWithBuffer
	{
		private get { } //Length: 175
	}

	public virtual IWebProxy Proxy
	{
		 get { } //Length: 8
		 set { } //Length: 159
	}

	internal bool ProxyQuery
	{
		internal get { } //Length: 46
	}

	public int ReadWriteTimeout
	{
		 get { } //Length: 7
	}

	public virtual Uri RequestUri
	{
		 get { } //Length: 5
	}

	internal bool ReuseConnection
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	public bool SendChunked
	{
		 get { } //Length: 8
	}

	internal ServerCertValidationCallback ServerCertValidationCallback
	{
		internal get { } //Length: 8
	}

	public ServicePoint ServicePoint
	{
		 get { } //Length: 7
	}

	internal ServicePoint ServicePointNoLock
	{
		internal get { } //Length: 8
	}

	internal bool ThrowOnError
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	public virtual int Timeout
	{
		 get { } //Length: 7
	}

	internal MonoTlsProvider TlsProvider
	{
		internal get { } //Length: 8
	}

	internal MonoTlsSettings TlsSettings
	{
		internal get { } //Length: 8
	}

	public string TransferEncoding
	{
		 get { } //Length: 73
	}

	public bool UnsafeAuthenticatedConnectionSharing
	{
		 get { } //Length: 8
	}

	private static HttpWebRequest() { }

	[Obsolete]
	protected HttpWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public HttpWebRequest() { }

	public HttpWebRequest(Uri uri) { }

	[CompilerGenerated]
	private void <SetWriteStream>b__258_0(SimpleAsyncResult result) { }

	[CompilerGenerated]
	private void <SetWriteStream>b__258_1(SimpleAsyncResult inner) { }

	[CompilerGenerated]
	private bool <SetWriteStreamInner>b__259_0(SimpleAsyncResult result) { }

	public virtual void Abort() { }

	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	private bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	private bool CheckFinalStatus(WebAsyncResult result) { }

	private bool CheckIfForceWrite(SimpleAsyncResult result) { }

	private void CheckRequestStarted() { }

	private void CheckSendError(WebConnectionData data) { }

	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	private void DoPreAuthenticate() { }

	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	internal bool get_Aborted() { }

	public Uri get_Address() { }

	public override bool get_AllowWriteStreamBuffering() { }

	internal Uri get_AuthUri() { }

	public DecompressionMethods get_AutomaticDecompression() { }

	public X509CertificateCollection get_ClientCertificates() { }

	public virtual long get_ContentLength() { }

	public virtual ICredentials get_Credentials() { }

	internal bool get_ExpectContinue() { }

	internal bool get_FinishedReading() { }

	public virtual WebHeaderCollection get_Headers() { }

	public string get_Host() { }

	internal bool get_InternalAllowBuffering() { }

	public bool get_KeepAlive() { }

	public virtual string get_Method() { }

	private bool get_MethodWithBuffer() { }

	public virtual IWebProxy get_Proxy() { }

	internal bool get_ProxyQuery() { }

	public int get_ReadWriteTimeout() { }

	public virtual Uri get_RequestUri() { }

	[CompilerGenerated]
	internal bool get_ReuseConnection() { }

	public bool get_SendChunked() { }

	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	public ServicePoint get_ServicePoint() { }

	internal ServicePoint get_ServicePointNoLock() { }

	[CompilerGenerated]
	internal bool get_ThrowOnError() { }

	public virtual int get_Timeout() { }

	internal MonoTlsProvider get_TlsProvider() { }

	internal MonoTlsSettings get_TlsSettings() { }

	public string get_TransferEncoding() { }

	public bool get_UnsafeAuthenticatedConnectionSharing() { }

	private string GetHeaders() { }

	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	internal Byte[] GetRequestHeaders() { }

	public virtual WebResponse GetResponse() { }

	internal ServicePoint GetServicePoint() { }

	private bool HandleNtlmAuth(WebAsyncResult r) { }

	private bool Redirect(WebAsyncResult result, HttpStatusCode code, WebResponse response) { }

	private void ResetAuthorization() { }

	private void RewriteRedirectToGet() { }

	internal void set_Address(Uri value) { }

	public virtual void set_Credentials(ICredentials value) { }

	internal void set_ExpectContinue(bool value) { }

	internal void set_FinishedReading(bool value) { }

	internal void set_InternalContentLength(long value) { }

	public virtual void set_Method(string value) { }

	public virtual void set_Proxy(IWebProxy value) { }

	[CompilerGenerated]
	internal void set_ReuseConnection(bool value) { }

	[CompilerGenerated]
	internal void set_ThrowOnError(bool value) { }

	internal void SetResponseData(WebConnectionData data) { }

	internal void SetResponseError(WebExceptionStatus status, Exception e, string where) { }

	internal void SetWriteStream(WebConnectionStream stream) { }

	private void SetWriteStreamError(Exception exc) { }

	internal void SetWriteStreamError(WebExceptionStatus status, Exception exc) { }

	private void SetWriteStreamInner(SimpleAsyncCallback callback) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

