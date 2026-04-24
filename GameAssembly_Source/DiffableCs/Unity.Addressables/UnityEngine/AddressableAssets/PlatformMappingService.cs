namespace UnityEngine.AddressableAssets;

public class PlatformMappingService
{
	internal static readonly Dictionary<RuntimePlatform, AddressablesPlatform> s_RuntimeTargetMapping; //Field offset: 0x2C927B4

	private static PlatformMappingService() { }

	public PlatformMappingService() { }

	internal static AddressablesPlatform GetAddressablesPlatformInternal(RuntimePlatform platform) { }

	internal static string GetAddressablesPlatformPathInternal(RuntimePlatform platform) { }

	[Obsolete]
	public static AddressablesPlatform GetPlatform() { }

	public static string GetPlatformPathSubFolder() { }

}

