namespace System.Net.Sockets;

public class Socket : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static IOAsyncCallback <>9__241_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__309_0(IAsyncResult ares) { }

		internal void <.cctor>b__309_1(IOAsyncResult ares) { }

		internal void <.cctor>b__309_10(IAsyncResult ares) { }

		internal void <.cctor>b__309_11(IOAsyncResult ares) { }

		internal void <.cctor>b__309_12(IAsyncResult ares) { }

		internal void <.cctor>b__309_13(IOAsyncResult ares) { }

		internal void <.cctor>b__309_14(IAsyncResult ares) { }

		internal void <.cctor>b__309_2(IOAsyncResult ares) { }

		internal void <.cctor>b__309_3(IAsyncResult ares) { }

		internal void <.cctor>b__309_4(IOAsyncResult ares) { }

		internal void <.cctor>b__309_5(IAsyncResult ares) { }

		internal void <.cctor>b__309_6(IOAsyncResult ares) { }

		internal void <.cctor>b__309_7(IAsyncResult ares) { }

		internal void <.cctor>b__309_8(IOAsyncResult ares) { }

		internal void <.cctor>b__309_9(IOAsyncResult ares) { }

		internal void <BeginSend>b__241_0(IOAsyncResult s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass242_0
	{
		public int sent_so_far; //Field offset: 0x10

		public <>c__DisplayClass242_0() { }

		internal void <BeginSendCallback>b__0(IOAsyncResult s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass298_0
	{
		public Socket <>4__this; //Field offset: 0x10
		public IOSelectorJob job; //Field offset: 0x18
		public IntPtr handle; //Field offset: 0x20

		public <>c__DisplayClass298_0() { }

		internal void <QueueIOSelectorJob>b__0(Task t) { }

	}

	private struct WSABUF
	{
		public int len; //Field offset: 0x0
		public IntPtr buf; //Field offset: 0x8

	}

	private static object s_InternalSyncObject; //Field offset: 0x0
	internal static bool s_SupportsIPv4; //Field offset: 0x8
	internal static bool s_SupportsIPv6; //Field offset: 0x9
	internal static bool s_OSSupportsIPv6; //Field offset: 0xA
	internal static bool s_Initialized; //Field offset: 0xB
	private static bool s_LoggingEnabled; //Field offset: 0xC
	private static AsyncCallback AcceptAsyncCallback; //Field offset: 0x10
	private static IOAsyncCallback BeginAcceptCallback; //Field offset: 0x18
	private static IOAsyncCallback BeginAcceptReceiveCallback; //Field offset: 0x20
	private static AsyncCallback ConnectAsyncCallback; //Field offset: 0x28
	private static IOAsyncCallback BeginConnectCallback; //Field offset: 0x30
	private static AsyncCallback DisconnectAsyncCallback; //Field offset: 0x38
	private static IOAsyncCallback BeginDisconnectCallback; //Field offset: 0x40
	private static AsyncCallback ReceiveAsyncCallback; //Field offset: 0x48
	private static IOAsyncCallback BeginReceiveCallback; //Field offset: 0x50
	private static IOAsyncCallback BeginReceiveGenericCallback; //Field offset: 0x58
	private static AsyncCallback ReceiveFromAsyncCallback; //Field offset: 0x60
	private static IOAsyncCallback BeginReceiveFromCallback; //Field offset: 0x68
	private static AsyncCallback SendAsyncCallback; //Field offset: 0x70
	private static IOAsyncCallback BeginSendGenericCallback; //Field offset: 0x78
	private static AsyncCallback SendToAsyncCallback; //Field offset: 0x80
	private bool is_closed; //Field offset: 0x10
	private bool is_listening; //Field offset: 0x11
	private bool useOverlappedIO; //Field offset: 0x12
	private int linger_timeout; //Field offset: 0x14
	private AddressFamily addressFamily; //Field offset: 0x18
	private SocketType socketType; //Field offset: 0x1C
	private ProtocolType protocolType; //Field offset: 0x20
	internal SafeSocketHandle m_Handle; //Field offset: 0x28
	internal EndPoint seed_endpoint; //Field offset: 0x30
	internal SemaphoreSlim ReadSem; //Field offset: 0x38
	internal SemaphoreSlim WriteSem; //Field offset: 0x40
	internal bool is_blocking; //Field offset: 0x48
	internal bool is_bound; //Field offset: 0x49
	internal bool is_connected; //Field offset: 0x4A
	private int m_IntCleanedUp; //Field offset: 0x4C
	internal bool connect_in_progress; //Field offset: 0x50

	public AddressFamily AddressFamily
	{
		 get { } //Length: 4
	}

	public bool Blocking
	{
		 get { } //Length: 5
		 set { } //Length: 191
	}

	internal bool CleanedUp
	{
		internal get { } //Length: 8
	}

	public bool Connected
	{
		 get { } //Length: 5
	}

	public bool DontFragment
	{
		 set { } //Length: 147
	}

	public bool DualMode
	{
		 get { } //Length: 191
		 set { } //Length: 154
	}

	internal static int FamilyHint
	{
		internal get { } //Length: 344
	}

	public IntPtr Handle
	{
		 get { } //Length: 27
	}

	private static object InternalSyncObject
	{
		private get { } //Length: 241
	}

	private bool IsDualMode
	{
		private get { } //Length: 205
	}

	public EndPoint LocalEndPoint
	{
		 get { } //Length: 236
	}

	public bool NoDelay
	{
		 set { } //Length: 142
	}

	public static bool OSSupportsIPv4
	{
		 get { } //Length: 102
	}

	public static bool OSSupportsIPv6
	{
		 get { } //Length: 102
	}

	public ProtocolType ProtocolType
	{
		 get { } //Length: 4
	}

	public int ReceiveTimeout
	{
		 set { } //Length: 144
	}

	public SocketType SocketType
	{
		 get { } //Length: 4
	}

	[Obsolete]
	public static bool SupportsIPv4
	{
		 get { } //Length: 102
	}

	[Obsolete]
	public static bool SupportsIPv6
	{
		 get { } //Length: 102
	}

	private static Socket() { }

	internal Socket(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	public Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	public Socket Accept() { }

	internal void Accept(Socket acceptSocket) { }

	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking) { }

	private static IntPtr Accept_internal(IntPtr sock, out int error, bool blocking) { }

	public bool AcceptAsync(SocketAsyncEventArgs e) { }

	public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state) { }

	public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state) { }

	private static void BeginMConnect(SocketAsyncResult sockares) { }

	public IAsyncResult BeginReceive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	public IAsyncResult BeginReceive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	private static void BeginSConnect(SocketAsyncResult sockares) { }

	public IAsyncResult BeginSend(Byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	public IAsyncResult BeginSend(Byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	public void Bind(EndPoint localEP) { }

	private static void Bind_internal(IntPtr sock, SocketAddress sa, out int error) { }

	private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error) { }

	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error) { }

	internal static void Blocking_internal(IntPtr socket, bool block, out int error) { }

	internal static void cancel_blocking_socket_operation(Thread thread) { }

	internal bool CanTryAddressFamily(AddressFamily family) { }

	public void Close() { }

	public void Close(int timeout) { }

	internal static void Close_internal(IntPtr socket, out int error) { }

	public void Connect(EndPoint remoteEP) { }

	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking) { }

	private static void Connect_internal(IntPtr sock, SocketAddress sa, out int error, bool blocking) { }

	public void Disconnect(bool reuseSocket) { }

	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error) { }

	private static void Disconnect_internal(IntPtr sock, bool reuse, out int error) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public Socket EndAccept(IAsyncResult asyncResult) { }

	public Socket EndAccept(out Byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult) { }

	public void EndConnect(IAsyncResult asyncResult) { }

	public void EndDisconnect(IAsyncResult asyncResult) { }

	public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode) { }

	public int EndReceive(IAsyncResult asyncResult) { }

	public int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint) { }

	public int EndSend(IAsyncResult asyncResult, out SocketError errorCode) { }

	public int EndSend(IAsyncResult asyncResult) { }

	public int EndSendTo(IAsyncResult asyncResult) { }

	protected virtual void Finalize() { }

	public AddressFamily get_AddressFamily() { }

	public bool get_Blocking() { }

	internal bool get_CleanedUp() { }

	public bool get_Connected() { }

	public bool get_DualMode() { }

	internal static int get_FamilyHint() { }

	public IntPtr get_Handle() { }

	private static object get_InternalSyncObject() { }

	private bool get_IsDualMode() { }

	public EndPoint get_LocalEndPoint() { }

	public static bool get_OSSupportsIPv4() { }

	public static bool get_OSSupportsIPv6() { }

	public ProtocolType get_ProtocolType() { }

	public SocketType get_SocketType() { }

	public static bool get_SupportsIPv4() { }

	public static bool get_SupportsIPv6() { }

	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	private static void GetSocketOption_obj_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	internal static void InitializeSockets() { }

	private void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation) { }

	internal void InternalShutdown(SocketShutdown how) { }

	public int IOControl(IOControlCode ioControlCode, Byte[] optionInValue, Byte[] optionOutValue) { }

	public int IOControl(int ioControlCode, Byte[] optionInValue, Byte[] optionOutValue) { }

	private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, Byte[] input, Byte[] output, out int error) { }

	private static int IOControl_internal(IntPtr sock, int ioctl_code, Byte[] input, Byte[] output, out int error) { }

	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	private void Linger(IntPtr handle) { }

	public void Listen(int backlog) { }

	private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error) { }

	private static void Listen_internal(IntPtr sock, int backlog, out int error) { }

	private static SocketAddress LocalEndPoint_internal(IntPtr socket, int family, out int error) { }

	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	public bool Poll(int microSeconds, SelectMode mode) { }

	private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error) { }

	private static bool Poll_internal(IntPtr socket, SelectMode mode, int timeout, out int error) { }

	private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	public int Receive(Byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	public int Receive(Byte[] buffer) { }

	public int Receive(IList<ArraySegment`1<Byte>> buffers, SocketFlags socketFlags) { }

	public int Receive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int Receive(IList<ArraySegment`1<Byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	private static int Receive_internal(IntPtr sock, Byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Receive_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Receive_internal(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Receive_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	internal int ReceiveFrom(Byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	private static int ReceiveFrom_internal(IntPtr sock, Byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	private static int ReceiveFrom_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int Send(IList<ArraySegment`1<Byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	public int Send(Byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	public int Send(IList<ArraySegment`1<Byte>> buffers, SocketFlags socketFlags) { }

	public int Send(Byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	public int Send(Byte[] buffer) { }

	private static int Send_internal(IntPtr sock, Byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Send_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Send_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Send_internal(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	public void set_Blocking(bool value) { }

	public void set_DontFragment(bool value) { }

	public void set_DualMode(bool value) { }

	public void set_NoDelay(bool value) { }

	public void set_ReceiveTimeout(int value) { }

	public void SetIPProtectionLevel(IPProtectionLevel level) { }

	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	private static void SetSocketOption_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, Byte[] byte_val, int int_val, out int error) { }

	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, Byte[] byte_val, int int_val, out int error) { }

	public void Shutdown(SocketShutdown how) { }

	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error) { }

	internal static void Shutdown_internal(IntPtr socket, SocketShutdown how, out int error) { }

	private IntPtr Socket_internal(AddressFamily family, SocketType type, ProtocolType proto, out int error) { }

	private void SocketDefaults() { }

	private SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op) { }

	private void ThrowIfBufferNull(Byte[] buffer) { }

	private void ThrowIfBufferOutOfRange(Byte[] buffer, int offset, int size) { }

	private void ThrowIfDisposedAndClosed() { }

	private void ThrowIfUdp() { }

	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

}

