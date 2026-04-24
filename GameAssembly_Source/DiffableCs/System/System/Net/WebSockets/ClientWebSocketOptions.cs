namespace System.Net.WebSockets;

public sealed class ClientWebSocketOptions
{
	private bool _isReadOnly; //Field offset: 0x10
	private readonly List<String> _requestedSubProtocols; //Field offset: 0x18
	private readonly WebHeaderCollection _requestHeaders; //Field offset: 0x20
	private TimeSpan _keepAliveInterval; //Field offset: 0x28
	private bool _useDefaultCredentials; //Field offset: 0x30
	private ICredentials _credentials; //Field offset: 0x38
	private IWebProxy _proxy; //Field offset: 0x40
	private X509CertificateCollection _clientCertificates; //Field offset: 0x48
	private CookieContainer _cookies; //Field offset: 0x50
	private int _receiveBufferSize; //Field offset: 0x58
	private int _sendBufferSize; //Field offset: 0x5C
	private Nullable<ArraySegment`1<Byte>> _buffer; //Field offset: 0x60

	internal Nullable<ArraySegment`1<Byte>> Buffer
	{
		internal get { } //Length: 21
	}

	public X509CertificateCollection ClientCertificates
	{
		 get { } //Length: 106
	}

	public CookieContainer Cookies
	{
		 get { } //Length: 5
	}

	public TimeSpan KeepAliveInterval
	{
		 get { } //Length: 5
	}

	internal int ReceiveBufferSize
	{
		internal get { } //Length: 4
	}

	internal List<String> RequestedSubProtocols
	{
		internal get { } //Length: 5
	}

	internal WebHeaderCollection RequestHeaders
	{
		internal get { } //Length: 5
	}

	internal int SendBufferSize
	{
		internal get { } //Length: 4
	}

	internal ClientWebSocketOptions() { }

	internal Nullable<ArraySegment`1<Byte>> get_Buffer() { }

	public X509CertificateCollection get_ClientCertificates() { }

	public CookieContainer get_Cookies() { }

	public TimeSpan get_KeepAliveInterval() { }

	internal int get_ReceiveBufferSize() { }

	internal List<String> get_RequestedSubProtocols() { }

	internal WebHeaderCollection get_RequestHeaders() { }

	internal int get_SendBufferSize() { }

	internal void SetToReadOnly() { }

}

