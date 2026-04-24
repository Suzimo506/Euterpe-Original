namespace Sirenix.Serialization;

public static class ArchitectureInfo
{
	public static bool Architecture_Supports_Unaligned_Float32_Reads; //Field offset: 0x0
	public static bool Architecture_Supports_All_Unaligned_ReadWrites; //Field offset: 0x1

	private static ArchitectureInfo() { }

	internal static void SetRuntimePlatform(RuntimePlatform platform) { }

}

