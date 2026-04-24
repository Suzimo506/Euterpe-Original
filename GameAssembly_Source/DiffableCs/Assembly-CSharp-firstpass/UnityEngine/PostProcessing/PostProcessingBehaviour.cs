namespace UnityEngine.PostProcessing;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DisallowMultipleComponent]
[ExecuteInEditMode]
[ImageEffectAllowedInSceneView]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class PostProcessingBehaviour : MonoBehaviour
{
	public PostProcessingProfile profile; //Field offset: 0x18
	public Func<Vector2, Matrix4x4> jitteredMatrixFunc; //Field offset: 0x20
	private Dictionary<Type, KeyValuePair`2<CameraEvent, CommandBuffer>> m_CommandBuffers; //Field offset: 0x28
	private List<PostProcessingComponentBase> m_Components; //Field offset: 0x30
	private Dictionary<PostProcessingComponentBase, Boolean> m_ComponentStates; //Field offset: 0x38
	private MaterialFactory m_MaterialFactory; //Field offset: 0x40
	private RenderTextureFactory m_RenderTextureFactory; //Field offset: 0x48
	private PostProcessingContext m_Context; //Field offset: 0x50
	private Camera m_Camera; //Field offset: 0x58
	private PostProcessingProfile m_PreviousProfile; //Field offset: 0x60
	private bool m_RenderingInSceneView; //Field offset: 0x68
	private BuiltinDebugViewsComponent m_DebugViews; //Field offset: 0x70
	private AmbientOcclusionComponent m_AmbientOcclusion; //Field offset: 0x78
	private ScreenSpaceReflectionComponent m_ScreenSpaceReflection; //Field offset: 0x80
	private FogComponent m_FogComponent; //Field offset: 0x88
	private MotionBlurComponent m_MotionBlur; //Field offset: 0x90
	private TaaComponent m_Taa; //Field offset: 0x98
	private EyeAdaptationComponent m_EyeAdaptation; //Field offset: 0xA0
	private DepthOfFieldComponent m_DepthOfField; //Field offset: 0xA8
	private BloomComponent m_Bloom; //Field offset: 0xB0
	private ChromaticAberrationComponent m_ChromaticAberration; //Field offset: 0xB8
	private ColorGradingComponent m_ColorGrading; //Field offset: 0xC0
	private UserLutComponent m_UserLut; //Field offset: 0xC8
	private GrainComponent m_Grain; //Field offset: 0xD0
	private VignetteComponent m_Vignette; //Field offset: 0xD8
	private DitheringComponent m_Dithering; //Field offset: 0xE0
	private FxaaComponent m_Fxaa; //Field offset: 0xE8
	private List<PostProcessingComponentBase> m_ComponentsToEnable; //Field offset: 0xF0
	private List<PostProcessingComponentBase> m_ComponentsToDisable; //Field offset: 0xF8

	public PostProcessingBehaviour() { }

	private CommandBuffer AddCommandBuffer(CameraEvent evt, string name) { }

	private T AddComponent(T component) { }

	private void CheckObservers() { }

	private void DisableComponents() { }

	private CommandBuffer GetCommandBuffer(CameraEvent evt, string name) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnGUI() { }

	private void OnPostRender() { }

	private void OnPreCull() { }

	private void OnPreRender() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void RemoveCommandBuffer() { }

	public void ResetTemporalEffects() { }

	private void TryExecuteCommandBuffer(PostProcessingComponentCommandBuffer<T> component) { }

	private bool TryPrepareUberImageEffect(PostProcessingComponentRenderTexture<T> component, Material material) { }

}

