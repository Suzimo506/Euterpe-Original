namespace ZenFulcrum.VR.OpenVRBinding;

public class CVRCompositor
{
	private IVRCompositor FnTable; //Field offset: 0x10

	internal CVRCompositor(IntPtr pInterface) { }

	public bool CanRenderScene() { }

	public void ClearLastSubmittedFrame() { }

	public void ClearSkyboxOverride() { }

	public void CompositorBringToFront() { }

	public void CompositorDumpImages() { }

	public void CompositorGoToBack() { }

	public void CompositorQuit() { }

	public void FadeGrid(float fSeconds, bool bFadeIn) { }

	public void FadeToColor(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground) { }

	public void ForceInterleavedReprojectionOn(bool bOverride) { }

	public void ForceReconnectProcess() { }

	public void GetCumulativeStats(ref Compositor_CumulativeStats pStats, uint nStatsSizeInBytes) { }

	public HmdColor_t GetCurrentFadeColor(bool bBackground) { }

	public float GetCurrentGridAlpha() { }

	public uint GetCurrentSceneFocusProcess() { }

	public float GetFrameTimeRemaining() { }

	public bool GetFrameTiming(ref Compositor_FrameTiming pTiming, uint unFramesAgo) { }

	public uint GetFrameTimings(ref Compositor_FrameTiming pTiming, uint nFrames) { }

	public uint GetLastFrameRenderer() { }

	public EVRCompositorError GetLastPoseForTrackedDeviceIndex(uint unDeviceIndex, ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose) { }

	public EVRCompositorError GetLastPoses(TrackedDevicePose_t[] pRenderPoseArray, TrackedDevicePose_t[] pGamePoseArray) { }

	public EVRCompositorError GetMirrorTextureD3D11(EVREye eEye, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView) { }

	public EVRCompositorError GetMirrorTextureGL(EVREye eEye, ref uint pglTextureId, IntPtr pglSharedTextureHandle) { }

	public ETrackingUniverseOrigin GetTrackingSpace() { }

	public uint GetVulkanDeviceExtensionsRequired(IntPtr pPhysicalDevice, StringBuilder pchValue, uint unBufferSize) { }

	public uint GetVulkanInstanceExtensionsRequired(StringBuilder pchValue, uint unBufferSize) { }

	public void HideMirrorWindow() { }

	public bool IsFullscreen() { }

	public bool IsMirrorWindowVisible() { }

	public bool IsMotionSmoothingEnabled() { }

	public void LockGLSharedTextureForAccess(IntPtr glSharedTextureHandle) { }

	public void PostPresentHandoff() { }

	public void ReleaseMirrorTextureD3D11(IntPtr pD3D11ShaderResourceView) { }

	public bool ReleaseSharedGLTexture(uint glTextureId, IntPtr glSharedTextureHandle) { }

	public void SetExplicitTimingMode(EVRCompositorTimingMode eTimingMode) { }

	public EVRCompositorError SetSkyboxOverride(Texture_t[] pTextures) { }

	public void SetTrackingSpace(ETrackingUniverseOrigin eOrigin) { }

	public bool ShouldAppRenderWithLowResources() { }

	public void ShowMirrorWindow() { }

	public EVRCompositorError Submit(EVREye eEye, ref Texture_t pTexture, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags) { }

	public EVRCompositorError SubmitExplicitTimingData() { }

	public void SuspendRendering(bool bSuspend) { }

	public void UnlockGLSharedTextureForAccess(IntPtr glSharedTextureHandle) { }

	public EVRCompositorError WaitGetPoses(TrackedDevicePose_t[] pRenderPoseArray, TrackedDevicePose_t[] pGamePoseArray) { }

}

