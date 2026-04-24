namespace System.Net.WebSockets;

public sealed class ClientWebSocket : WebSocket
{
	[CompilerGenerated]
	private struct <ConnectAsyncCore>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientWebSocket <>4__this; //Field offset: 0x20
		public Uri uri; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum InternalState
	{
		Created = 0,
		Connecting = 1,
		Connected = 2,
		Disposed = 3,
	}

	private readonly ClientWebSocketOptions _options; //Field offset: 0x10
	private WebSocketHandle _innerWebSocket; //Field offset: 0x18
	private int _state; //Field offset: 0x20

	public virtual Nullable<WebSocketCloseStatus> CloseStatus
	{
		 get { } //Length: 132
	}

	public virtual string CloseStatusDescription
	{
		 get { } //Length: 132
	}

	public virtual WebSocketState State
	{
		 get { } //Length: 165
	}

	public ClientWebSocket() { }

	public virtual void Abort() { }

	public virtual Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) { }

	public Task ConnectAsync(Uri uri, CancellationToken cancellationToken) { }

	[AsyncStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Task ConnectAsyncCore(Uri uri, CancellationToken cancellationToken) { }

	public virtual void Dispose() { }

	public virtual Nullable<WebSocketCloseStatus> get_CloseStatus() { }

	public virtual string get_CloseStatusDescription() { }

	public virtual WebSocketState get_State() { }

	public virtual Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<Byte> buffer, CancellationToken cancellationToken) { }

	public virtual Task SendAsync(ArraySegment<Byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken) { }

	private void ThrowIfNotConnected() { }

}

