namespace Discord;

public class ActivityManager
{
	internal sealed class AcceptInviteHandler : MulticastDelegate
	{

		public AcceptInviteHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	internal sealed class ActivityInviteHandler : MulticastDelegate
	{

		public ActivityInviteHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ActivityActionType type, ref User user, ref Activity activity, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref User user, ref Activity activity, IAsyncResult result) { }

		public override void Invoke(ActivityActionType type, ref User user, ref Activity activity) { }

	}

	internal sealed class ActivityJoinHandler : MulticastDelegate
	{

		public ActivityJoinHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string secret, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string secret) { }

	}

	internal sealed class ActivityJoinRequestHandler : MulticastDelegate
	{

		public ActivityJoinRequestHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref User user, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref User user, IAsyncResult result) { }

		public override void Invoke(ref User user) { }

	}

	internal sealed class ActivitySpectateHandler : MulticastDelegate
	{

		public ActivitySpectateHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string secret, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string secret) { }

	}

	internal sealed class ClearActivityHandler : MulticastDelegate
	{

		public ClearActivityHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	public struct FFIEvents
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ActivityInviteHandler : MulticastDelegate
		{

			public ActivityInviteHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref User user, ref Activity activity, IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ActivityJoinHandler : MulticastDelegate
		{

			public ActivityJoinHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, string secret, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, string secret) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ActivityJoinRequestHandler : MulticastDelegate
		{

			public ActivityJoinRequestHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, ref User user, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref User user, IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, ref User user) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ActivitySpectateHandler : MulticastDelegate
		{

			public ActivitySpectateHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, string secret, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, string secret) { }

		}

		internal ActivityJoinHandler OnActivityJoin; //Field offset: 0x0
		internal ActivitySpectateHandler OnActivitySpectate; //Field offset: 0x8
		internal ActivityJoinRequestHandler OnActivityJoinRequest; //Field offset: 0x10
		internal ActivityInviteHandler OnActivityInvite; //Field offset: 0x18

	}

	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class AcceptInviteCallback : MulticastDelegate
		{

			public AcceptInviteCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class AcceptInviteMethod : MulticastDelegate
		{

			public AcceptInviteMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, IntPtr callbackData, AcceptInviteCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, long userId, IntPtr callbackData, AcceptInviteCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ClearActivityCallback : MulticastDelegate
		{

			public ClearActivityCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ClearActivityMethod : MulticastDelegate
		{

			public ClearActivityMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, ClearActivityCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, IntPtr callbackData, ClearActivityCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class RegisterCommandMethod : MulticastDelegate
		{

			public RegisterCommandMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string command, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, string command) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class RegisterSteamMethod : MulticastDelegate
		{

			public RegisterSteamMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, uint steamId, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, uint steamId) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SendInviteCallback : MulticastDelegate
		{

			public SendInviteCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SendInviteMethod : MulticastDelegate
		{

			public SendInviteMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, ActivityActionType type, string content, IntPtr callbackData, SendInviteCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, long userId, ActivityActionType type, string content, IntPtr callbackData, SendInviteCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SendRequestReplyCallback : MulticastDelegate
		{

			public SendRequestReplyCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SendRequestReplyMethod : MulticastDelegate
		{

			public SendRequestReplyMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, ActivityJoinRequestReply reply, IntPtr callbackData, SendRequestReplyCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, long userId, ActivityJoinRequestReply reply, IntPtr callbackData, SendRequestReplyCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class UpdateActivityCallback : MulticastDelegate
		{

			public UpdateActivityCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class UpdateActivityMethod : MulticastDelegate
		{

			public UpdateActivityMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref Activity activity, IntPtr callbackData, UpdateActivityCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(ref Activity activity, IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, ref Activity activity, IntPtr callbackData, UpdateActivityCallback callback) { }

		}

		internal RegisterCommandMethod RegisterCommand; //Field offset: 0x0
		internal RegisterSteamMethod RegisterSteam; //Field offset: 0x8
		internal UpdateActivityMethod UpdateActivity; //Field offset: 0x10
		internal ClearActivityMethod ClearActivity; //Field offset: 0x18
		internal SendRequestReplyMethod SendRequestReply; //Field offset: 0x20
		internal SendInviteMethod SendInvite; //Field offset: 0x28
		internal AcceptInviteMethod AcceptInvite; //Field offset: 0x30

	}

	internal sealed class SendInviteHandler : MulticastDelegate
	{

		public SendInviteHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	internal sealed class SendRequestReplyHandler : MulticastDelegate
	{

		public SendRequestReplyHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	internal sealed class UpdateActivityHandler : MulticastDelegate
	{

		public UpdateActivityHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	private IntPtr MethodsPtr; //Field offset: 0x10
	private object MethodsStructure; //Field offset: 0x18
	[CompilerGenerated]
	private ActivityJoinHandler OnActivityJoin; //Field offset: 0x20
	[CompilerGenerated]
	private ActivitySpectateHandler OnActivitySpectate; //Field offset: 0x28
	[CompilerGenerated]
	private ActivityJoinRequestHandler OnActivityJoinRequest; //Field offset: 0x30
	[CompilerGenerated]
	private ActivityInviteHandler OnActivityInvite; //Field offset: 0x38

	public event ActivityInviteHandler OnActivityInvite
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event ActivityJoinHandler OnActivityJoin
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event ActivityJoinRequestHandler OnActivityJoinRequest
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event ActivitySpectateHandler OnActivitySpectate
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	private FFIMethods Methods
	{
		private get { } //Length: 280
	}

	internal ActivityManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	public void AcceptInvite(long userId, AcceptInviteHandler callback) { }

	[MonoPInvokeCallback]
	private static void AcceptInviteCallbackImpl(IntPtr ptr, Result result) { }

	[CompilerGenerated]
	public void add_OnActivityInvite(ActivityInviteHandler value) { }

	[CompilerGenerated]
	public void add_OnActivityJoin(ActivityJoinHandler value) { }

	[CompilerGenerated]
	public void add_OnActivityJoinRequest(ActivityJoinRequestHandler value) { }

	[CompilerGenerated]
	public void add_OnActivitySpectate(ActivitySpectateHandler value) { }

	public void ClearActivity(ClearActivityHandler callback) { }

	[MonoPInvokeCallback]
	private static void ClearActivityCallbackImpl(IntPtr ptr, Result result) { }

	private FFIMethods get_Methods() { }

	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

	[MonoPInvokeCallback]
	private static void OnActivityInviteImpl(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity) { }

	[MonoPInvokeCallback]
	private static void OnActivityJoinImpl(IntPtr ptr, string secret) { }

	[MonoPInvokeCallback]
	private static void OnActivityJoinRequestImpl(IntPtr ptr, ref User user) { }

	[MonoPInvokeCallback]
	private static void OnActivitySpectateImpl(IntPtr ptr, string secret) { }

	public void RegisterCommand() { }

	public void RegisterCommand(string command) { }

	public void RegisterSteam(uint steamId) { }

	[CompilerGenerated]
	public void remove_OnActivityInvite(ActivityInviteHandler value) { }

	[CompilerGenerated]
	public void remove_OnActivityJoin(ActivityJoinHandler value) { }

	[CompilerGenerated]
	public void remove_OnActivityJoinRequest(ActivityJoinRequestHandler value) { }

	[CompilerGenerated]
	public void remove_OnActivitySpectate(ActivitySpectateHandler value) { }

	public void SendInvite(long userId, ActivityActionType type, string content, SendInviteHandler callback) { }

	[MonoPInvokeCallback]
	private static void SendInviteCallbackImpl(IntPtr ptr, Result result) { }

	public void SendRequestReply(long userId, ActivityJoinRequestReply reply, SendRequestReplyHandler callback) { }

	[MonoPInvokeCallback]
	private static void SendRequestReplyCallbackImpl(IntPtr ptr, Result result) { }

	public void UpdateActivity(Activity activity, UpdateActivityHandler callback) { }

	[MonoPInvokeCallback]
	private static void UpdateActivityCallbackImpl(IntPtr ptr, Result result) { }

}

