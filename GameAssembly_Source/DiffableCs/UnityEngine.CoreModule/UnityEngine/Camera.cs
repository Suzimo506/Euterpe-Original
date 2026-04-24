namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public sealed class Camera : Behaviour
{
	internal sealed class CameraCallback : MulticastDelegate
	{

		public CameraCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Camera cam, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Camera cam) { }

	}

	internal enum GateFitMode
	{
		Vertical = 1,
		Horizontal = 2,
		Fill = 3,
		Overscan = 4,
		None = 0,
	}

	internal struct GateFitParameters
	{
		[CompilerGenerated]
		[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private GateFitMode <mode>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private float <aspect>k__BackingField; //Field offset: 0x4

		public float aspect
		{
			[CompilerGenerated]
			 get { } //Length: 6
		}

		public GateFitMode mode
		{
			[CompilerGenerated]
			 get { } //Length: 3
		}

		[CompilerGenerated]
		public float get_aspect() { }

		[CompilerGenerated]
		public GateFitMode get_mode() { }

	}

	internal enum MonoOrStereoscopicEye
	{
		Left = 0,
		Right = 1,
		Mono = 2,
	}

	public enum ProjectionMatrixMode
	{
		Explicit = 0,
		Implicit = 1,
		PhysicalPropertiesBased = 2,
	}

	internal enum StereoscopicEye
	{
		Left = 0,
		Right = 1,
	}

	public static CameraCallback onPreCull; //Field offset: 0x0
	public static CameraCallback onPreRender; //Field offset: 0x8
	public static CameraCallback onPostRender; //Field offset: 0x10

	public RenderTexture activeTexture
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
	}

	public RenderingPath actualRenderingPath
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
	}

	public static Camera[] allCameras
	{
		 get { } //Length: 128
	}

	public static int allCamerasCount
	{
		 get { } //Length: 42
	}

	public bool allowDynamicResolution
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool allowHDR
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool allowMSAA
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool areVRStereoViewMatricesWithinSingleCullTolerance
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
	}

	public float aspect
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public Color backgroundColor
	{
		 get { } //Length: 75
		 set { } //Length: 66
	}

	public Matrix4x4 cameraToWorldMatrix
	{
		 get { } //Length: 87
	}

	public CameraType cameraType
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public CameraClearFlags clearFlags
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool clearStencilAfterLightingPass
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int commandBufferCount
	{
		 get { } //Length: 51
	}

	public int cullingMask
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Matrix4x4 cullingMatrix
	{
		 get { } //Length: 87
		 set { } //Length: 66
	}

	public static Camera current
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	public float depth
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public DepthTextureMode depthTextureMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int eventMask
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[NativeProperty]
	public float farClipPlane
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	[NativeProperty]
	public float fieldOfView
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public float focalLength
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	[NativeProperty]
	public bool forceIntoRenderTexture
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public GateFitMode gateFit
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Single[] layerCullDistances
	{
		 get { } //Length: 51
		 set { } //Length: 158
	}

	public bool layerCullSpherical
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Vector2 lensShift
	{
		 get { } //Length: 70
		 set { } //Length: 61
	}

	public static Camera main
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	[NativeProperty]
	public float nearClipPlane
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public Matrix4x4 nonJitteredProjectionMatrix
	{
		 get { } //Length: 87
		 set { } //Length: 66
	}

	public OpaqueSortMode opaqueSortMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool orthographic
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float orthographicSize
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public ulong overrideSceneCullingMask
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int pixelHeight
	{
		[FreeFunction]
		 get { } //Length: 51
	}

	[NativeProperty]
	public Rect pixelRect
	{
		 get { } //Length: 75
		 set { } //Length: 66
	}

	public int pixelWidth
	{
		[FreeFunction]
		 get { } //Length: 51
	}

	internal static int PreviewCullingLayer
	{
		[FreeFunction]
		internal get { } //Length: 42
	}

	public Matrix4x4 previousViewProjectionMatrix
	{
		 get { } //Length: 87
	}

	public Matrix4x4 projectionMatrix
	{
		 get { } //Length: 87
		 set { } //Length: 66
	}

	internal ProjectionMatrixMode projectionMatrixMode
	{
		internal get { } //Length: 51
	}

	[NativeProperty]
	public Rect rect
	{
		 get { } //Length: 75
		 set { } //Length: 66
	}

	public RenderingPath renderingPath
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int scaledPixelHeight
	{
		[FreeFunction]
		 get { } //Length: 51
	}

	public int scaledPixelWidth
	{
		[FreeFunction]
		 get { } //Length: 51
	}

	public Scene scene
	{
		[FreeFunction]
		 get { } //Length: 68
		[FreeFunction]
		 set { } //Length: 59
	}

	public Vector2 sensorSize
	{
		 get { } //Length: 70
		 set { } //Length: 61
	}

	public MonoOrStereoscopicEye stereoActiveEye
	{
		[FreeFunction]
		 get { } //Length: 51
	}

	public float stereoConvergence
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public bool stereoEnabled
	{
		 get { } //Length: 51
	}

	public float stereoSeparation
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public StereoTargetEyeMask stereoTargetEye
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int targetDisplay
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public RenderTexture targetTexture
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Vector3 transparencySortAxis
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public TransparencySortMode transparencySortMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[NativeProperty]
	public bool useJitteredProjectionMatrixForTransparentRendering
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool useOcclusionCulling
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool usePhysicalProperties
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Vector3 velocity
	{
		 get { } //Length: 77
	}

	public Matrix4x4 worldToCameraMatrix
	{
		 get { } //Length: 87
		 set { } //Length: 66
	}

	public Camera() { }

	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	public void AddCommandBufferAsync(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void AddCommandBufferAsyncImpl(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	public void CalculateFrustumCorners(Rect viewport, float z, MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	[FreeFunction]
	private void CalculateFrustumCornersInternal(Rect viewport, float z, MonoOrStereoscopicEye eye, out Vector3[] outCorners) { }

	private void CalculateFrustumCornersInternal_Injected(ref Rect viewport, float z, MonoOrStereoscopicEye eye, out Vector3[] outCorners) { }

	[FreeFunction]
	public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane) { }

	private void CalculateObliqueMatrix_Injected(ref Vector4 clipPlane, out Matrix4x4 ret) { }

	public static void CalculateProjectionMatrixFromPhysicalProperties(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, GateFitParameters gateFitParameters = null) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, float gateAspect, GateFitMode gateFitMode) { }

	private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(out Matrix4x4 output, float focalLength, ref Vector2 sensorSize, ref Vector2 lensShift, float nearClip, float farClip, float gateAspect, GateFitMode gateFitMode) { }

	[FreeFunction]
	public void CopyFrom(Camera other) { }

	public void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye eye) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize) { }

	[RequiredByNativeCode]
	private static void FireOnPostRender(Camera cam) { }

	[RequiredByNativeCode]
	private static void FireOnPreCull(Camera cam) { }

	[RequiredByNativeCode]
	private static void FireOnPreRender(Camera cam) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static float FocalLengthToFieldOfView(float focalLength, float sensorSize) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public RenderTexture get_activeTexture() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public RenderingPath get_actualRenderingPath() { }

	public static Camera[] get_allCameras() { }

	public static int get_allCamerasCount() { }

	public bool get_allowDynamicResolution() { }

	public bool get_allowHDR() { }

	public bool get_allowMSAA() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool get_areVRStereoViewMatricesWithinSingleCullTolerance() { }

	public float get_aspect() { }

	public Color get_backgroundColor() { }

	private void get_backgroundColor_Injected(out Color ret) { }

	public Matrix4x4 get_cameraToWorldMatrix() { }

	private void get_cameraToWorldMatrix_Injected(out Matrix4x4 ret) { }

	public CameraType get_cameraType() { }

	public CameraClearFlags get_clearFlags() { }

	public bool get_clearStencilAfterLightingPass() { }

	public int get_commandBufferCount() { }

	public int get_cullingMask() { }

	public Matrix4x4 get_cullingMatrix() { }

	private void get_cullingMatrix_Injected(out Matrix4x4 ret) { }

	[FreeFunction]
	public static Camera get_current() { }

	public float get_depth() { }

	public DepthTextureMode get_depthTextureMode() { }

	public int get_eventMask() { }

	public float get_farClipPlane() { }

	public float get_fieldOfView() { }

	public float get_focalLength() { }

	public bool get_forceIntoRenderTexture() { }

	public GateFitMode get_gateFit() { }

	public Single[] get_layerCullDistances() { }

	public bool get_layerCullSpherical() { }

	public Vector2 get_lensShift() { }

	private void get_lensShift_Injected(out Vector2 ret) { }

	[FreeFunction]
	public static Camera get_main() { }

	public float get_nearClipPlane() { }

	public Matrix4x4 get_nonJitteredProjectionMatrix() { }

	private void get_nonJitteredProjectionMatrix_Injected(out Matrix4x4 ret) { }

	public OpaqueSortMode get_opaqueSortMode() { }

	public bool get_orthographic() { }

	public float get_orthographicSize() { }

	public ulong get_overrideSceneCullingMask() { }

	[FreeFunction]
	public int get_pixelHeight() { }

	public Rect get_pixelRect() { }

	private void get_pixelRect_Injected(out Rect ret) { }

	[FreeFunction]
	public int get_pixelWidth() { }

	[FreeFunction]
	internal static int get_PreviewCullingLayer() { }

	public Matrix4x4 get_previousViewProjectionMatrix() { }

	private void get_previousViewProjectionMatrix_Injected(out Matrix4x4 ret) { }

	public Matrix4x4 get_projectionMatrix() { }

	private void get_projectionMatrix_Injected(out Matrix4x4 ret) { }

	internal ProjectionMatrixMode get_projectionMatrixMode() { }

	public Rect get_rect() { }

	private void get_rect_Injected(out Rect ret) { }

	public RenderingPath get_renderingPath() { }

	[FreeFunction]
	public int get_scaledPixelHeight() { }

	[FreeFunction]
	public int get_scaledPixelWidth() { }

	[FreeFunction]
	public Scene get_scene() { }

	private void get_scene_Injected(out Scene ret) { }

	public Vector2 get_sensorSize() { }

	private void get_sensorSize_Injected(out Vector2 ret) { }

	[FreeFunction]
	public MonoOrStereoscopicEye get_stereoActiveEye() { }

	public float get_stereoConvergence() { }

	public bool get_stereoEnabled() { }

	public float get_stereoSeparation() { }

	public StereoTargetEyeMask get_stereoTargetEye() { }

	public int get_targetDisplay() { }

	public RenderTexture get_targetTexture() { }

	public Vector3 get_transparencySortAxis() { }

	private void get_transparencySortAxis_Injected(out Vector3 ret) { }

	public TransparencySortMode get_transparencySortMode() { }

	public bool get_useJitteredProjectionMatrixForTransparentRendering() { }

	public bool get_useOcclusionCulling() { }

	public bool get_usePhysicalProperties() { }

	public Vector3 get_velocity() { }

	private void get_velocity_Injected(out Vector3 ret) { }

	public Matrix4x4 get_worldToCameraMatrix() { }

	private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret) { }

	public static int GetAllCameras(Camera[] cameras) { }

	[FreeFunction]
	private static int GetAllCamerasCount() { }

	[FreeFunction]
	private static int GetAllCamerasImpl(out Camera[] cam) { }

	internal String[] GetCameraBufferWarnings() { }

	[FreeFunction]
	public CommandBuffer[] GetCommandBuffers(CameraEvent evt) { }

	[FreeFunction]
	[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static bool GetCullingParameters_Internal(Camera camera, bool stereoAware, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize) { }

	internal Vector2 GetFrustumPlaneSizeAt(float distance) { }

	private void GetFrustumPlaneSizeAt_Injected(float distance, out Vector2 ret) { }

	public float GetGateFittedFieldOfView() { }

	public Vector2 GetGateFittedLensShift() { }

	private void GetGateFittedLensShift_Injected(out Vector2 ret) { }

	[FreeFunction]
	private Single[] GetLayerCullDistances() { }

	internal Vector3 GetLocalSpaceAim() { }

	private void GetLocalSpaceAim_Injected(out Vector3 ret) { }

	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye eye) { }

	private void GetStereoNonJitteredProjectionMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret) { }

	[FreeFunction]
	public Matrix4x4 GetStereoProjectionMatrix(StereoscopicEye eye) { }

	private void GetStereoProjectionMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret) { }

	[FreeFunction]
	public Matrix4x4 GetStereoViewMatrix(StereoscopicEye eye) { }

	private void GetStereoViewMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio) { }

	internal void OnlyUsedForTesting1() { }

	internal void OnlyUsedForTesting2() { }

	public void RemoveAllCommandBuffers() { }

	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	public void RemoveCommandBuffers(CameraEvent evt) { }

	[FreeFunction]
	public void Render() { }

	[FreeFunction]
	public void RenderDontRestore() { }

	public bool RenderToCubemap(Cubemap cubemap) { }

	public bool RenderToCubemap(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) { }

	public bool RenderToCubemap(RenderTexture cubemap) { }

	public bool RenderToCubemap(RenderTexture cubemap, int faceMask) { }

	public bool RenderToCubemap(Cubemap cubemap, int faceMask) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool RenderToCubemapEyeImpl(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) { }

	[FreeFunction]
	private bool RenderToCubemapImpl(Texture tex, int faceMask) { }

	[FreeFunction]
	public void RenderWithShader(Shader shader, string replacementTag) { }

	public void Reset() { }

	public void ResetAspect() { }

	public void ResetCullingMatrix() { }

	public void ResetProjectionMatrix() { }

	public void ResetReplacementShader() { }

	public void ResetStereoProjectionMatrices() { }

	public void ResetStereoViewMatrices() { }

	public void ResetTransparencySortSettings() { }

	public void ResetWorldToCameraMatrix() { }

	public Ray ScreenPointToRay(Vector3 pos) { }

	public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	private void ScreenPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) { }

	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	public Vector3 ScreenToWorldPoint(Vector3 position) { }

	public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	private void ScreenToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	public void set_allowDynamicResolution(bool value) { }

	public void set_allowHDR(bool value) { }

	public void set_allowMSAA(bool value) { }

	public void set_aspect(float value) { }

	public void set_backgroundColor(Color value) { }

	private void set_backgroundColor_Injected(ref Color value) { }

	public void set_cameraType(CameraType value) { }

	public void set_clearFlags(CameraClearFlags value) { }

	public void set_clearStencilAfterLightingPass(bool value) { }

	public void set_cullingMask(int value) { }

	public void set_cullingMatrix(Matrix4x4 value) { }

	private void set_cullingMatrix_Injected(ref Matrix4x4 value) { }

	public void set_depth(float value) { }

	public void set_depthTextureMode(DepthTextureMode value) { }

	public void set_eventMask(int value) { }

	public void set_farClipPlane(float value) { }

	public void set_fieldOfView(float value) { }

	public void set_focalLength(float value) { }

	public void set_forceIntoRenderTexture(bool value) { }

	public void set_gateFit(GateFitMode value) { }

	public void set_layerCullDistances(Single[] value) { }

	public void set_layerCullSpherical(bool value) { }

	public void set_lensShift(Vector2 value) { }

	private void set_lensShift_Injected(ref Vector2 value) { }

	public void set_nearClipPlane(float value) { }

	public void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	private void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value) { }

	public void set_opaqueSortMode(OpaqueSortMode value) { }

	public void set_orthographic(bool value) { }

	public void set_orthographicSize(float value) { }

	public void set_overrideSceneCullingMask(ulong value) { }

	public void set_pixelRect(Rect value) { }

	private void set_pixelRect_Injected(ref Rect value) { }

	public void set_projectionMatrix(Matrix4x4 value) { }

	private void set_projectionMatrix_Injected(ref Matrix4x4 value) { }

	public void set_rect(Rect value) { }

	private void set_rect_Injected(ref Rect value) { }

	public void set_renderingPath(RenderingPath value) { }

	[FreeFunction]
	public void set_scene(Scene value) { }

	private void set_scene_Injected(ref Scene value) { }

	public void set_sensorSize(Vector2 value) { }

	private void set_sensorSize_Injected(ref Vector2 value) { }

	public void set_stereoConvergence(float value) { }

	public void set_stereoSeparation(float value) { }

	public void set_stereoTargetEye(StereoTargetEyeMask value) { }

	public void set_targetDisplay(int value) { }

	public void set_targetTexture(RenderTexture value) { }

	public void set_transparencySortAxis(Vector3 value) { }

	private void set_transparencySortAxis_Injected(ref Vector3 value) { }

	public void set_transparencySortMode(TransparencySortMode value) { }

	public void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	public void set_useOcclusionCulling(bool value) { }

	public void set_usePhysicalProperties(bool value) { }

	public void set_worldToCameraMatrix(Matrix4x4 value) { }

	private void set_worldToCameraMatrix_Injected(ref Matrix4x4 value) { }

	[FreeFunction]
	private void SetLayerCullDistances(Single[] d) { }

	public void SetReplacementShader(Shader shader, string replacementTag) { }

	public void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	private void SetStereoProjectionMatrix_Injected(StereoscopicEye eye, ref Matrix4x4 matrix) { }

	public void SetStereoViewMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	private void SetStereoViewMatrix_Injected(StereoscopicEye eye, ref Matrix4x4 matrix) { }

	public void SetTargetBuffers(RenderBuffer[] colorBuffer, RenderBuffer depthBuffer) { }

	public void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer) { }

	[FreeFunction]
	private void SetTargetBuffersImpl(RenderBuffer color, RenderBuffer depth) { }

	private void SetTargetBuffersImpl_Injected(ref RenderBuffer color, ref RenderBuffer depth) { }

	[FreeFunction]
	private void SetTargetBuffersMRTImpl(RenderBuffer[] color, RenderBuffer depth) { }

	private void SetTargetBuffersMRTImpl_Injected(RenderBuffer[] color, ref RenderBuffer depth) { }

	[FreeFunction]
	public static void SetupCurrent(Camera cur) { }

	public bool TryGetCullingParameters(bool stereoAware, out ScriptableCullingParameters cullingParameters) { }

	public bool TryGetCullingParameters(out ScriptableCullingParameters cullingParameters) { }

	public static float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio) { }

	public Ray ViewportPointToRay(Vector3 pos) { }

	public Ray ViewportPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	private Ray ViewportPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	private void ViewportPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) { }

	public Vector3 ViewportToScreenPoint(Vector3 position) { }

	private void ViewportToScreenPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	public Vector3 ViewportToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	public Vector3 ViewportToWorldPoint(Vector3 position) { }

	private void ViewportToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	public Vector3 WorldToScreenPoint(Vector3 position) { }

	public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	private void WorldToScreenPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	public Vector3 WorldToViewportPoint(Vector3 position) { }

	public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	private void WorldToViewportPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

}

