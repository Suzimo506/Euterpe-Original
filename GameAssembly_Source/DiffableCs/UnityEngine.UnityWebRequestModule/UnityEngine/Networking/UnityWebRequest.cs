namespace UnityEngine.Networking;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class UnityWebRequest : IDisposable
{
	public enum UnityWebRequestError
	{
		OK = 0,
		Unknown = 1,
		SDKError = 2,
		UnsupportedProtocol = 3,
		MalformattedUrl = 4,
		CannotResolveProxy = 5,
		CannotResolveHost = 6,
		CannotConnectToHost = 7,
		AccessDenied = 8,
		GenericHttpError = 9,
		WriteError = 10,
		ReadError = 11,
		OutOfMemory = 12,
		Timeout = 13,
		HTTPPostError = 14,
		SSLCannotConnect = 15,
		Aborted = 16,
		TooManyRedirects = 17,
		ReceivedNoData = 18,
		SSLNotSupported = 19,
		FailedToSendData = 20,
		FailedToReceiveData = 21,
		SSLCertificateError = 22,
		SSLCipherNotAvailable = 23,
		SSLCACertError = 24,
		UnrecognizedContentEncoding = 25,
		LoginFailed = 26,
		SSLShutdownFailed = 27,
		NoInternetConnection = 28,
	}

	public enum UnityWebRequestMethod
	{
		Get = 0,
		Post = 1,
		Put = 2,
		Head = 3,
		Custom = 4,
	}

	public const string kHttpVerbGET = "GET"; //Field offset: 0x0
	public const string kHttpVerbHEAD = "HEAD"; //Field offset: 0x0
	public const string kHttpVerbPOST = "POST"; //Field offset: 0x0
	public const string kHttpVerbPUT = "PUT"; //Field offset: 0x0
	public const string kHttpVerbCREATE = "CREATE"; //Field offset: 0x0
	public const string kHttpVerbDELETE = "DELETE"; //Field offset: 0x0
	internal IntPtr m_Ptr; //Field offset: 0x10
	internal DownloadHandler m_DownloadHandler; //Field offset: 0x18
	internal UploadHandler m_UploadHandler; //Field offset: 0x20
	internal CertificateHandler m_CertificateHandler; //Field offset: 0x28
	internal Uri m_Uri; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; //Field offset: 0x39
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <disposeUploadHandlerOnDispose>k__BackingField; //Field offset: 0x3A

	public CertificateHandler certificateHandler
	{
		 get { } //Length: 7
		 set { } //Length: 256
	}

	[Obsolete]
	public bool chunkedTransfer
	{
		 set { } //Length: 243
	}

	public bool disposeCertificateHandlerOnDispose
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool disposeDownloadHandlerOnDispose
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool disposeUploadHandlerOnDispose
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ulong downloadedBytes
	{
		 get { } //Length: 51
	}

	public DownloadHandler downloadHandler
	{
		 get { } //Length: 7
		 set { } //Length: 256
	}

	public string error
	{
		 get { } //Length: 416
	}

	public bool isDone
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public bool isHttpError
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public bool isModifiable
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public bool isNetworkError
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public string method
	{
		 get { } //Length: 185
		 set { } //Length: 515
	}

	public int redirectLimit
	{
		 set { } //Length: 64
	}

	public long responseCode
	{
		 get { } //Length: 51
	}

	public int timeout
	{
		 set { } //Length: 292
	}

	public UploadHandler uploadHandler
	{
		 get { } //Length: 7
		 set { } //Length: 256
	}

	public string url
	{
		 get { } //Length: 51
		 set { } //Length: 333
	}

	public UnityWebRequest(string url) { }

	public UnityWebRequest(string url, string method) { }

	public UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	[NativeMethod]
	public void Abort() { }

	[NativeThrows]
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	internal static IntPtr Create() { }

	public override void Dispose() { }

	private void DisposeHandlers() { }

	public static string EscapeURL(string s, Encoding e) { }

	protected virtual void Finalize() { }

	public static UnityWebRequest Get(string uri) { }

	public CertificateHandler get_certificateHandler() { }

	[CompilerGenerated]
	public bool get_disposeCertificateHandlerOnDispose() { }

	[CompilerGenerated]
	public bool get_disposeDownloadHandlerOnDispose() { }

	[CompilerGenerated]
	public bool get_disposeUploadHandlerOnDispose() { }

	public ulong get_downloadedBytes() { }

	public DownloadHandler get_downloadHandler() { }

	public string get_error() { }

	[NativeMethod]
	public bool get_isDone() { }

	[NativeMethod]
	public bool get_isHttpError() { }

	[NativeMethod]
	public bool get_isModifiable() { }

	[NativeMethod]
	public bool get_isNetworkError() { }

	public string get_method() { }

	public long get_responseCode() { }

	public UploadHandler get_uploadHandler() { }

	public string get_url() { }

	internal string GetCustomMethod() { }

	private UnityWebRequestError GetError() { }

	[VisibleToOtherModules]
	internal static string GetHTTPStatusString(long responseCode) { }

	internal UnityWebRequestMethod GetMethod() { }

	public string GetResponseHeader(string name) { }

	internal String[] GetResponseHeaderKeys() { }

	public Dictionary<String, String> GetResponseHeaders() { }

	private string GetUrl() { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[NativeMethod]
	private static string GetWebErrorString(UnityWebRequestError err) { }

	internal void InternalDestroy() { }

	internal void InternalSetCustomMethod(string customMethodName) { }

	private void InternalSetDefaults() { }

	internal void InternalSetMethod(UnityWebRequestMethod methodType) { }

	[NativeMethod]
	internal UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	private void InternalSetUrl(string url) { }

	public static UnityWebRequest Post(string uri, Dictionary<String, String> formFields) { }

	public static UnityWebRequest Post(string uri, WWWForm formData) { }

	[NativeMethod]
	private void Release() { }

	public UnityWebRequestAsyncOperation SendWebRequest() { }

	public static Byte[] SerializeSimpleForm(Dictionary<String, String> formFields) { }

	public void set_certificateHandler(CertificateHandler value) { }

	public void set_chunkedTransfer(bool value) { }

	[CompilerGenerated]
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[CompilerGenerated]
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[CompilerGenerated]
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	public void set_downloadHandler(DownloadHandler value) { }

	public void set_method(string value) { }

	public void set_redirectLimit(int value) { }

	public void set_timeout(int value) { }

	public void set_uploadHandler(UploadHandler value) { }

	public void set_url(string value) { }

	private UnityWebRequestError SetCertificateHandler(CertificateHandler ch) { }

	private UnityWebRequestError SetChunked(bool chunked) { }

	private UnityWebRequestError SetCustomMethod(string customMethodName) { }

	private UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	private UnityWebRequestError SetMethod(UnityWebRequestMethod methodType) { }

	[NativeThrows]
	private void SetRedirectLimitFromScripting(int limit) { }

	public void SetRequestHeader(string name, string value) { }

	private UnityWebRequestError SetTimeoutMsec(int timeout) { }

	private UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	private static void SetupPost(UnityWebRequest request, WWWForm formData) { }

	private static void SetupPost(UnityWebRequest request, Dictionary<String, String> formFields) { }

	private UnityWebRequestError SetUrl(string url) { }

	public static string UnEscapeURL(string s) { }

	public static string UnEscapeURL(string s, Encoding e) { }

}

