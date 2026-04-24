namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class Light : Behaviour
{
	private int m_BakedIndex; //Field offset: 0x18

	[Obsolete]
	public bool attenuate
	{
		 get { } //Length: 5
		 set { } //Length: 3
	}

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public int bakedIndex
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public LightBakingOutput bakingOutput
	{
		 get { } //Length: 80
		 set { } //Length: 66
	}

	public float bounceIntensity
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public Vector4 boundingSphereOverride
	{
		 get { } //Length: 75
		 set { } //Length: 66
	}

	public Color color
	{
		 get { } //Length: 75
		 set { } //Length: 66
	}

	public float colorTemperature
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public int commandBufferCount
	{
		 get { } //Length: 51
	}

	public Texture cookie
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float cookieSize
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public int cullingMask
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Flare flare
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float innerSpotAngle
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public float intensity
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public Single[] layerShadowCullDistances
	{
		[FreeFunction]
		 get { } //Length: 51
		[FreeFunction]
		 set { } //Length: 66
	}

	public LightShadowCasterMode lightShadowCasterMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[Obsolete]
	public static int pixelLightCount
	{
		 get { } //Length: 9
		 set { } //Length: 7
	}

	public float range
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public int renderingLayerMask
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public LightRenderMode renderMode
	{
		 get { } //Length: 51
		[FreeFunction]
		 set { } //Length: 64
	}

	public float shadowBias
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	[Obsolete]
	public float shadowConstantBias
	{
		 get { } //Length: 6
		 set { } //Length: 3
	}

	public int shadowCustomResolution
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Matrix4x4 shadowMatrixOverride
	{
		 get { } //Length: 87
		 set { } //Length: 66
	}

	public float shadowNearPlane
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public float shadowNormalBias
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	[Obsolete]
	public float shadowObjectSizeBias
	{
		 get { } //Length: 6
		 set { } //Length: 3
	}

	public LightShadowResolution shadowResolution
	{
		 get { } //Length: 51
		[FreeFunction]
		 set { } //Length: 64
	}

	public LightShadows shadows
	{
		[NativeMethod]
		 get { } //Length: 51
		[FreeFunction]
		 set { } //Length: 64
	}

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public float shadowSoftness
	{
		 get { } //Length: 11
		 set { } //Length: 3
	}

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public float shadowSoftnessFade
	{
		 get { } //Length: 11
		 set { } //Length: 3
	}

	public float shadowStrength
	{
		 get { } //Length: 51
		[FreeFunction]
		 set { } //Length: 67
	}

	[NativeProperty]
	public LightShape shape
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public float spotAngle
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	[NativeProperty]
	public LightType type
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool useBoundingSphereOverride
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool useColorTemperature
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool useShadowMatrixOverride
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Light() { }

	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	[FreeFunction]
	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask) { }

	public void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	[FreeFunction]
	public void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask, ComputeQueueType queueType) { }

	public bool get_attenuate() { }

	public int get_bakedIndex() { }

	public LightBakingOutput get_bakingOutput() { }

	private void get_bakingOutput_Injected(out LightBakingOutput ret) { }

	public float get_bounceIntensity() { }

	public Vector4 get_boundingSphereOverride() { }

	private void get_boundingSphereOverride_Injected(out Vector4 ret) { }

	public Color get_color() { }

	private void get_color_Injected(out Color ret) { }

	public float get_colorTemperature() { }

	public int get_commandBufferCount() { }

	public Texture get_cookie() { }

	public float get_cookieSize() { }

	public int get_cullingMask() { }

	public Flare get_flare() { }

	public float get_innerSpotAngle() { }

	public float get_intensity() { }

	[FreeFunction]
	public Single[] get_layerShadowCullDistances() { }

	public LightShadowCasterMode get_lightShadowCasterMode() { }

	public static int get_pixelLightCount() { }

	public float get_range() { }

	public int get_renderingLayerMask() { }

	public LightRenderMode get_renderMode() { }

	public float get_shadowBias() { }

	public float get_shadowConstantBias() { }

	public int get_shadowCustomResolution() { }

	public Matrix4x4 get_shadowMatrixOverride() { }

	private void get_shadowMatrixOverride_Injected(out Matrix4x4 ret) { }

	public float get_shadowNearPlane() { }

	public float get_shadowNormalBias() { }

	public float get_shadowObjectSizeBias() { }

	public LightShadowResolution get_shadowResolution() { }

	[NativeMethod]
	public LightShadows get_shadows() { }

	public float get_shadowSoftness() { }

	public float get_shadowSoftnessFade() { }

	public float get_shadowStrength() { }

	public LightShape get_shape() { }

	public float get_spotAngle() { }

	public LightType get_type() { }

	public bool get_useBoundingSphereOverride() { }

	public bool get_useColorTemperature() { }

	public bool get_useShadowMatrixOverride() { }

	[FreeFunction]
	public CommandBuffer[] GetCommandBuffers(LightEvent evt) { }

	[FreeFunction]
	public static Light[] GetLights(LightType type, int layer) { }

	public void RemoveAllCommandBuffers() { }

	public void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	public void RemoveCommandBuffers(LightEvent evt) { }

	public void Reset() { }

	public void set_attenuate(bool value) { }

	public void set_bakedIndex(int value) { }

	public void set_bakingOutput(LightBakingOutput value) { }

	private void set_bakingOutput_Injected(ref LightBakingOutput value) { }

	public void set_bounceIntensity(float value) { }

	public void set_boundingSphereOverride(Vector4 value) { }

	private void set_boundingSphereOverride_Injected(ref Vector4 value) { }

	public void set_color(Color value) { }

	private void set_color_Injected(ref Color value) { }

	public void set_colorTemperature(float value) { }

	public void set_cookie(Texture value) { }

	public void set_cookieSize(float value) { }

	public void set_cullingMask(int value) { }

	public void set_flare(Flare value) { }

	public void set_innerSpotAngle(float value) { }

	public void set_intensity(float value) { }

	[FreeFunction]
	public void set_layerShadowCullDistances(Single[] value) { }

	public void set_lightShadowCasterMode(LightShadowCasterMode value) { }

	public static void set_pixelLightCount(int value) { }

	public void set_range(float value) { }

	public void set_renderingLayerMask(int value) { }

	[FreeFunction]
	public void set_renderMode(LightRenderMode value) { }

	public void set_shadowBias(float value) { }

	public void set_shadowConstantBias(float value) { }

	public void set_shadowCustomResolution(int value) { }

	public void set_shadowMatrixOverride(Matrix4x4 value) { }

	private void set_shadowMatrixOverride_Injected(ref Matrix4x4 value) { }

	public void set_shadowNearPlane(float value) { }

	public void set_shadowNormalBias(float value) { }

	public void set_shadowObjectSizeBias(float value) { }

	[FreeFunction]
	public void set_shadowResolution(LightShadowResolution value) { }

	[FreeFunction]
	public void set_shadows(LightShadows value) { }

	public void set_shadowSoftness(float value) { }

	public void set_shadowSoftnessFade(float value) { }

	[FreeFunction]
	public void set_shadowStrength(float value) { }

	public void set_shape(LightShape value) { }

	public void set_spotAngle(float value) { }

	public void set_type(LightType value) { }

	public void set_useBoundingSphereOverride(bool value) { }

	public void set_useColorTemperature(bool value) { }

	public void set_useShadowMatrixOverride(bool value) { }

}

