namespace System.Net;

public sealed class HttpListenerContext
{
	private HttpListenerRequest request; //Field offset: 0x10
	private HttpListenerResponse response; //Field offset: 0x18
	private IPrincipal user; //Field offset: 0x20
	private HttpConnection cnc; //Field offset: 0x28
	private string error; //Field offset: 0x30
	private int err_status; //Field offset: 0x38
	internal HttpListener Listener; //Field offset: 0x40

	internal HttpConnection Connection
	{
		internal get { } //Length: 5
	}

	internal string ErrorMessage
	{
		internal get { } //Length: 5
		internal set { } //Length: 12
	}

	internal int ErrorStatus
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	internal bool HaveError
	{
		internal get { } //Length: 9
	}

	public HttpListenerRequest Request
	{
		 get { } //Length: 5
	}

	public HttpListenerResponse Response
	{
		 get { } //Length: 5
	}

	internal HttpListenerContext(HttpConnection cnc) { }

	internal HttpConnection get_Connection() { }

	internal string get_ErrorMessage() { }

	internal int get_ErrorStatus() { }

	internal bool get_HaveError() { }

	public HttpListenerRequest get_Request() { }

	public HttpListenerResponse get_Response() { }

	internal void ParseAuthentication(AuthenticationSchemes expectedSchemes) { }

	internal IPrincipal ParseBasicAuthentication(string authData) { }

	internal void set_ErrorMessage(string value) { }

	internal void set_ErrorStatus(int value) { }

}

