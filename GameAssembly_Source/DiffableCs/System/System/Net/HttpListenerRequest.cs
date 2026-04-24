namespace System.Net;

public sealed class HttpListenerRequest
{
	private static Byte[] _100continue; //Field offset: 0x0
	private static Char[] separators; //Field offset: 0x8
	private String[] accept_types; //Field offset: 0x10
	private Encoding content_encoding; //Field offset: 0x18
	private long content_length; //Field offset: 0x20
	private bool cl_set; //Field offset: 0x28
	private CookieCollection cookies; //Field offset: 0x30
	private WebHeaderCollection headers; //Field offset: 0x38
	private string method; //Field offset: 0x40
	private Stream input_stream; //Field offset: 0x48
	private Version version; //Field offset: 0x50
	private NameValueCollection query_string; //Field offset: 0x58
	private string raw_url; //Field offset: 0x60
	private Uri url; //Field offset: 0x68
	private Uri referrer; //Field offset: 0x70
	private String[] user_languages; //Field offset: 0x78
	private HttpListenerContext context; //Field offset: 0x80
	private bool is_chunked; //Field offset: 0x88
	private bool ka_set; //Field offset: 0x89
	private bool keep_alive; //Field offset: 0x8A

	public Encoding ContentEncoding
	{
		 get { } //Length: 49
	}

	public bool HasEntityBody
	{
		 get { } //Length: 17
	}

	public NameValueCollection Headers
	{
		 get { } //Length: 5
	}

	public string HttpMethod
	{
		 get { } //Length: 5
	}

	public Stream InputStream
	{
		 get { } //Length: 190
	}

	public bool IsSecureConnection
	{
		 get { } //Length: 39
	}

	public bool KeepAlive
	{
		 get { } //Length: 391
	}

	public IPEndPoint LocalEndPoint
	{
		 get { } //Length: 219
	}

	public Version ProtocolVersion
	{
		 get { } //Length: 5
	}

	public NameValueCollection QueryString
	{
		 get { } //Length: 5
	}

	public Uri Url
	{
		 get { } //Length: 5
	}

	public string UserHostAddress
	{
		 get { } //Length: 45
	}

	public string UserHostName
	{
		 get { } //Length: 70
	}

	private static HttpListenerRequest() { }

	internal HttpListenerRequest(HttpListenerContext context) { }

	internal void AddHeader(string header) { }

	private void CreateQueryString(string query) { }

	internal void FinishInitialization() { }

	internal bool FlushInput() { }

	public Encoding get_ContentEncoding() { }

	public bool get_HasEntityBody() { }

	public NameValueCollection get_Headers() { }

	public string get_HttpMethod() { }

	public Stream get_InputStream() { }

	public bool get_IsSecureConnection() { }

	public bool get_KeepAlive() { }

	public IPEndPoint get_LocalEndPoint() { }

	public Version get_ProtocolVersion() { }

	public NameValueCollection get_QueryString() { }

	public Uri get_Url() { }

	public string get_UserHostAddress() { }

	public string get_UserHostName() { }

	private static bool IsPredefinedScheme(string scheme) { }

	private static bool MaybeUri(string s) { }

	internal void SetRequestLine(string req) { }

	internal static string Unquote(string str) { }

}

