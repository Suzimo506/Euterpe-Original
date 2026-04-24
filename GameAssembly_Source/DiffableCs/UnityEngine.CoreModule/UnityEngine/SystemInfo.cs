namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class SystemInfo
{

	public static CopyTextureSupport copyTextureSupport
	{
		 get { } //Length: 42
	}

	public static string deviceModel
	{
		 get { } //Length: 42
	}

	public static string deviceName
	{
		 get { } //Length: 42
	}

	public static DeviceType deviceType
	{
		 get { } //Length: 42
	}

	public static string deviceUniqueIdentifier
	{
		 get { } //Length: 42
	}

	public static GraphicsDeviceType graphicsDeviceType
	{
		 get { } //Length: 42
	}

	public static string graphicsDeviceVendor
	{
		 get { } //Length: 42
	}

	public static int graphicsMemorySize
	{
		 get { } //Length: 42
	}

	public static int graphicsShaderLevel
	{
		 get { } //Length: 42
	}

	public static bool graphicsUVStartsAtTop
	{
		 get { } //Length: 42
	}

	public static string operatingSystem
	{
		 get { } //Length: 42
	}

	public static OperatingSystemFamily operatingSystemFamily
	{
		 get { } //Length: 42
	}

	public static int processorCount
	{
		 get { } //Length: 42
	}

	public static string processorType
	{
		 get { } //Length: 42
	}

	public static int supportedRenderTargetCount
	{
		 get { } //Length: 42
	}

	public static bool supportsComputeShaders
	{
		 get { } //Length: 42
	}

	[Obsolete]
	public static bool supportsImageEffects
	{
		 get { } //Length: 5
	}

	public static bool supportsMotionVectors
	{
		 get { } //Length: 42
	}

	public static CopyTextureSupport get_copyTextureSupport() { }

	public static string get_deviceModel() { }

	public static string get_deviceName() { }

	public static DeviceType get_deviceType() { }

	public static string get_deviceUniqueIdentifier() { }

	public static GraphicsDeviceType get_graphicsDeviceType() { }

	public static string get_graphicsDeviceVendor() { }

	public static int get_graphicsMemorySize() { }

	public static int get_graphicsShaderLevel() { }

	public static bool get_graphicsUVStartsAtTop() { }

	public static string get_operatingSystem() { }

	public static OperatingSystemFamily get_operatingSystemFamily() { }

	public static int get_processorCount() { }

	public static string get_processorType() { }

	public static int get_supportedRenderTargetCount() { }

	public static bool get_supportsComputeShaders() { }

	public static bool get_supportsImageEffects() { }

	public static bool get_supportsMotionVectors() { }

	[FreeFunction]
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunction]
	private static CopyTextureSupport GetCopyTextureSupport() { }

	[FreeFunction]
	private static string GetDeviceModel() { }

	[FreeFunction]
	private static string GetDeviceName() { }

	[FreeFunction]
	private static DeviceType GetDeviceType() { }

	[FreeFunction]
	private static string GetDeviceUniqueIdentifier() { }

	[FreeFunction]
	private static GraphicsDeviceType GetGraphicsDeviceType() { }

	[FreeFunction]
	private static string GetGraphicsDeviceVendor() { }

	[FreeFunction]
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

	[FreeFunction]
	private static int GetGraphicsMemorySize() { }

	[FreeFunction]
	private static int GetGraphicsShaderLevel() { }

	[FreeFunction]
	private static bool GetGraphicsUVStartsAtTop() { }

	[FreeFunction]
	private static string GetOperatingSystem() { }

	[FreeFunction]
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	[FreeFunction]
	private static int GetProcessorCount() { }

	[FreeFunction]
	private static string GetProcessorType() { }

	[FreeFunction]
	private static bool HasRenderTextureNative(RenderTextureFormat format) { }

	[FreeFunction]
	public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage) { }

	private static bool IsValidEnumValue(Enum value) { }

	[FreeFunction]
	private static int SupportedRenderTargetCount() { }

	[FreeFunction]
	private static bool SupportsComputeShaders() { }

	[FreeFunction]
	private static bool SupportsMotionVectors() { }

	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	public static bool SupportsTextureFormat(TextureFormat format) { }

	[FreeFunction]
	private static bool SupportsTextureFormatNative(TextureFormat format) { }

}

