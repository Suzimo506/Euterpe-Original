namespace UnityEngine.PostProcessing;

public sealed class ScreenSpaceReflectionComponent : PostProcessingComponentCommandBuffer<ScreenSpaceReflectionModel>
{
	private enum PassIndex
	{
		RayTraceStep = 0,
		CompositeFinal = 1,
		Blur = 2,
		CompositeSSR = 3,
		MinMipGeneration = 4,
		HitPointToReflections = 5,
		BilateralKeyPack = 6,
		BlitDepthAsCSZ = 7,
		PoissonBlur = 8,
	}

	private static class Uniforms
	{
		internal static readonly int _RayStepSize; //Field offset: 0x0
		internal static readonly int _AdditiveReflection; //Field offset: 0x4
		internal static readonly int _BilateralUpsampling; //Field offset: 0x8
		internal static readonly int _TreatBackfaceHitAsMiss; //Field offset: 0xC
		internal static readonly int _AllowBackwardsRays; //Field offset: 0x10
		internal static readonly int _TraceBehindObjects; //Field offset: 0x14
		internal static readonly int _MaxSteps; //Field offset: 0x18
		internal static readonly int _FullResolutionFiltering; //Field offset: 0x1C
		internal static readonly int _HalfResolution; //Field offset: 0x20
		internal static readonly int _HighlightSuppression; //Field offset: 0x24
		internal static readonly int _PixelsPerMeterAtOneMeter; //Field offset: 0x28
		internal static readonly int _ScreenEdgeFading; //Field offset: 0x2C
		internal static readonly int _ReflectionBlur; //Field offset: 0x30
		internal static readonly int _MaxRayTraceDistance; //Field offset: 0x34
		internal static readonly int _FadeDistance; //Field offset: 0x38
		internal static readonly int _LayerThickness; //Field offset: 0x3C
		internal static readonly int _SSRMultiplier; //Field offset: 0x40
		internal static readonly int _FresnelFade; //Field offset: 0x44
		internal static readonly int _FresnelFadePower; //Field offset: 0x48
		internal static readonly int _ReflectionBufferSize; //Field offset: 0x4C
		internal static readonly int _ScreenSize; //Field offset: 0x50
		internal static readonly int _InvScreenSize; //Field offset: 0x54
		internal static readonly int _ProjInfo; //Field offset: 0x58
		internal static readonly int _CameraClipInfo; //Field offset: 0x5C
		internal static readonly int _ProjectToPixelMatrix; //Field offset: 0x60
		internal static readonly int _WorldToCameraMatrix; //Field offset: 0x64
		internal static readonly int _CameraToWorldMatrix; //Field offset: 0x68
		internal static readonly int _Axis; //Field offset: 0x6C
		internal static readonly int _CurrentMipLevel; //Field offset: 0x70
		internal static readonly int _NormalAndRoughnessTexture; //Field offset: 0x74
		internal static readonly int _HitPointTexture; //Field offset: 0x78
		internal static readonly int _BlurTexture; //Field offset: 0x7C
		internal static readonly int _FilteredReflections; //Field offset: 0x80
		internal static readonly int _FinalReflectionTexture; //Field offset: 0x84
		internal static readonly int _TempTexture; //Field offset: 0x88

		private static Uniforms() { }

	}

	private bool k_HighlightSuppression; //Field offset: 0x20
	private bool k_TraceBehindObjects; //Field offset: 0x21
	private bool k_TreatBackfaceHitAsMiss; //Field offset: 0x22
	private bool k_BilateralUpsample; //Field offset: 0x23
	private readonly Int32[] m_ReflectionTextures; //Field offset: 0x28

	public virtual bool active
	{
		 get { } //Length: 116
	}

	public ScreenSpaceReflectionComponent() { }

	public virtual bool get_active() { }

	public virtual CameraEvent GetCameraEvent() { }

	public virtual DepthTextureMode GetCameraFlags() { }

	public virtual string GetName() { }

	public virtual void OnEnable() { }

	public virtual void PopulateCommandBuffer(CommandBuffer cb) { }

}

