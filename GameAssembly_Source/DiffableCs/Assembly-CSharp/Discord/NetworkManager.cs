namespace Discord;

public class NetworkManager
{
	public struct FFIEvents
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class MessageHandler : MulticastDelegate
		{

			public MessageHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class RouteUpdateHandler : MulticastDelegate
		{

			public RouteUpdateHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, string routeData, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, string routeData) { }

		}

		internal MessageHandler OnMessage; //Field offset: 0x0
		internal RouteUpdateHandler OnRouteUpdate; //Field offset: 0x8

	}

	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class CloseChannelMethod : MulticastDelegate
		{

			public CloseChannelMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, byte channelId, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, ulong peerId, byte channelId) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ClosePeerMethod : MulticastDelegate
		{

			public ClosePeerMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, ulong peerId) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class FlushMethod : MulticastDelegate
		{

			public FlushMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetPeerIdMethod : MulticastDelegate
		{

			public GetPeerIdMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref ulong peerId, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref ulong peerId, IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, ref ulong peerId) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class OpenChannelMethod : MulticastDelegate
		{

			public OpenChannelMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, byte channelId, bool reliable, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, ulong peerId, byte channelId, bool reliable) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class OpenPeerMethod : MulticastDelegate
		{

			public OpenPeerMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, string routeData, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, ulong peerId, string routeData) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SendMessageMethod : MulticastDelegate
		{

			public SendMessageMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, byte channelId, Byte[] data, int dataLen, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, ulong peerId, byte channelId, Byte[] data, int dataLen) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class UpdatePeerMethod : MulticastDelegate
		{

			public UpdatePeerMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, string routeData, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, ulong peerId, string routeData) { }

		}

		internal GetPeerIdMethod GetPeerId; //Field offset: 0x0
		internal FlushMethod Flush; //Field offset: 0x8
		internal OpenPeerMethod OpenPeer; //Field offset: 0x10
		internal UpdatePeerMethod UpdatePeer; //Field offset: 0x18
		internal ClosePeerMethod ClosePeer; //Field offset: 0x20
		internal OpenChannelMethod OpenChannel; //Field offset: 0x28
		internal CloseChannelMethod CloseChannel; //Field offset: 0x30
		internal SendMessageMethod SendMessage; //Field offset: 0x38

	}

	internal sealed class MessageHandler : MulticastDelegate
	{

		public MessageHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong peerId, byte channelId, Byte[] data, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ulong peerId, byte channelId, Byte[] data) { }

	}

	internal sealed class RouteUpdateHandler : MulticastDelegate
	{

		public RouteUpdateHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string routeData, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string routeData) { }

	}

	private IntPtr MethodsPtr; //Field offset: 0x10
	private object MethodsStructure; //Field offset: 0x18
	[CompilerGenerated]
	private MessageHandler OnMessage; //Field offset: 0x20
	[CompilerGenerated]
	private RouteUpdateHandler OnRouteUpdate; //Field offset: 0x28

	public event MessageHandler OnMessage
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event RouteUpdateHandler OnRouteUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	private FFIMethods Methods
	{
		private get { } //Length: 278
	}

	internal NetworkManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	[CompilerGenerated]
	public void add_OnMessage(MessageHandler value) { }

	[CompilerGenerated]
	public void add_OnRouteUpdate(RouteUpdateHandler value) { }

	public void CloseChannel(ulong peerId, byte channelId) { }

	public void ClosePeer(ulong peerId) { }

	public void Flush() { }

	private FFIMethods get_Methods() { }

	public ulong GetPeerId() { }

	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

	[MonoPInvokeCallback]
	private static void OnMessageImpl(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen) { }

	[MonoPInvokeCallback]
	private static void OnRouteUpdateImpl(IntPtr ptr, string routeData) { }

	public void OpenChannel(ulong peerId, byte channelId, bool reliable) { }

	public void OpenPeer(ulong peerId, string routeData) { }

	[CompilerGenerated]
	public void remove_OnMessage(MessageHandler value) { }

	[CompilerGenerated]
	public void remove_OnRouteUpdate(RouteUpdateHandler value) { }

	public void SendMessage(ulong peerId, byte channelId, Byte[] data) { }

	public void UpdatePeer(ulong peerId, string routeData) { }

}

