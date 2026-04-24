namespace Discord;

public class Discord : IDisposable
{
	public struct FFICreateParams
	{
		internal long ClientId; //Field offset: 0x0
		internal ulong Flags; //Field offset: 0x8
		internal IntPtr Events; //Field offset: 0x10
		internal IntPtr EventData; //Field offset: 0x18
		internal IntPtr ApplicationEvents; //Field offset: 0x20
		internal uint ApplicationVersion; //Field offset: 0x28
		internal IntPtr UserEvents; //Field offset: 0x30
		internal uint UserVersion; //Field offset: 0x38
		internal IntPtr ImageEvents; //Field offset: 0x40
		internal uint ImageVersion; //Field offset: 0x48
		internal IntPtr ActivityEvents; //Field offset: 0x50
		internal uint ActivityVersion; //Field offset: 0x58
		internal IntPtr RelationshipEvents; //Field offset: 0x60
		internal uint RelationshipVersion; //Field offset: 0x68
		internal IntPtr LobbyEvents; //Field offset: 0x70
		internal uint LobbyVersion; //Field offset: 0x78
		internal IntPtr NetworkEvents; //Field offset: 0x80
		internal uint NetworkVersion; //Field offset: 0x88
		internal IntPtr OverlayEvents; //Field offset: 0x90
		internal uint OverlayVersion; //Field offset: 0x98
		internal IntPtr StorageEvents; //Field offset: 0xA0
		internal uint StorageVersion; //Field offset: 0xA8
		internal IntPtr StoreEvents; //Field offset: 0xB0
		internal uint StoreVersion; //Field offset: 0xB8
		internal IntPtr VoiceEvents; //Field offset: 0xC0
		internal uint VoiceVersion; //Field offset: 0xC8
		internal IntPtr AchievementEvents; //Field offset: 0xD0
		internal uint AchievementVersion; //Field offset: 0xD8

	}

