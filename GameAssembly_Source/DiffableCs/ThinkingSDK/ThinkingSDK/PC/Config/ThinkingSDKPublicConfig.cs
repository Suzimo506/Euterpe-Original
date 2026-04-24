namespace ThinkingSDK.PC.Config;

public class ThinkingSDKPublicConfig
{
	private static readonly ThinkingSDKPublicConfig config; //Field offset: 0x0
	private bool isPrintLog; //Field offset: 0x10
	private string version; //Field offset: 0x18
	private string name; //Field offset: 0x20

	private static ThinkingSDKPublicConfig() { }

	public ThinkingSDKPublicConfig() { }

	private static ThinkingSDKPublicConfig GetConfig() { }

	public static bool IsPrintLog() { }

	public static string Name() { }

	public static void SetIsPrintLog(bool isPrint) { }

	public static void SetName(string libName) { }

	public static void SetVersion(string libVersion) { }

	public static string Version() { }

}

