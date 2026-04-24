namespace Discord;

public class VoiceManager
{
	public struct FFIEvents
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SettingsUpdateHandler : MulticastDelegate
		{

			public SettingsUpdateHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr) { }

		}

		internal SettingsUpdateHandler OnSettingsUpdate; //Field offset: 0x0

	}

	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetInputModeMethod : MulticastDelegate
		{

			public GetInputModeMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref InputMode inputMode, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref InputMode inputMode, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, ref InputMode inputMode) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetLocalVolumeMethod : MulticastDelegate
		{

			public GetLocalVolumeMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, ref byte volume, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref byte volume, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long userId, ref byte volume) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class IsLocalMuteMethod : MulticastDelegate
		{

			public IsLocalMuteMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, ref bool mute, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref bool mute, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long userId, ref bool mute) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class IsSelfDeafMethod : MulticastDelegate
		{

			public IsSelfDeafMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref bool deaf, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref bool deaf, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, ref bool deaf) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class IsSelfMuteMethod : MulticastDelegate
		{

			public IsSelfMuteMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref bool mute, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref bool mute, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, ref bool mute) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SetInputModeCallback : MulticastDelegate
		{

			public SetInputModeCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SetInputModeMethod : MulticastDelegate
		{

			public SetInputModeMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, InputMode inputMode, IntPtr callbackData, SetInputModeCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, InputMode inputMode, IntPtr callbackData, SetInputModeCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SetLocalMuteMethod : MulticastDelegate
		{

			public SetLocalMuteMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, bool mute, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long userId, bool mute) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SetLocalVolumeMethod : MulticastDelegate
		{

			public SetLocalVolumeMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, byte volume, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long userId, byte volume) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SetSelfDeafMethod : MulticastDelegate
		{

			public SetSelfDeafMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, bool deaf, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, bool deaf) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SetSelfMuteMethod : MulticastDelegate
		{

			public SetSelfMuteMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, bool mute, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, bool mute) { }

		}

		internal GetInputModeMethod GetInputMode; //Field offset: 0x0
		internal SetInputModeMethod SetInputMode; //Field offset: 0x8
		internal IsSelfMuteMethod IsSelfMute; //Field offset: 0x10
		internal SetSelfMuteMethod SetSelfMute; //Field offset: 0x18
		internal IsSelfDeafMethod IsSelfDeaf; //Field offset: 0x20
		internal SetSelfDeafMethod SetSelfDeaf; //Field offset: 0x28
		internal IsLocalMuteMethod IsLocalMute; //Field offset: 0x30
		internal SetLocalMuteMethod SetLocalMute; //Field offset: 0x38
		internal GetLocalVolumeMethod GetLocalVolume; //Field offset: 0x40
		internal SetLocalVolumeMethod SetLocalVolume; //Field offset: 0x48

	}

	internal sealed class SetInputModeHandler : MulticastDelegate
	{

		public SetInputModeHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	internal sealed class SettingsUpdateHandler : MulticastDelegate
	{

		public SettingsUpdateHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	private IntPtr MethodsPtr; //Field offset: 0x10
	private object MethodsStructure; //Field offset: 0x18
	[CompilerGenerated]
	private SettingsUpdateHandler OnSettingsUpdate; //Field offset: 0x20

	public event SettingsUpdateHandler OnSettingsUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	private FFIMethods Methods
	{
		private get { } //Length: 286
	}

	internal VoiceManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	[CompilerGenerated]
	public void add_OnSettingsUpdate(SettingsUpdateHandler value) { }

	private FFIMethods get_Methods() { }

	public InputMode GetInputMode() { }

	public byte GetLocalVolume(long userId) { }

	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

	public bool IsLocalMute(long userId) { }

	public bool IsSelfDeaf() { }

	public bool IsSelfMute() { }

	[MonoPInvokeCallback]
	private static void OnSettingsUpdateImpl(IntPtr ptr) { }

	[CompilerGenerated]
	public void remove_OnSettingsUpdate(SettingsUpdateHandler value) { }

	public void SetInputMode(InputMode inputMode, SetInputModeHandler callback) { }

	[MonoPInvokeCallback]
	private static void SetInputModeCallbackImpl(IntPtr ptr, Result result) { }

	public void SetLocalMute(long userId, bool mute) { }

	public void SetLocalVolume(long userId, byte volume) { }

	public void SetSelfDeaf(bool deaf) { }

	public void SetSelfMute(bool mute) { }

}

