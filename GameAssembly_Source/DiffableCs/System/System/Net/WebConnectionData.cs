namespace System.Net;

internal class WebConnectionData
{
	private HttpWebRequest _request; //Field offset: 0x10
	public int StatusCode; //Field offset: 0x18
	public string StatusDescription; //Field offset: 0x20
	public WebHeaderCollection Headers; //Field offset: 0x28
	public Version Version; //Field offset: 0x30
	public Version ProxyVersion; //Field offset: 0x38
	public Stream stream; //Field offset: 0x40
	public String[] Challenge; //Field offset: 0x48
	private ReadState _readState; //Field offset: 0x50

	public ReadState ReadState
	{
		 get { } //Length: 4
		 set { } //Length: 226
	}

	public HttpWebRequest request
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public WebConnectionData() { }

	public WebConnectionData(HttpWebRequest request) { }

	public ReadState get_ReadState() { }

	public HttpWebRequest get_request() { }

	public void set_ReadState(ReadState value) { }

	public void set_request(HttpWebRequest value) { }

}

