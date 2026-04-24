namespace System.Net.Sockets;

public class SocketAsyncEventArgs : EventArgs, IDisposable
{
	private bool disposed; //Field offset: 0x10
	internal int in_progress; //Field offset: 0x14
	internal EndPoint remote_ep; //Field offset: 0x18
	internal Socket current_socket; //Field offset: 0x20
	internal SocketAsyncResult socket_async_result; //Field offset: 0x28
	[CompilerGenerated]
	private Socket <AcceptSocket>k__BackingField; //Field offset: 0x30
	internal IList<ArraySegment`1<Byte>> m_BufferList; //Field offset: 0x38
	[CompilerGenerated]
	private int <BytesTransferred>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private int <Count>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private SocketAsyncOperation <LastOperation>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private int <SendPacketsSendSize>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private SocketError <SocketError>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private object <UserToken>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private EventHandler<SocketAsyncEventArgs> Completed; //Field offset: 0x60

	public event EventHandler<SocketAsyncEventArgs> Completed
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public Socket AcceptSocket
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public IList<ArraySegment`1<Byte>> BufferList
	{
		 get { } //Length: 5
	}

	internal int BytesTransferred
	{
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public int Count
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	private SocketAsyncOperation LastOperation
	{
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[MonoTODO]
	public int SendPacketsSendSize
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public SocketError SocketError
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public object UserToken
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public SocketAsyncEventArgs() { }

	[CompilerGenerated]
	public void add_Completed(EventHandler<SocketAsyncEventArgs> value) { }

	internal void Complete() { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	[CompilerGenerated]
	public Socket get_AcceptSocket() { }

	public IList<ArraySegment`1<Byte>> get_BufferList() { }

	[CompilerGenerated]
	public int get_Count() { }

	[CompilerGenerated]
	public SocketError get_SocketError() { }

	[CompilerGenerated]
	public object get_UserToken() { }

	protected override void OnCompleted(SocketAsyncEventArgs e) { }

	[CompilerGenerated]
	public void remove_Completed(EventHandler<SocketAsyncEventArgs> value) { }

	[CompilerGenerated]
	public void set_AcceptSocket(Socket value) { }

	[CompilerGenerated]
	internal void set_BytesTransferred(int value) { }

	[CompilerGenerated]
	private void set_LastOperation(SocketAsyncOperation value) { }

	[CompilerGenerated]
	public void set_SendPacketsSendSize(int value) { }

	[CompilerGenerated]
	public void set_SocketError(SocketError value) { }

	[CompilerGenerated]
	public void set_UserToken(object value) { }

	internal void SetLastOperation(SocketAsyncOperation op) { }

}

