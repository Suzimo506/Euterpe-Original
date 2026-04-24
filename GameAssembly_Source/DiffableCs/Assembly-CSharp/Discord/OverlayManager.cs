namespace Discord;

public class OverlayManager
{
	public struct FFIEvents
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ToggleHandler : MulticastDelegate
		{

			public ToggleHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, bool locked, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, bool locked) { }

		}

		internal ToggleHandler OnToggle; //Field offset: 0x0

	}

	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class IsEnabledMethod : MulticastDelegate
		{

			public IsEnabledMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref bool enabled, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref bool enabled, IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, ref bool enabled) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class IsLockedMethod : MulticastDelegate
		{

			public IsLockedMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref bool locked, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref bool locked, IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, ref bool locked) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class OpenActivityInviteCallback : MulticastDelegate
		{

			public OpenActivityInviteCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class OpenActivityInviteMethod : MulticastDelegate
		{

			public OpenActivityInviteMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ActivityActionType type, IntPtr callbackData, OpenActivityInviteCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, ActivityActionType type, IntPtr callbackData, OpenActivityInviteCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class OpenGuildInviteCallback : MulticastDelegate
		{

			public OpenGuildInviteCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class OpenGuildInviteMethod : MulticastDelegate
		{

			public OpenGuildInviteMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string code, IntPtr callbackData, OpenGuildInviteCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, string code, IntPtr callbackData, OpenGuildInviteCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class OpenVoiceSettingsCallback : MulticastDelegate
		{

			public OpenVoiceSettingsCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class OpenVoiceSettingsMethod : MulticastDelegate
		{

			public OpenVoiceSettingsMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, OpenVoiceSettingsCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, IntPtr callbackData, OpenVoiceSettingsCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SetLockedCallback : MulticastDelegate
		{

			public SetLockedCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SetLockedMethod : MulticastDelegate
		{

			public SetLockedMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, bool locked, IntPtr callbackData, SetLockedCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, bool locked, IntPtr callbackData, SetLockedCallback callback) { }

		}

		internal IsEnabledMethod IsEnabled; //Field offset: 0x0
		internal IsLockedMethod IsLocked; //Field offset: 0x8
		internal SetLockedMethod SetLocked; //Field offset: 0x10
		internal OpenActivityInviteMethod OpenActivityInvite; //Field offset: 0x18
		internal OpenGuildInviteMethod OpenGuildInvite; //Field offset: 0x20
		internal OpenVoiceSettingsMethod OpenVoiceSettings; //Field offset: 0x28

	}

	internal sealed class OpenActivityInviteHandler : MulticastDelegate
	{

		public OpenActivityInviteHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	internal sealed class OpenGuildInviteHandler : MulticastDelegate
	{

		public OpenGuildInviteHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	internal sealed class OpenVoiceSettingsHandler : MulticastDelegate
	{

		public OpenVoiceSettingsHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	internal sealed class SetLockedHandler : MulticastDelegate
	{

		public SetLockedHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	internal sealed class ToggleHandler : MulticastDelegate
	{

		public ToggleHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool locked, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool locked) { }

	}

	private IntPtr MethodsPtr; //Field offset: 0x10
	private object MethodsStructure; //Field offset: 0x18
	[CompilerGenerated]
	private ToggleHandler OnToggle; //Field offset: 0x20

	public event ToggleHandler OnToggle
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	private FFIMethods Methods
	{
		private get { } //Length: 270
	}

	internal OverlayManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	[CompilerGenerated]
	public void add_OnToggle(ToggleHandler value) { }

	private FFIMethods get_Methods() { }

	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

	public bool IsEnabled() { }

	public bool IsLocked() { }

	[MonoPInvokeCallback]
	private static void OnToggleImpl(IntPtr ptr, bool locked) { }

	public void OpenActivityInvite(ActivityActionType type, OpenActivityInviteHandler callback) { }

	[MonoPInvokeCallback]
	private static void OpenActivityInviteCallbackImpl(IntPtr ptr, Result result) { }

	public void OpenGuildInvite(string code, OpenGuildInviteHandler callback) { }

	[MonoPInvokeCallback]
	private static void OpenGuildInviteCallbackImpl(IntPtr ptr, Result result) { }

	public void OpenVoiceSettings(OpenVoiceSettingsHandler callback) { }

	[MonoPInvokeCallback]
	private static void OpenVoiceSettingsCallbackImpl(IntPtr ptr, Result result) { }

	[CompilerGenerated]
	public void remove_OnToggle(ToggleHandler value) { }

	public void SetLocked(bool locked, SetLockedHandler callback) { }

	[MonoPInvokeCallback]
	private static void SetLockedCallbackImpl(IntPtr ptr, Result result) { }

}

