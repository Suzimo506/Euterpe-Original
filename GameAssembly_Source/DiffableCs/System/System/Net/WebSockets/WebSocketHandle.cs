namespace System.Net.WebSockets;

internal sealed class WebSocketHandle
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Object> <>9__24_0; //Field offset: 0x8
		public static Action<Object> <>9__25_0; //Field offset: 0x10
		public static Action<Object> <>9__25_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal void <ConnectAsyncCore>b__24_0(object s) { }

		internal void <ConnectSocketAsync>b__25_0(object s) { }

		internal void <ConnectSocketAsync>b__25_1(object s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public string headerValue; //Field offset: 0x10

		public <>c__DisplayClass28_0() { }

		internal bool <ParseAndValidateConnectResponseAsync>b__0(string requested) { }

	}

	[CompilerGenerated]
	private struct <ConnectAsyncCore>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public WebSocketHandle <>4__this; //Field offset: 0x28
		public Uri uri; //Field offset: 0x30
		public ClientWebSocketOptions options; //Field offset: 0x38
		private SslStream <sslStream>5__1; //Field offset: 0x40
		private Stream <stream>5__2; //Field offset: 0x48
		private KeyValuePair<String, String> <secKeyAndSecWebSocketAccept>5__3; //Field offset: 0x50
		private CancellationTokenRegistration <registration>5__4; //Field offset: 0x60
		private ConfiguredTaskAwaiter<Socket> <>u__1; //Field offset: 0x78
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x88
		private ConfiguredTaskAwaiter<String> <>u__3; //Field offset: 0x98

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ConnectSocketAsync>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Socket> <>t__builder; //Field offset: 0x8
		public string host; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public WebSocketHandle <>4__this; //Field offset: 0x30
		public int port; //Field offset: 0x38
		private Socket <socket>5__1; //Field offset: 0x40
		private ExceptionDispatchInfo <lastException>5__2; //Field offset: 0x48
		private ConfiguredTaskAwaiter<IPAddress[]> <>u__1; //Field offset: 0x50
		private IPAddress[] <>7__wrap1; //Field offset: 0x60
		private int <>7__wrap2; //Field offset: 0x68
		private CancellationTokenRegistration <>7__wrap3; //Field offset: 0x70
		private CancellationTokenRegistration <>7__wrap4; //Field offset: 0x88
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0xA0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseAndValidateConnectResponseAsync>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public Stream stream; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private string <line>5__1; //Field offset: 0x30
		private bool <foundConnection>5__2; //Field offset: 0x38
		private bool <foundUpgrade>5__3; //Field offset: 0x39
		public string expectedSecWebSocketAccept; //Field offset: 0x40
		private bool <foundSecWebSocketAccept>5__4; //Field offset: 0x48
		public ClientWebSocketOptions options; //Field offset: 0x50
		private string <subprotocol>5__5; //Field offset: 0x58
		private ConfiguredTaskAwaiter<String> <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadResponseHeaderLineAsync>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		private Byte[] <arr>5__1; //Field offset: 0x20
		private char <prevChar>5__2; //Field offset: 0x28
		private StringBuilder <sb>5__3; //Field offset: 0x30
		public Stream stream; //Field offset: 0x38
		public CancellationToken cancellationToken; //Field offset: 0x40
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[ThreadStatic]
	private static StringBuilder t_cachedStringBuilder; //Field offset: 0x80000000
	private static readonly Encoding s_defaultHttpEncoding; //Field offset: 0x0
	private const int DefaultReceiveBufferSize = 4096; //Field offset: 0x0
	private const string WSServerGuid = "258EAFA5-E914-47DA-95CA-C5AB0DC85B11"; //Field offset: 0x0
	private readonly CancellationTokenSource _abortSource; //Field offset: 0x10
	private WebSocketState _state; //Field offset: 0x18
	private WebSocket _webSocket; //Field offset: 0x20

	public Nullable<WebSocketCloseStatus> CloseStatus
	{
		 get { } //Length: 29
	}

	public string CloseStatusDescription
	{
		 get { } //Length: 29
	}

	public WebSocketState State
	{
		 get { } //Length: 33
	}

	private static WebSocketHandle() { }

	public WebSocketHandle() { }

	public void Abort() { }

	private static Byte[] BuildRequestHeader(Uri uri, ClientWebSocketOptions options, string secKey) { }

	public static void CheckPlatformSupport() { }

	public Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) { }

	[AsyncStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Task ConnectAsyncCore(Uri uri, CancellationToken cancellationToken, ClientWebSocketOptions options) { }

	[AsyncStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Task<Socket> ConnectSocketAsync(string host, int port, CancellationToken cancellationToken) { }

	public static WebSocketHandle Create() { }

	private static KeyValuePair<String, String> CreateSecKeyAndSecWebSocketAccept() { }

	public void Dispose() { }

	public Nullable<WebSocketCloseStatus> get_CloseStatus() { }

	public string get_CloseStatusDescription() { }

	public WebSocketState get_State() { }

	public static bool IsValid(WebSocketHandle handle) { }

	[AsyncStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Task<String> ParseAndValidateConnectResponseAsync(Stream stream, ClientWebSocketOptions options, string expectedSecWebSocketAccept, CancellationToken cancellationToken) { }

	[AsyncStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Task<String> ReadResponseHeaderLineAsync(Stream stream, CancellationToken cancellationToken) { }

	public Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<Byte> buffer, CancellationToken cancellationToken) { }

	public Task SendAsync(ArraySegment<Byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken) { }

	private static void ValidateAndTrackHeader(string targetHeaderName, string targetHeaderValue, string foundHeaderName, string foundHeaderValue, ref bool foundHeader) { }

}

