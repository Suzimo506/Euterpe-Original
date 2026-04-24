namespace UnityEngine.XR;

[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public static class XRSettings
{
	internal enum StereoRenderingMode
	{
		MultiPass = 0,
		SinglePass = 1,
		SinglePassInstanced = 2,
		SinglePassMultiview = 3,
	}


	public static bool enabled
	{
		[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 42
	}

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static RenderTextureDescriptor eyeTextureDesc
	{
		 get { } //Length: 73
	}

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static int eyeTextureHeight
	{
		 get { } //Length: 42
	}

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static float eyeTextureResolutionScale
	{
		 get { } //Length: 42
		 set { } //Length: 58
	}

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static int eyeTextureWidth
	{
		 get { } //Length: 42
	}

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static bool isDeviceActive
	{
		 get { } //Length: 42
	}

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static string loadedDeviceName
	{
		 get { } //Length: 42
	}

	public static float renderViewportScale
	{
		 get { } //Length: 42
	}

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal static float renderViewportScaleInternal
	{
		internal get { } //Length: 42
	}

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static StereoRenderingMode stereoRenderingMode
	{
		 get { } //Length: 42
	}

	public static String[] supportedDevices
	{
		 get { } //Length: 42
	}

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static bool get_enabled() { }

	public static RenderTextureDescriptor get_eyeTextureDesc() { }

	private static void get_eyeTextureDesc_Injected(out RenderTextureDescriptor ret) { }

	public static int get_eyeTextureHeight() { }

	public static float get_eyeTextureResolutionScale() { }

	public static int get_eyeTextureWidth() { }

	public static bool get_isDeviceActive() { }

	public static string get_loadedDeviceName() { }

	public static float get_renderViewportScale() { }

	internal static float get_renderViewportScaleInternal() { }

	public static StereoRenderingMode get_stereoRenderingMode() { }

	public static String[] get_supportedDevices() { }

	public static void set_eyeTextureResolutionScale(float value) { }

}

