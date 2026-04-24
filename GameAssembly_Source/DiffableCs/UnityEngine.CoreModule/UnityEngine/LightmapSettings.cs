namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class LightmapSettings : object
{

	[Obsolete]
	public static ColorSpace bakedColorSpace
	{
		 get { } //Length: 9
		 set { } //Length: 3
	}

	public static LightmapData[] lightmaps
	{
		[FreeFunction]
		 get { } //Length: 42
		[FreeFunction]
		 set { } //Length: 51
	}

	public static LightmapsMode lightmapsMode
	{
		 get { } //Length: 42
		[FreeFunction]
		 set { } //Length: 49
	}

	[Obsolete]
	public static LightmapsModeLegacy lightmapsModeLegacy
	{
		 get { } //Length: 5
		 set { } //Length: 3
	}

	public static LightProbes lightProbes
	{
		 get { } //Length: 42
		[FreeFunction]
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 set { } //Length: 51
	}

	private LightmapSettings() { }

	public static ColorSpace get_bakedColorSpace() { }

	[FreeFunction]
	public static LightmapData[] get_lightmaps() { }

	public static LightmapsMode get_lightmapsMode() { }

	public static LightmapsModeLegacy get_lightmapsModeLegacy() { }

	public static LightProbes get_lightProbes() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal static void Reset() { }

	public static void set_bakedColorSpace(ColorSpace value) { }

	[FreeFunction]
	public static void set_lightmaps(LightmapData[] value) { }

	[FreeFunction]
	public static void set_lightmapsMode(LightmapsMode value) { }

	public static void set_lightmapsModeLegacy(LightmapsModeLegacy value) { }

	[FreeFunction]
	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void set_lightProbes(LightProbes value) { }

}

