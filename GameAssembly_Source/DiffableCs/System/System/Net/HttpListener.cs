namespace System.Net;

public sealed class HttpListener : IDisposable
{
	internal sealed class ExtendedProtectionSelector : MulticastDelegate
	{

		public ExtendedProtectionSelector(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(HttpListenerRequest request, AsyncCallback callback, object object) { }

		public override ExtendedProtectionPolicy EndInvoke(IAsyncResult result) { }

		public override ExtendedProtectionPolicy Invoke(HttpListenerRequest request) { }

	}

	private MonoTlsProvider tlsProvider; //Field offset: 0x10
	private MonoTlsSettings tlsSettings; //Field offset: 0x18
	private X509Certificate certificate; //Field offset: 0x20
	private AuthenticationSchemes auth_schemes; //Field offset: 0x28
	private HttpListenerPrefixCollection prefixes; //Field offset: 0x30
	private AuthenticationSchemeSelector auth_selector; //Field offset: 0x38
	private string realm; //Field offset: 0x40
	private bool ignore_write_exceptions; //Field offset: 0x48
	private bool unsafe_ntlm_auth; //Field offset: 0x49
	private bool listening; //Field offset: 0x4A
	private bool disposed; //Field offset: 0x4B
	private readonly object _internalLock; //Field offset: 0x50
	private Hashtable registry; //Field offset: 0x58
	private ArrayList ctx_queue; //Field offset: 0x60
	private ArrayList wait_queue; //Field offset: 0x68
	private Hashtable connections; //Field offset: 0x70
	private ServiceNameStore defaultServiceNames; //Field offset: 0x78
	private ExtendedProtectionPolicy extendedProtectionPolicy; //Field offset: 0x80
	private ExtendedProtectionSelector extendedProtectionSelectorDelegate; //Field offset: 0x88

	public AuthenticationSchemes AuthenticationSchemes
	{
		 get { } //Length: 4
		 set { } //Length: 36
	}

	public AuthenticationSchemeSelector AuthenticationSchemeSelectorDelegate
	{
		 get { } //Length: 5
	}

	public bool IgnoreWriteExceptions
	{
		 get { } //Length: 5
	}

	public bool IsListening
	{
		 get { } //Length: 5
	}

	public HttpListenerPrefixCollection Prefixes
	{
		 get { } //Length: 26
	}

	public string Realm
	{
		 get { } //Length: 5
	}

	public HttpListener() { }

	internal void AddConnection(HttpConnection cnc) { }

	public IAsyncResult BeginGetContext(AsyncCallback callback, object state) { }

	internal void CheckDisposed() { }

	private void Cleanup(bool close_existing) { }

	private void Close(bool force) { }

	internal SslStream CreateSslStream(Stream innerStream, bool ownsStream, RemoteCertificateValidationCallback callback) { }

	public HttpListenerContext EndGetContext(IAsyncResult asyncResult) { }

	public AuthenticationSchemes get_AuthenticationSchemes() { }

	public AuthenticationSchemeSelector get_AuthenticationSchemeSelectorDelegate() { }

	public bool get_IgnoreWriteExceptions() { }

	public bool get_IsListening() { }

	public HttpListenerPrefixCollection get_Prefixes() { }

	public string get_Realm() { }

	private HttpListenerContext GetContextFromQueue() { }

	internal X509Certificate LoadCertificateAndKey(IPAddress addr, int port) { }

	internal void RegisterContext(HttpListenerContext context) { }

	internal void RemoveConnection(HttpConnection cnc) { }

	internal AuthenticationSchemes SelectAuthenticationScheme(HttpListenerContext context) { }

	public void set_AuthenticationSchemes(AuthenticationSchemes value) { }

	public void Start() { }

	private override void System.IDisposable.Dispose() { }

	internal void UnregisterContext(HttpListenerContext context) { }

}

