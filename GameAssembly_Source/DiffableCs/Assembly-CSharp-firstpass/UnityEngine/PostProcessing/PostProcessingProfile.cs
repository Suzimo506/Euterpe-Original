namespace UnityEngine.PostProcessing;

public class PostProcessingProfile : ScriptableObject
{
	public BuiltinDebugViewsModel debugViews; //Field offset: 0x18
	public FogModel fog; //Field offset: 0x20
	public AntialiasingModel antialiasing; //Field offset: 0x28
	public AmbientOcclusionModel ambientOcclusion; //Field offset: 0x30
	public ScreenSpaceReflectionModel screenSpaceReflection; //Field offset: 0x38
	public DepthOfFieldModel depthOfField; //Field offset: 0x40
	public MotionBlurModel motionBlur; //Field offset: 0x48
	public EyeAdaptationModel eyeAdaptation; //Field offset: 0x50
	public BloomModel bloom; //Field offset: 0x58
	public ColorGradingModel colorGrading; //Field offset: 0x60
	public UserLutModel userLut; //Field offset: 0x68
	public ChromaticAberrationModel chromaticAberration; //Field offset: 0x70
	public GrainModel grain; //Field offset: 0x78
	public VignetteModel vignette; //Field offset: 0x80
	public DitheringModel dithering; //Field offset: 0x88

	public PostProcessingProfile() { }

}

