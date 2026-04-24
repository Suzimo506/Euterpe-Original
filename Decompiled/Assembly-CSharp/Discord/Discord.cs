using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000433")]
public class Discord : IDisposable
{
	[Token(Token = "0x2000AD9")]
	internal struct FFIEvents
	{
	}

	[Token(Token = "0x2000ADA")]
	internal struct FFIMethods
	{
		[Token(Token = "0x2000E27")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void DestroyHandler(IntPtr MethodsPtr);

		[Token(Token = "0x2000E28")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result RunCallbacksMethod(IntPtr methodsPtr);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E29")]
		internal delegate void SetLogHookCallback(IntPtr ptr, LogLevel level, string message);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E2A")]
		internal delegate void SetLogHookMethod(IntPtr methodsPtr, LogLevel minLevel, IntPtr callbackData, SetLogHookCallback callback);

		[Token(Token = "0x2000E2B")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate IntPtr GetApplicationManagerMethod(IntPtr discordPtr);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E2C")]
		internal delegate IntPtr GetUserManagerMethod(IntPtr discordPtr);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E2D")]
		internal delegate IntPtr GetImageManagerMethod(IntPtr discordPtr);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E2E")]
		internal delegate IntPtr GetActivityManagerMethod(IntPtr discordPtr);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E2F")]
		internal delegate IntPtr GetRelationshipManagerMethod(IntPtr discordPtr);

		[Token(Token = "0x2000E30")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate IntPtr GetLobbyManagerMethod(IntPtr discordPtr);

		[Token(Token = "0x2000E31")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate IntPtr GetNetworkManagerMethod(IntPtr discordPtr);

		[Token(Token = "0x2000E32")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate IntPtr GetOverlayManagerMethod(IntPtr discordPtr);

		[Token(Token = "0x2000E33")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate IntPtr GetStorageManagerMethod(IntPtr discordPtr);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E34")]
		internal delegate IntPtr GetStoreManagerMethod(IntPtr discordPtr);

		[Token(Token = "0x2000E35")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate IntPtr GetVoiceManagerMethod(IntPtr discordPtr);

		[Token(Token = "0x2000E36")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate IntPtr GetAchievementManagerMethod(IntPtr discordPtr);

		[Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40038B7")]
		internal DestroyHandler Destroy;

		[Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40038B8")]
		internal RunCallbacksMethod RunCallbacks;

		[Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40038B9")]
		internal SetLogHookMethod SetLogHook;

		[Token(Token = "0x40038BA")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal GetApplicationManagerMethod GetApplicationManager;

		[Token(Token = "0x40038BB")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal GetUserManagerMethod GetUserManager;

		[Token(Token = "0x40038BC")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal GetImageManagerMethod GetImageManager;

		[Token(Token = "0x40038BD")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal GetActivityManagerMethod GetActivityManager;

		[Token(Token = "0x40038BE")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal GetRelationshipManagerMethod GetRelationshipManager;

		[Token(Token = "0x40038BF")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal GetLobbyManagerMethod GetLobbyManager;

		[Token(Token = "0x40038C0")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal GetNetworkManagerMethod GetNetworkManager;

		[Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40038C1")]
		internal GetOverlayManagerMethod GetOverlayManager;

		[Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40038C2")]
		internal GetStorageManagerMethod GetStorageManager;

		[Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40038C3")]
		internal GetStoreManagerMethod GetStoreManager;

		[Token(Token = "0x40038C4")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal GetVoiceManagerMethod GetVoiceManager;

		[Token(Token = "0x40038C5")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		internal GetAchievementManagerMethod GetAchievementManager;
	}

	[Token(Token = "0x2000ADB")]
	internal struct FFICreateParams
	{
		[Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40038C6")]
		internal long ClientId;

		[Token(Token = "0x40038C7")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal ulong Flags;

		[Token(Token = "0x40038C8")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal IntPtr Events;

		[Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40038C9")]
		internal IntPtr EventData;

		[Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40038CA")]
		internal IntPtr ApplicationEvents;

		[Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40038CB")]
		internal uint ApplicationVersion;

		[Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40038CC")]
		internal IntPtr UserEvents;

		[Token(Token = "0x40038CD")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal uint UserVersion;

		[Token(Token = "0x40038CE")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal IntPtr ImageEvents;

		[Token(Token = "0x40038CF")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal uint ImageVersion;

		[Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40038D0")]
		internal IntPtr ActivityEvents;

		[Token(Token = "0x40038D1")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal uint ActivityVersion;

		[Token(Token = "0x40038D2")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal IntPtr RelationshipEvents;

		[Token(Token = "0x40038D3")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal uint RelationshipVersion;

		[Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40038D4")]
		internal IntPtr LobbyEvents;

		[Token(Token = "0x40038D5")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		internal uint LobbyVersion;

		[Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40038D6")]
		internal IntPtr NetworkEvents;

		[Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40038D7")]
		internal uint NetworkVersion;

		[Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		[Token(Token = "0x40038D8")]
		internal IntPtr OverlayEvents;

		[Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40038D9")]
		internal uint OverlayVersion;

		[Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40038DA")]
		internal IntPtr StorageEvents;

		[Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40038DB")]
		internal uint StorageVersion;

		[Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x40038DC")]
		internal IntPtr StoreEvents;

		[Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x40038DD")]
		internal uint StoreVersion;

		[Token(Token = "0x40038DE")]
		[Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		internal IntPtr VoiceEvents;

		[Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x40038DF")]
		internal uint VoiceVersion;

		[Token(Token = "0x40038E0")]
		[Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		internal IntPtr AchievementEvents;

		[Token(Token = "0x40038E1")]
		[Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		internal uint AchievementVersion;
	}

	[Token(Token = "0x2000ADC")]
	public delegate void SetLogHookHandler(LogLevel level, string message);

	[Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400174D")]
	private GCHandle SelfHandle;

	[Token(Token = "0x400174E")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private IntPtr EventsPtr;

	[Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400174F")]
	private FFIEvents Events;

	[Token(Token = "0x4001750")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private IntPtr ApplicationEventsPtr;

	[Token(Token = "0x4001751")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private ApplicationManager.FFIEvents ApplicationEvents;

	[Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001752")]
	internal ApplicationManager ApplicationManagerInstance;

	[Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001753")]
	private IntPtr UserEventsPtr;

	[Token(Token = "0x4001754")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private UserManager.FFIEvents UserEvents;

	[Token(Token = "0x4001755")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	internal UserManager UserManagerInstance;

	[Token(Token = "0x4001756")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private IntPtr ImageEventsPtr;

	[Token(Token = "0x4001757")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private ImageManager.FFIEvents ImageEvents;

	[Token(Token = "0x4001758")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	internal ImageManager ImageManagerInstance;

	[Token(Token = "0x4001759")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private IntPtr ActivityEventsPtr;

	[Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400175A")]
	private ActivityManager.FFIEvents ActivityEvents;

	[Token(Token = "0x400175B")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	internal ActivityManager ActivityManagerInstance;

	[Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400175C")]
	private IntPtr RelationshipEventsPtr;

	[Token(Token = "0x400175D")]
	[Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	private RelationshipManager.FFIEvents RelationshipEvents;

	[Token(Token = "0x400175E")]
	[Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	internal RelationshipManager RelationshipManagerInstance;

	[Token(Token = "0x400175F")]
	[Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	private IntPtr LobbyEventsPtr;

	[Token(Token = "0x4001760")]
	[Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	private LobbyManager.FFIEvents LobbyEvents;

	[Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4001761")]
	internal LobbyManager LobbyManagerInstance;

	[Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4001762")]
	private IntPtr NetworkEventsPtr;

	[Token(Token = "0x4001763")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	private NetworkManager.FFIEvents NetworkEvents;

	[Token(Token = "0x4001764")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	internal NetworkManager NetworkManagerInstance;

	[Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4001765")]
	private IntPtr OverlayEventsPtr;

	[Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4001766")]
	private OverlayManager.FFIEvents OverlayEvents;

	[Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4001767")]
	internal OverlayManager OverlayManagerInstance;

	[Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4001768")]
	private IntPtr StorageEventsPtr;

	[Token(Token = "0x4001769")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	private StorageManager.FFIEvents StorageEvents;

	[Token(Token = "0x400176A")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	internal StorageManager StorageManagerInstance;

	[Token(Token = "0x400176B")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	private IntPtr StoreEventsPtr;

	[Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	[Token(Token = "0x400176C")]
	private StoreManager.FFIEvents StoreEvents;

	[Token(Token = "0x400176D")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	internal StoreManager StoreManagerInstance;

	[Token(Token = "0x400176E")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	private IntPtr VoiceEventsPtr;

	[Token(Token = "0x400176F")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	private VoiceManager.FFIEvents VoiceEvents;

	[Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4001770")]
	internal VoiceManager VoiceManagerInstance;

	[Token(Token = "0x4001771")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	private IntPtr AchievementEventsPtr;

	[Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4001772")]
	private AchievementManager.FFIEvents AchievementEvents;

	[Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4001773")]
	internal AchievementManager AchievementManagerInstance;

	[Token(Token = "0x4001774")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	private IntPtr MethodsPtr;

	[Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4001775")]
	private object MethodsStructure;

	[Token(Token = "0x4001776")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
	private GCHandle? setLogHook;

	[Token(Token = "0x17000472")]
	private FFIMethods Methods
	{
		[Token(Token = "0x6003158")]
		[Address(RVA = "0x2144410", Offset = "0x2142C10", Length = "0x13D")]
		get
		{
			return default(FFIMethods);
		}
	}

	[Token(Token = "0x17000473")]
	public Result isInit
	{
		[CompilerGenerated]
		[Token(Token = "0x6003159")]
		[Address(RVA = "0x2144550", Offset = "0x2142D50", Length = "0x7")]
		get
		{
			return default(Result);
		}
		[Address(RVA = "0x2144560", Offset = "0x2142D60", Length = "0x7")]
		[Token(Token = "0x600315A")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[PreserveSig]
	[Token(Token = "0x6003157")]
	[Address(RVA = "0x2142A40", Offset = "0x2141240", Length = "0x91")]
	private static extern Result DiscordCreate(uint version, ref FFICreateParams createParams, out IntPtr manager);

	[Address(RVA = "0x2143DA0", Offset = "0x21425A0", Length = "0x662")]
	[Token(Token = "0x600315B")]
	public Discord(long clientId, ulong flags)
	{
	}

	[Token(Token = "0x600315C")]
	[Address(RVA = "0x2143A60", Offset = "0x2142260", Length = "0x62")]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Address(RVA = "0x2142AE0", Offset = "0x21412E0", Length = "0x18D")]
	[Token(Token = "0x600315D")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600315E")]
	[Address(RVA = "0x2143AD0", Offset = "0x21422D0", Length = "0xCD")]
	public bool RunCallbacks()
	{
		return default(bool);
	}

	[Token(Token = "0x600315F")]
	[Address(RVA = "0x2143BA0", Offset = "0x21423A0", Length = "0x91")]
	[MonoPInvokeCallback]
	private static void SetLogHookCallbackImpl(IntPtr ptr, LogLevel level, string message)
	{
	}

	[Token(Token = "0x6003160")]
	[Address(RVA = "0x2143C40", Offset = "0x2142440", Length = "0x157")]
	public void SetLogHook(LogLevel minLevel, SetLogHookHandler callback)
	{
	}

	[Address(RVA = "0x2142E90", Offset = "0x2141690", Length = "0xF2")]
	[Token(Token = "0x6003161")]
	public ApplicationManager GetApplicationManager()
	{
		return null;
	}

	[Address(RVA = "0x2143850", Offset = "0x2142050", Length = "0xF2")]
	[Token(Token = "0x6003162")]
	public UserManager GetUserManager()
	{
		return null;
	}

	[Token(Token = "0x6003163")]
	[Address(RVA = "0x2142F90", Offset = "0x2141790", Length = "0x1C3")]
	public ImageManager GetImageManager()
	{
		return null;
	}

	[Token(Token = "0x6003164")]
	[Address(RVA = "0x2142D90", Offset = "0x2141590", Length = "0xFE")]
	public ActivityManager GetActivityManager()
	{
		return null;
	}

	[Token(Token = "0x6003165")]
	[Address(RVA = "0x2143520", Offset = "0x2141D20", Length = "0x104")]
	public RelationshipManager GetRelationshipManager()
	{
		return null;
	}

	[Address(RVA = "0x2143160", Offset = "0x2141960", Length = "0x19E")]
	[Token(Token = "0x6003166")]
	public LobbyManager GetLobbyManager()
	{
		return null;
	}

	[Token(Token = "0x6003167")]
	[Address(RVA = "0x2143300", Offset = "0x2141B00", Length = "0x104")]
	public NetworkManager GetNetworkManager()
	{
		return null;
	}

	[Token(Token = "0x6003168")]
	[Address(RVA = "0x2143410", Offset = "0x2141C10", Length = "0x104")]
	public OverlayManager GetOverlayManager()
	{
		return null;
	}

	[Token(Token = "0x6003169")]
	[Address(RVA = "0x2143630", Offset = "0x2141E30", Length = "0x104")]
	public StorageManager GetStorageManager()
	{
		return null;
	}

	[Token(Token = "0x600316A")]
	[Address(RVA = "0x2143740", Offset = "0x2141F40", Length = "0x104")]
	public StoreManager GetStoreManager()
	{
		return null;
	}

	[Address(RVA = "0x2143950", Offset = "0x2142150", Length = "0x104")]
	[Token(Token = "0x600316B")]
	public VoiceManager GetVoiceManager()
	{
		return null;
	}

	[Token(Token = "0x600316C")]
	[Address(RVA = "0x2142C70", Offset = "0x2141470", Length = "0x116")]
	public AchievementManager GetAchievementManager()
	{
		return null;
	}
}
