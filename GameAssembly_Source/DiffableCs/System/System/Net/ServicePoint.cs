namespace System.Net;

public class ServicePoint
{
	private readonly Uri uri; //Field offset: 0x10
	private int connectionLimit; //Field offset: 0x18
	private int maxIdleTime; //Field offset: 0x1C
	private int currentConnections; //Field offset: 0x20
	private DateTime idleSince; //Field offset: 0x28
	private DateTime lastDnsResolve; //Field offset: 0x30
	private Version protocolVersion; //Field offset: 0x38
	private IPHostEntry host; //Field offset: 0x40
	private bool usesProxy; //Field offset: 0x48
	private Dictionary<String, WebConnectionGroup> groups; //Field offset: 0x50
	private bool sendContinue; //Field offset: 0x58
	private bool useConnect; //Field offset: 0x59
	private object hostE; //Field offset: 0x60
	private bool useNagle; //Field offset: 0x68
	private BindIPEndPoint endPointCallback; //Field offset: 0x70
	private bool tcp_keepalive; //Field offset: 0x78
	private int tcp_keepalive_time; //Field offset: 0x7C
	private int tcp_keepalive_interval; //Field offset: 0x80
	private Timer idleTimer; //Field offset: 0x88
	private object m_ServerCertificateOrBytes; //Field offset: 0x90
	private object m_ClientCertificateOrBytes; //Field offset: 0x98

	public Uri Address
	{
		 get { } //Length: 5
	}

	public int ConnectionLimit
	{
		 get { } //Length: 4
	}

	public bool Expect100Continue
	{
		 set { } //Length: 4
	}

	private bool HasTimedOut
	{
		private get { } //Length: 305
	}

	internal IPHostEntry HostEntry
	{
		internal get { } //Length: 1263
	}

	public override Version ProtocolVersion
	{
		 get { } //Length: 5
	}

	internal bool SendContinue
	{
		internal get { } //Length: 228
		internal set { } //Length: 4
	}

	internal bool UseConnect
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	public bool UseNagleAlgorithm
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	internal bool UsesProxy
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal ServicePoint(Uri uri, int connectionLimit, int maxIdleTime) { }

	[CompilerGenerated]
	private void <GetConnectionGroup>b__66_0(object s, EventArgs e) { }

	internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote) { }

	private bool CheckAvailableForRecycling(out DateTime outIdleSince) { }

	public Uri get_Address() { }

	public int get_ConnectionLimit() { }

	private bool get_HasTimedOut() { }

	internal IPHostEntry get_HostEntry() { }

	public override Version get_ProtocolVersion() { }

	internal bool get_SendContinue() { }

	internal bool get_UseConnect() { }

	public bool get_UseNagleAlgorithm() { }

	internal bool get_UsesProxy() { }

	private WebConnectionGroup GetConnectionGroup(string name) { }

	private void IdleTimerCallback(object obj) { }

	internal void KeepAliveSetup(Socket socket) { }

	private static void PutBytes(Byte[] bytes, uint v, int offset) { }

	private void RemoveConnectionGroup(WebConnectionGroup group) { }

	internal EventHandler SendRequest(HttpWebRequest request, string groupName) { }

	public void set_Expect100Continue(bool value) { }

	internal void set_SendContinue(bool value) { }

	internal void set_UseConnect(bool value) { }

	public void set_UseNagleAlgorithm(bool value) { }

	internal void set_UsesProxy(bool value) { }

	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	internal void SetVersion(Version version) { }

	internal void UpdateClientCertificate(X509Certificate certificate) { }

	internal void UpdateServerCertificate(X509Certificate certificate) { }

}

