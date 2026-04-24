namespace System.Net.WebSockets;

internal sealed class ManagedWebSocket : WebSocket
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Object> <>9__37_0; //Field offset: 0x8
		public static TimerCallback <>9__37_1; //Field offset: 0x10
		public static Action<Task, Object> <>9__54_0; //Field offset: 0x18
		public static Action<Object> <>9__55_0; //Field offset: 0x20
		public static Action<Task> <>9__57_0; //Field offset: 0x28
		public static Action<Object> <>9__60_0; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__37_0(object s) { }

		internal void <.ctor>b__37_1(object s) { }

		internal void <ReceiveAsyncPrivate>b__60_0(object s) { }

		internal void <SendFrameFallbackAsync>b__55_0(object s) { }

		internal void <SendFrameLockAcquiredNonCancelableAsync>b__54_0(Task t, object s) { }

		internal void <SendKeepAliveFrameAsync>b__57_0(Task p) { }

	}

	[CompilerGenerated]
	private struct <CloseWithReceiveErrorAndThrowAsync>d__64 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ManagedWebSocket <>4__this; //Field offset: 0x20
		public WebSocketCloseStatus closeStatus; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		public WebSocketError error; //Field offset: 0x38
		public Exception innerException; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EnsureBufferContainsAsync>d__69 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ManagedWebSocket <>4__this; //Field offset: 0x20
		public int minimumRequiredBytes; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		public bool throwOnPrematureClosure; //Field offset: 0x38
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandleReceivedCloseAsync>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<WebSocketReceiveResult> <>t__builder; //Field offset: 0x8
		public ManagedWebSocket <>4__this; //Field offset: 0x20
		public MessageHeader header; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x40
		private WebSocketCloseStatus <closeStatus>5__1; //Field offset: 0x48
		private string <closeStatusDescription>5__2; //Field offset: 0x50
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandleReceivedPingPongAsync>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MessageHeader header; //Field offset: 0x20
		public ManagedWebSocket <>4__this; //Field offset: 0x38
		public CancellationToken cancellationToken; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReceiveAsyncPrivate>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<WebSocketReceiveResult> <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public ManagedWebSocket <>4__this; //Field offset: 0x28
		private MessageHeader <header>5__1; //Field offset: 0x30
		public ArraySegment<Byte> payloadBuffer; //Field offset: 0x48
		private int <bytesToRead>5__2; //Field offset: 0x58
		private int <bytesToCopy>5__3; //Field offset: 0x5C
		private CancellationTokenRegistration <registration>5__4; //Field offset: 0x60
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x78
		private ConfiguredTaskAwaiter<WebSocketReceiveResult> <>u__2; //Field offset: 0x88

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendCloseFrameAsync>d__67 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string closeStatusDescription; //Field offset: 0x20
		public WebSocketCloseStatus closeStatus; //Field offset: 0x28
		public ManagedWebSocket <>4__this; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private Byte[] <buffer>5__1; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendFrameFallbackAsync>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ManagedWebSocket <>4__this; //Field offset: 0x20
		public MessageOpcode opcode; //Field offset: 0x28
		public bool endOfMessage; //Field offset: 0x29
		public ArraySegment<Byte> payloadBuffer; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48
		private CancellationTokenRegistration <>7__wrap1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct MessageHeader
	{
		internal MessageOpcode Opcode; //Field offset: 0x0
		internal bool Fin; //Field offset: 0x1
		internal long PayloadLength; //Field offset: 0x8
		internal int Mask; //Field offset: 0x10

	}

	private enum MessageOpcode
	{
		Continuation = 0,
		Text = 1,
		Binary = 2,
		Close = 8,
		Ping = 9,
		Pong = 10,
	}

	private sealed class Utf8MessageState
	{
		internal bool SequenceInProgress; //Field offset: 0x10
		internal int AdditionalBytesExpected; //Field offset: 0x14
		internal int ExpectedValueMin; //Field offset: 0x18
		internal int CurrentDecodeBits; //Field offset: 0x1C

		public Utf8MessageState() { }

	}

	private static readonly RandomNumberGenerator s_random; //Field offset: 0x0
	private static readonly UTF8Encoding s_textEncoding; //Field offset: 0x8
	private static readonly WebSocketState[] s_validSendStates; //Field offset: 0x10
	private static readonly WebSocketState[] s_validReceiveStates; //Field offset: 0x18
	private static readonly WebSocketState[] s_validCloseOutputStates; //Field offset: 0x20
	private static readonly WebSocketState[] s_validCloseStates; //Field offset: 0x28
	private readonly Stream _stream; //Field offset: 0x10
	private readonly bool _isServer; //Field offset: 0x18
	private readonly string _subprotocol; //Field offset: 0x20
	private readonly Timer _keepAliveTimer; //Field offset: 0x28
	private readonly CancellationTokenSource _abortSource; //Field offset: 0x30
	private Byte[] _receiveBuffer; //Field offset: 0x38
	private readonly bool _receiveBufferFromPool; //Field offset: 0x40
	private readonly Utf8MessageState _utf8TextState; //Field offset: 0x48
	private readonly SemaphoreSlim _sendFrameAsyncLock; //Field offset: 0x50
	private WebSocketState _state; //Field offset: 0x58
	private bool _disposed; //Field offset: 0x5C
	private bool _sentCloseFrame; //Field offset: 0x5D
	private bool _receivedCloseFrame; //Field offset: 0x5E
	private Nullable<WebSocketCloseStatus> _closeStatus; //Field offset: 0x60
	private string _closeStatusDescription; //Field offset: 0x68
	private MessageHeader _lastReceiveHeader; //Field offset: 0x70
	private int _receiveBufferOffset; //Field offset: 0x88
	private int _receiveBufferCount; //Field offset: 0x8C
	private int _receivedMaskOffsetOffset; //Field offset: 0x90
	private Byte[] _sendBuffer; //Field offset: 0x98
	private bool _lastSendWasFragment; //Field offset: 0xA0
	private Task _lastSendAsync; //Field offset: 0xA8
	private Task<WebSocketReceiveResult> _lastReceiveAsync; //Field offset: 0xB0

	public virtual Nullable<WebSocketCloseStatus> CloseStatus
	{
		 get { } //Length: 5
	}

	public virtual string CloseStatusDescription
	{
		 get { } //Length: 5
	}

	private object ReceiveAsyncLock
	{
		private get { } //Length: 5
	}

	public virtual WebSocketState State
	{
		 get { } //Length: 4
	}

	private object StateUpdateLock
	{
		private get { } //Length: 5
	}

	private static ManagedWebSocket() { }

	private ManagedWebSocket(Stream stream, bool isServer, string subprotocol, TimeSpan keepAliveInterval, int receiveBufferSize, Nullable<ArraySegment`1<Byte>> receiveBuffer) { }

	public virtual void Abort() { }

	private void AllocateSendBuffer(int minLength) { }

	private static int ApplyMask(Byte[] toMask, int toMaskOffset, int mask, int maskIndex, long count) { }

	private static int ApplyMask(Byte[] toMask, int toMaskOffset, Byte[] mask, int maskOffset, int maskOffsetIndex, long count) { }

	public virtual Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) { }

	[AsyncStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Task CloseWithReceiveErrorAndThrowAsync(WebSocketCloseStatus closeStatus, WebSocketError error, CancellationToken cancellationToken, Exception innerException = null) { }

	private static int CombineMaskBytes(Byte[] buffer, int maskOffset) { }

	private void ConsumeFromBuffer(int count) { }

	public static ManagedWebSocket CreateFromConnectedStream(Stream stream, bool isServer, string subprotocol, TimeSpan keepAliveInterval, int receiveBufferSize, Nullable<ArraySegment`1<Byte>> receiveBuffer = null) { }

	private static Exception CreateOperationCanceledException(Exception innerException, CancellationToken cancellationToken = null) { }

	public virtual void Dispose() { }

	private void DisposeCore() { }

	[AsyncStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Task EnsureBufferContainsAsync(int minimumRequiredBytes, CancellationToken cancellationToken, bool throwOnPrematureClosure = true) { }

	public virtual Nullable<WebSocketCloseStatus> get_CloseStatus() { }

	public virtual string get_CloseStatusDescription() { }

	private object get_ReceiveAsyncLock() { }

	public virtual WebSocketState get_State() { }

	private object get_StateUpdateLock() { }

	[AsyncStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Task<WebSocketReceiveResult> HandleReceivedCloseAsync(MessageHeader header, CancellationToken cancellationToken) { }

	[AsyncStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Task HandleReceivedPingPongAsync(MessageHeader header, CancellationToken cancellationToken) { }

	private static bool IsValidCloseStatus(WebSocketCloseStatus closeStatus) { }

	public virtual Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<Byte> buffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Task<WebSocketReceiveResult> ReceiveAsyncPrivate(ArraySegment<Byte> payloadBuffer, CancellationToken cancellationToken) { }

	private void ReleaseSendBuffer() { }

	public virtual Task SendAsync(ArraySegment<Byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken) { }

	[AsyncStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Task SendCloseFrameAsync(WebSocketCloseStatus closeStatus, string closeStatusDescription, CancellationToken cancellationToken) { }

	private Task SendFrameAsync(MessageOpcode opcode, bool endOfMessage, ArraySegment<Byte> payloadBuffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Task SendFrameFallbackAsync(MessageOpcode opcode, bool endOfMessage, ArraySegment<Byte> payloadBuffer, CancellationToken cancellationToken) { }

	private Task SendFrameLockAcquiredNonCancelableAsync(MessageOpcode opcode, bool endOfMessage, ArraySegment<Byte> payloadBuffer) { }

	private void SendKeepAliveFrameAsync() { }

	private void ThrowIfOperationInProgress(Task operationTask, string methodName = null) { }

	private bool TryParseMessageHeaderFromReceiveBuffer(out MessageHeader resultHeader) { }

	private static bool TryValidateUtf8(ArraySegment<Byte> arraySegment, bool endOfMessage, Utf8MessageState state) { }

	private int WriteFrameToSendBuffer(MessageOpcode opcode, bool endOfMessage, ArraySegment<Byte> payloadBuffer) { }

	private static int WriteHeader(MessageOpcode opcode, Byte[] sendBuffer, ArraySegment<Byte> payload, bool endOfMessage, bool useMask) { }

	private static void WriteRandomMask(Byte[] buffer, int offset) { }

}

