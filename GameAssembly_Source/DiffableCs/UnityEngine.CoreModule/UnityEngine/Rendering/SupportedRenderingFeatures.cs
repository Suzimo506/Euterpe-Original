namespace UnityEngine.Rendering;

public class SupportedRenderingFeatures
{
	[Flags]
	internal enum LightmapMixedBakeModes
	{
		None = 0,
		IndirectOnly = 1,
		Subtractive = 2,
		Shadowmask = 4,
	}

	[Flags]
	internal enum ReflectionProbeModes
	{
		None = 0,
		Rotation = 1,
	}

	private static SupportedRenderingFeatures s_Active; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ReflectionProbeModes <reflectionProbeModes>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private LightmapMixedBakeModes <defaultMixedLightingModes>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private LightmapMixedBakeModes <mixedLightingModes>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private LightmapBakeType <lightmapBakeTypes>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private LightmapsMode <lightmapsModes>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <enlighten>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <lightProbeProxyVolumes>k__BackingField; //Field offset: 0x25
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <motionVectors>k__BackingField; //Field offset: 0x26
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <receiveShadows>k__BackingField; //Field offset: 0x27
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <reflectionProbes>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <rendererPriority>k__BackingField; //Field offset: 0x29
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <terrainDetailUnsupported>k__BackingField; //Field offset: 0x2A
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <overridesEnvironmentLighting>k__BackingField; //Field offset: 0x2B
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <overridesFog>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <overridesOtherLightingSettings>k__BackingField; //Field offset: 0x2D
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <editableMaterialRenderQueue>k__BackingField; //Field offset: 0x2E
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <overridesLODBias>k__BackingField; //Field offset: 0x2F
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <overridesMaximumLODLevel>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <autoAmbientProbeBaking>k__BackingField; //Field offset: 0x31
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <autoDefaultReflectionProbeBaking>k__BackingField; //Field offset: 0x32

	public static SupportedRenderingFeatures active
	{
		 get { } //Length: 293
		 set { } //Length: 96
	}

	public bool autoAmbientProbeBaking
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool autoDefaultReflectionProbeBaking
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public LightmapMixedBakeModes defaultMixedLightingModes
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public bool enlighten
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public LightmapBakeType lightmapBakeTypes
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public LightmapsMode lightmapsModes
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public LightmapMixedBakeModes mixedLightingModes
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	private static SupportedRenderingFeatures() { }

	public SupportedRenderingFeatures() { }

	[RequiredByNativeCode]
	internal static void FallbackLightmapperByRef(IntPtr lightmapperPtr) { }

	[RequiredByNativeCode]
	internal static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr) { }

	public static SupportedRenderingFeatures get_active() { }

	[CompilerGenerated]
	public bool get_autoAmbientProbeBaking() { }

	[CompilerGenerated]
	public bool get_autoDefaultReflectionProbeBaking() { }

	[CompilerGenerated]
	public LightmapMixedBakeModes get_defaultMixedLightingModes() { }

	[CompilerGenerated]
	public bool get_enlighten() { }

	[CompilerGenerated]
	public LightmapBakeType get_lightmapBakeTypes() { }

	[CompilerGenerated]
	public LightmapsMode get_lightmapsModes() { }

	[CompilerGenerated]
	public LightmapMixedBakeModes get_mixedLightingModes() { }

	[RequiredByNativeCode]
	internal static void IsAutoAmbientProbeBakingSupported(IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	internal static void IsAutoDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr) { }

	internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType) { }

	[RequiredByNativeCode]
	internal static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	internal static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	internal static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr) { }

	internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode) { }

	[RequiredByNativeCode]
	internal static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr) { }

	public static void set_active(SupportedRenderingFeatures value) { }

}

