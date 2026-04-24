namespace Sirenix.Serialization;

public static class UnitySerializationInitializer
{
	private static readonly object LOCK; //Field offset: 0x0
	private static bool initialized; //Field offset: 0x8
	[CompilerGenerated]
	private static RuntimePlatform <CurrentPlatform>k__BackingField; //Field offset: 0xC

	public private static RuntimePlatform CurrentPlatform
	{
		[CompilerGenerated]
		 get { } //Length: 86
		[CompilerGenerated]
		private set { } //Length: 91
	}

	public static bool Initialized
	{
		 get { } //Length: 87
	}

	private static UnitySerializationInitializer() { }

	[CompilerGenerated]
	public static RuntimePlatform get_CurrentPlatform() { }

	public static bool get_Initialized() { }

	public static void Initialize() { }

	[RuntimeInitializeOnLoadMethod]
	private static void InitializeRuntime() { }

	[CompilerGenerated]
	private static void set_CurrentPlatform(RuntimePlatform value) { }

}