	public struct FFIEvents
	{

	}

	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class DestroyHandler : MulticastDelegate
		{

			public DestroyHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr MethodsPtr, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr MethodsPtr) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetAchievementManagerMethod : MulticastDelegate
		{

			public GetAchievementManagerMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			public override IntPtr EndInvoke(IAsyncResult result) { }

			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetActivityManagerMethod : MulticastDelegate
		{

			public GetActivityManagerMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			public override IntPtr EndInvoke(IAsyncResult result) { }

			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetApplicationManagerMethod : MulticastDelegate
		{

			public GetApplicationManagerMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			public override IntPtr EndInvoke(IAsyncResult result) { }

			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetImageManagerMethod : MulticastDelegate
		{

			public GetImageManagerMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			public override IntPtr EndInvoke(IAsyncResult result) { }

			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetLobbyManagerMethod : MulticastDelegate
		{

			public GetLobbyManagerMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			public override IntPtr EndInvoke(IAsyncResult result) { }

			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetNetworkManagerMethod : MulticastDelegate
		{

			public GetNetworkManagerMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			public override IntPtr EndInvoke(IAsyncResult result) { }

			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetOverlayManagerMethod : MulticastDelegate
		{

			public GetOverlayManagerMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			public override IntPtr EndInvoke(IAsyncResult result) { }

			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetRelationshipManagerMethod : MulticastDelegate
		{

			public GetRelationshipManagerMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			public override IntPtr EndInvoke(IAsyncResult result) { }

			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetStorageManagerMethod : MulticastDelegate
		{

			public GetStorageManagerMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			public override IntPtr EndInvoke(IAsyncResult result) { }

			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetStoreManagerMethod : MulticastDelegate
		{

			public GetStoreManagerMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			public override IntPtr EndInvoke(IAsyncResult result) { }

			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetUserManagerMethod : MulticastDelegate
		{

			public GetUserManagerMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			public override IntPtr EndInvoke(IAsyncResult result) { }

			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetVoiceManagerMethod : MulticastDelegate
		{

			public GetVoiceManagerMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			public override IntPtr EndInvoke(IAsyncResult result) { }

			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class RunCallbacksMethod : MulticastDelegate
		{

			public RunCallbacksMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SetLogHookCallback : MulticastDelegate
		{

			public SetLogHookCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, LogLevel level, string message, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, LogLevel level, string message) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SetLogHookMethod : MulticastDelegate
		{

			public SetLogHookMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, LogLevel minLevel, IntPtr callbackData, SetLogHookCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, LogLevel minLevel, IntPtr callbackData, SetLogHookCallback callback) { }

		}

		internal DestroyHandler Destroy; //Field offset: 0x0
		internal RunCallbacksMethod RunCallbacks; //Field offset: 0x8
		internal SetLogHookMethod SetLogHook; //Field offset: 0x10
		internal GetApplicationManagerMethod GetApplicationManager; //Field offset: 0x18
		internal GetUserManagerMethod GetUserManager; //Field offset: 0x20
		internal GetImageManagerMethod GetImageManager; //Field offset: 0x28
		internal GetActivityManagerMethod GetActivityManager; //Field offset: 0x30
		internal GetRelationshipManagerMethod GetRelationshipManager; //Field offset: 0x38
		internal GetLobbyManagerMethod GetLobbyManager; //Field offset: 0x40
		internal GetNetworkManagerMethod GetNetworkManager; //Field offset: 0x48
		internal GetOverlayManagerMethod GetOverlayManager; //Field offset: 0x50
		internal GetStorageManagerMethod GetStorageManager; //Field offset: 0x58
		internal GetStoreManagerMethod GetStoreManager; //Field offset: 0x60
		internal GetVoiceManagerMethod GetVoiceManager; //Field offset: 0x68
		internal GetAchievementManagerMethod GetAchievementManager; //Field offset: 0x70

	}

	internal sealed class SetLogHookHandler : MulticastDelegate
	{

		public SetLogHookHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(LogLevel level, string message, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(LogLevel level, string message) { }

	}

	private GCHandle SelfHandle; //Field offset: 0x10
	private IntPtr EventsPtr; //Field offset: 0x18
	private FFIEvents Events; //Field offset: 0x20
	private IntPtr ApplicationEventsPtr; //Field offset: 0x28
	private FFIEvents ApplicationEvents; //Field offset: 0x30
	internal ApplicationManager ApplicationManagerInstance; //Field offset: 0x38
	private IntPtr UserEventsPtr; //Field offset: 0x40
	private FFIEvents UserEvents; //Field offset: 0x48
	internal UserManager UserManagerInstance; //Field offset: 0x50
	private IntPtr ImageEventsPtr; //Field offset: 0x58
	private FFIEvents ImageEvents; //Field offset: 0x60
	internal ImageManager ImageManagerInstance; //Field offset: 0x68
	private IntPtr ActivityEventsPtr; //Field offset: 0x70
	private FFIEvents ActivityEvents; //Field offset: 0x78
	internal ActivityManager ActivityManagerInstance; //Field offset: 0x98
	private IntPtr RelationshipEventsPtr; //Field offset: 0xA0
	private FFIEvents RelationshipEvents; //Field offset: 0xA8
	internal RelationshipManager RelationshipManagerInstance; //Field offset: 0xB8
	private IntPtr LobbyEventsPtr; //Field offset: 0xC0
	private FFIEvents LobbyEvents; //Field offset: 0xC8
	internal LobbyManager LobbyManagerInstance; //Field offset: 0x108
	private IntPtr NetworkEventsPtr; //Field offset: 0x110
	private FFIEvents NetworkEvents; //Field offset: 0x118
	internal NetworkManager NetworkManagerInstance; //Field offset: 0x128
	private IntPtr OverlayEventsPtr; //Field offset: 0x130
	private FFIEvents OverlayEvents; //Field offset: 0x138
	internal OverlayManager OverlayManagerInstance; //Field offset: 0x140
	private IntPtr StorageEventsPtr; //Field offset: 0x148
	private FFIEvents StorageEvents; //Field offset: 0x150
	internal StorageManager StorageManagerInstance; //Field offset: 0x158
	private IntPtr StoreEventsPtr; //Field offset: 0x160
	private FFIEvents StoreEvents; //Field offset: 0x168
	internal StoreManager StoreManagerInstance; //Field offset: 0x178
	private IntPtr VoiceEventsPtr; //Field offset: 0x180
	private FFIEvents VoiceEvents; //Field offset: 0x188
	internal VoiceManager VoiceManagerInstance; //Field offset: 0x190
	private IntPtr AchievementEventsPtr; //Field offset: 0x198
	private FFIEvents AchievementEvents; //Field offset: 0x1A0
	internal AchievementManager AchievementManagerInstance; //Field offset: 0x1A8
	private IntPtr MethodsPtr; //Field offset: 0x1B0
	private object MethodsStructure; //Field offset: 0x1B8
	private Nullable<GCHandle> setLogHook; //Field offset: 0x1C0
	[CompilerGenerated]
	private Result <isInit>k__BackingField; //Field offset: 0x1C8

	public private Result isInit
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private FFIMethods Methods
	{
		private get { } //Length: 317
	}

	public Discord(long clientId, ulong flags) { }

	private static Result DiscordCreate(uint version, ref FFICreateParams createParams, out IntPtr manager) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public Result get_isInit() { }

	private FFIMethods get_Methods() { }

	public AchievementManager GetAchievementManager() { }

	public ActivityManager GetActivityManager() { }

	public ApplicationManager GetApplicationManager() { }

	public ImageManager GetImageManager() { }

	public LobbyManager GetLobbyManager() { }

	public NetworkManager GetNetworkManager() { }

	public OverlayManager GetOverlayManager() { }

	public RelationshipManager GetRelationshipManager() { }

	public StorageManager GetStorageManager() { }

	public StoreManager GetStoreManager() { }

	public UserManager GetUserManager() { }

	public VoiceManager GetVoiceManager() { }

	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

	public bool RunCallbacks() { }

	[CompilerGenerated]
	private void set_isInit(Result value) { }

	public void SetLogHook(LogLevel minLevel, SetLogHookHandler callback) { }

	[MonoPInvokeCallback]
	private static void SetLogHookCallbackImpl(IntPtr ptr, LogLevel level, string message) { }

}

