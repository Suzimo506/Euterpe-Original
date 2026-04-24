namespace ZenFulcrum.VR.OpenVRBinding;

public struct IVRCompositor
{
	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _CanRenderScene : MulticastDelegate
	{

		public _CanRenderScene(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ClearLastSubmittedFrame : MulticastDelegate
	{

		public _ClearLastSubmittedFrame(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ClearSkyboxOverride : MulticastDelegate
	{

		public _ClearSkyboxOverride(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _CompositorBringToFront : MulticastDelegate
	{

		public _CompositorBringToFront(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _CompositorDumpImages : MulticastDelegate
	{

		public _CompositorDumpImages(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _CompositorGoToBack : MulticastDelegate
	{

		public _CompositorGoToBack(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _CompositorQuit : MulticastDelegate
	{

		public _CompositorQuit(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _FadeGrid : MulticastDelegate
	{

		public _FadeGrid(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(float fSeconds, bool bFadeIn, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(float fSeconds, bool bFadeIn) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _FadeToColor : MulticastDelegate
	{

		public _FadeToColor(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ForceInterleavedReprojectionOn : MulticastDelegate
	{

		public _ForceInterleavedReprojectionOn(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool bOverride, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool bOverride) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ForceReconnectProcess : MulticastDelegate
	{

		public _ForceReconnectProcess(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetCumulativeStats : MulticastDelegate
	{

		public _GetCumulativeStats(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref Compositor_CumulativeStats pStats, uint nStatsSizeInBytes, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref Compositor_CumulativeStats pStats, IAsyncResult result) { }

		public override void Invoke(ref Compositor_CumulativeStats pStats, uint nStatsSizeInBytes) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetCurrentFadeColor : MulticastDelegate
	{

		public _GetCurrentFadeColor(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool bBackground, AsyncCallback callback, object object) { }

		public override HmdColor_t EndInvoke(IAsyncResult result) { }

		public override HmdColor_t Invoke(bool bBackground) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetCurrentGridAlpha : MulticastDelegate
	{

		public _GetCurrentGridAlpha(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override float EndInvoke(IAsyncResult result) { }

		public override float Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetCurrentSceneFocusProcess : MulticastDelegate
	{

		public _GetCurrentSceneFocusProcess(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetFrameTimeRemaining : MulticastDelegate
	{

		public _GetFrameTimeRemaining(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override float EndInvoke(IAsyncResult result) { }

		public override float Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetFrameTiming : MulticastDelegate
	{

		public _GetFrameTiming(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref Compositor_FrameTiming pTiming, uint unFramesAgo, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref Compositor_FrameTiming pTiming, IAsyncResult result) { }

		public override bool Invoke(ref Compositor_FrameTiming pTiming, uint unFramesAgo) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetFrameTimings : MulticastDelegate
	{

		public _GetFrameTimings(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref Compositor_FrameTiming pTiming, uint nFrames, AsyncCallback callback, object object) { }

		public override uint EndInvoke(ref Compositor_FrameTiming pTiming, IAsyncResult result) { }

		public override uint Invoke(ref Compositor_FrameTiming pTiming, uint nFrames) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetLastFrameRenderer : MulticastDelegate
	{

		public _GetLastFrameRenderer(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetLastPoseForTrackedDeviceIndex : MulticastDelegate
	{

		public _GetLastPoseForTrackedDeviceIndex(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unDeviceIndex, ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose, AsyncCallback callback, object object) { }

		public override EVRCompositorError EndInvoke(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose, IAsyncResult result) { }

		public override EVRCompositorError Invoke(uint unDeviceIndex, ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetLastPoses : MulticastDelegate
	{

		public _GetLastPoses(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(out TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, out TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount, AsyncCallback callback, object object) { }

		public override EVRCompositorError EndInvoke(IAsyncResult result) { }

		public override EVRCompositorError Invoke(out TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, out TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetMirrorTextureD3D11 : MulticastDelegate
	{

		public _GetMirrorTextureD3D11(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EVREye eEye, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView, AsyncCallback callback, object object) { }

		public override EVRCompositorError EndInvoke(ref IntPtr ppD3D11ShaderResourceView, IAsyncResult result) { }

		public override EVRCompositorError Invoke(EVREye eEye, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetMirrorTextureGL : MulticastDelegate
	{

		public _GetMirrorTextureGL(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EVREye eEye, ref uint pglTextureId, IntPtr pglSharedTextureHandle, AsyncCallback callback, object object) { }

		public override EVRCompositorError EndInvoke(ref uint pglTextureId, IAsyncResult result) { }

		public override EVRCompositorError Invoke(EVREye eEye, ref uint pglTextureId, IntPtr pglSharedTextureHandle) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetTrackingSpace : MulticastDelegate
	{

		public _GetTrackingSpace(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override ETrackingUniverseOrigin EndInvoke(IAsyncResult result) { }

		public override ETrackingUniverseOrigin Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetVulkanDeviceExtensionsRequired : MulticastDelegate
	{

		public _GetVulkanDeviceExtensionsRequired(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr pPhysicalDevice, StringBuilder pchValue, uint unBufferSize, AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke(IntPtr pPhysicalDevice, StringBuilder pchValue, uint unBufferSize) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetVulkanInstanceExtensionsRequired : MulticastDelegate
	{

		public _GetVulkanInstanceExtensionsRequired(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(StringBuilder pchValue, uint unBufferSize, AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke(StringBuilder pchValue, uint unBufferSize) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _HideMirrorWindow : MulticastDelegate
	{

		public _HideMirrorWindow(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _IsFullscreen : MulticastDelegate
	{

		public _IsFullscreen(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _IsMirrorWindowVisible : MulticastDelegate
	{

		public _IsMirrorWindowVisible(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _IsMotionSmoothingEnabled : MulticastDelegate
	{

		public _IsMotionSmoothingEnabled(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _LockGLSharedTextureForAccess : MulticastDelegate
	{

		public _LockGLSharedTextureForAccess(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr glSharedTextureHandle, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr glSharedTextureHandle) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _PostPresentHandoff : MulticastDelegate
	{

		public _PostPresentHandoff(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ReleaseMirrorTextureD3D11 : MulticastDelegate
	{

		public _ReleaseMirrorTextureD3D11(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr pD3D11ShaderResourceView, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr pD3D11ShaderResourceView) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ReleaseSharedGLTexture : MulticastDelegate
	{

		public _ReleaseSharedGLTexture(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint glTextureId, IntPtr glSharedTextureHandle, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(uint glTextureId, IntPtr glSharedTextureHandle) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetExplicitTimingMode : MulticastDelegate
	{

		public _SetExplicitTimingMode(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EVRCompositorTimingMode eTimingMode, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(EVRCompositorTimingMode eTimingMode) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetSkyboxOverride : MulticastDelegate
	{

		public _SetSkyboxOverride(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(out Texture_t[] pTextures, uint unTextureCount, AsyncCallback callback, object object) { }

		public override EVRCompositorError EndInvoke(IAsyncResult result) { }

		public override EVRCompositorError Invoke(out Texture_t[] pTextures, uint unTextureCount) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetTrackingSpace : MulticastDelegate
	{

		public _SetTrackingSpace(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ETrackingUniverseOrigin eOrigin, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ETrackingUniverseOrigin eOrigin) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ShouldAppRenderWithLowResources : MulticastDelegate
	{

		public _ShouldAppRenderWithLowResources(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ShowMirrorWindow : MulticastDelegate
	{

		public _ShowMirrorWindow(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _Submit : MulticastDelegate
	{

		public _Submit(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EVREye eEye, ref Texture_t pTexture, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags, AsyncCallback callback, object object) { }

		public override EVRCompositorError EndInvoke(ref Texture_t pTexture, ref VRTextureBounds_t pBounds, IAsyncResult result) { }

		public override EVRCompositorError Invoke(EVREye eEye, ref Texture_t pTexture, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SubmitExplicitTimingData : MulticastDelegate
	{

		public _SubmitExplicitTimingData(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override EVRCompositorError EndInvoke(IAsyncResult result) { }

		public override EVRCompositorError Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SuspendRendering : MulticastDelegate
	{

		public _SuspendRendering(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool bSuspend, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool bSuspend) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _UnlockGLSharedTextureForAccess : MulticastDelegate
	{

		public _UnlockGLSharedTextureForAccess(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr glSharedTextureHandle, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr glSharedTextureHandle) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _WaitGetPoses : MulticastDelegate
	{

		public _WaitGetPoses(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(out TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, out TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount, AsyncCallback callback, object object) { }

		public override EVRCompositorError EndInvoke(IAsyncResult result) { }

		public override EVRCompositorError Invoke(out TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, out TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount) { }

	}

	internal _SetTrackingSpace SetTrackingSpace; //Field offset: 0x0
	internal _GetTrackingSpace GetTrackingSpace; //Field offset: 0x8
	internal _WaitGetPoses WaitGetPoses; //Field offset: 0x10
	internal _GetLastPoses GetLastPoses; //Field offset: 0x18
	internal _GetLastPoseForTrackedDeviceIndex GetLastPoseForTrackedDeviceIndex; //Field offset: 0x20
	internal _Submit Submit; //Field offset: 0x28
	internal _ClearLastSubmittedFrame ClearLastSubmittedFrame; //Field offset: 0x30
	internal _PostPresentHandoff PostPresentHandoff; //Field offset: 0x38
	internal _GetFrameTiming GetFrameTiming; //Field offset: 0x40
	internal _GetFrameTimings GetFrameTimings; //Field offset: 0x48
	internal _GetFrameTimeRemaining GetFrameTimeRemaining; //Field offset: 0x50
	internal _GetCumulativeStats GetCumulativeStats; //Field offset: 0x58
	internal _FadeToColor FadeToColor; //Field offset: 0x60
	internal _GetCurrentFadeColor GetCurrentFadeColor; //Field offset: 0x68
	internal _FadeGrid FadeGrid; //Field offset: 0x70
	internal _GetCurrentGridAlpha GetCurrentGridAlpha; //Field offset: 0x78
	internal _SetSkyboxOverride SetSkyboxOverride; //Field offset: 0x80
	internal _ClearSkyboxOverride ClearSkyboxOverride; //Field offset: 0x88
	internal _CompositorBringToFront CompositorBringToFront; //Field offset: 0x90
	internal _CompositorGoToBack CompositorGoToBack; //Field offset: 0x98
	internal _CompositorQuit CompositorQuit; //Field offset: 0xA0
	internal _IsFullscreen IsFullscreen; //Field offset: 0xA8
	internal _GetCurrentSceneFocusProcess GetCurrentSceneFocusProcess; //Field offset: 0xB0
	internal _GetLastFrameRenderer GetLastFrameRenderer; //Field offset: 0xB8
	internal _CanRenderScene CanRenderScene; //Field offset: 0xC0
	internal _ShowMirrorWindow ShowMirrorWindow; //Field offset: 0xC8
	internal _HideMirrorWindow HideMirrorWindow; //Field offset: 0xD0
	internal _IsMirrorWindowVisible IsMirrorWindowVisible; //Field offset: 0xD8
	internal _CompositorDumpImages CompositorDumpImages; //Field offset: 0xE0
	internal _ShouldAppRenderWithLowResources ShouldAppRenderWithLowResources; //Field offset: 0xE8
	internal _ForceInterleavedReprojectionOn ForceInterleavedReprojectionOn; //Field offset: 0xF0
	internal _ForceReconnectProcess ForceReconnectProcess; //Field offset: 0xF8
	internal _SuspendRendering SuspendRendering; //Field offset: 0x100
	internal _GetMirrorTextureD3D11 GetMirrorTextureD3D11; //Field offset: 0x108
	internal _ReleaseMirrorTextureD3D11 ReleaseMirrorTextureD3D11; //Field offset: 0x110
	internal _GetMirrorTextureGL GetMirrorTextureGL; //Field offset: 0x118
	internal _ReleaseSharedGLTexture ReleaseSharedGLTexture; //Field offset: 0x120
	internal _LockGLSharedTextureForAccess LockGLSharedTextureForAccess; //Field offset: 0x128
	internal _UnlockGLSharedTextureForAccess UnlockGLSharedTextureForAccess; //Field offset: 0x130
	internal _GetVulkanInstanceExtensionsRequired GetVulkanInstanceExtensionsRequired; //Field offset: 0x138
	internal _GetVulkanDeviceExtensionsRequired GetVulkanDeviceExtensionsRequired; //Field offset: 0x140
	internal _SetExplicitTimingMode SetExplicitTimingMode; //Field offset: 0x148
	internal _SubmitExplicitTimingData SubmitExplicitTimingData; //Field offset: 0x150
	internal _IsMotionSmoothingEnabled IsMotionSmoothingEnabled; //Field offset: 0x158

}

