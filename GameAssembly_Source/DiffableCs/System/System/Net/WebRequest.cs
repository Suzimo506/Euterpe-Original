namespace System.Net;

public abstract class WebRequest : MarshalByRefObject, ISerializable
{
	public class DesignerWebRequestCreate : IWebRequestCreate
	{

		public DesignerWebRequestCreate() { }

		public override WebRequest Create(Uri uri) { }

	}

	public class WebProxyWrapper : WebProxyWrapperOpaque
	{

		internal WebProxy WebProxy
		{
			internal get { } //Length: 5
		}

		internal WebProxy get_WebProxy() { }

	}

	public class WebProxyWrapperOpaque : IWebProxy
	{
		protected readonly WebProxy webProxy; //Field offset: 0x10

		public override ICredentials Credentials
		{
			 get { } //Length: 27
		}

		public override ICredentials get_Credentials() { }

		public override Uri GetProxy(Uri destination) { }

		public override bool IsBypassed(Uri host) { }

	}

	private static ArrayList s_PrefixList; //Field offset: 0x0
	private static object s_InternalSyncObject; //Field offset: 0x8
	private static Queue s_DefaultTimerQueue; //Field offset: 0x10
	private static DesignerWebRequestCreate webRequestCreate; //Field offset: 0x18
	private static IWebProxy s_DefaultWebProxy; //Field offset: 0x20
	private static bool s_DefaultWebProxyInitialized; //Field offset: 0x28
	private AuthenticationLevel m_AuthenticationLevel; //Field offset: 0x18
	private TokenImpersonationLevel m_ImpersonationLevel; //Field offset: 0x1C
	private RequestCachePolicy m_CachePolicy; //Field offset: 0x20
	private RequestCacheProtocol m_CacheProtocol; //Field offset: 0x28
	private RequestCacheBinding m_CacheBinding; //Field offset: 0x30

	public override RequestCachePolicy CachePolicy
	{
		 set { } //Length: 208
	}

	internal RequestCacheProtocol CacheProtocol
	{
		internal get { } //Length: 5
		internal set { } //Length: 12
	}

	public override long ContentLength
	{
		 get { } //Length: 53
	}

	public override ICredentials Credentials
	{
		 get { } //Length: 53
		 set { } //Length: 53
	}

	public static IWebProxy DefaultWebProxy
	{
		 get { } //Length: 72
	}

	public override WebHeaderCollection Headers
	{
		 get { } //Length: 53
	}

	internal static IWebProxy InternalDefaultWebProxy
	{
		internal get { } //Length: 501
	}

	private static object InternalSyncObject
	{
		private get { } //Length: 248
	}

	public override string Method
	{
		 get { } //Length: 53
		 set { } //Length: 53
	}

	internal static ArrayList PrefixList
	{
		internal get { } //Length: 431
	}

	public override IWebProxy Proxy
	{
		 get { } //Length: 53
		 set { } //Length: 53
	}

	public override Uri RequestUri
	{
		 get { } //Length: 53
	}

	public override int Timeout
	{
		 get { } //Length: 53
	}

	private static WebRequest() { }

	protected WebRequest() { }

	protected WebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public override void Abort() { }

	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	private static WebRequest Create(Uri requestUri, bool useUriBase) { }

	public static WebRequest Create(string requestUriString) { }

	public static WebRequest Create(Uri requestUri) { }

	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	internal RequestCacheProtocol get_CacheProtocol() { }

	public override long get_ContentLength() { }

	public override ICredentials get_Credentials() { }

	public static IWebProxy get_DefaultWebProxy() { }

	public override WebHeaderCollection get_Headers() { }

	internal static IWebProxy get_InternalDefaultWebProxy() { }

	private static object get_InternalSyncObject() { }

	public override string get_Method() { }

	internal static ArrayList get_PrefixList() { }

	public override IWebProxy get_Proxy() { }

	public override Uri get_RequestUri() { }

	public override int get_Timeout() { }

	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public override WebResponse GetResponse() { }

	private void InternalSetCachePolicy(RequestCachePolicy policy) { }

	private static ArrayList PopulatePrefixList() { }

	public override void set_CachePolicy(RequestCachePolicy value) { }

	internal void set_CacheProtocol(RequestCacheProtocol value) { }

	public override void set_Credentials(ICredentials value) { }

	public override void set_Method(string value) { }

	public override void set_Proxy(IWebProxy value) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

