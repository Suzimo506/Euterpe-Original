namespace ZenFulcrum.VR.OpenVRBinding;

public class CVRTrackedCamera
{
	private IVRTrackedCamera FnTable; //Field offset: 0x10

	internal CVRTrackedCamera(IntPtr pInterface) { }

	public EVRTrackedCameraError AcquireVideoStreamingService(uint nDeviceIndex, ref ulong pHandle) { }

	public string GetCameraErrorNameFromEnum(EVRTrackedCameraError eCameraError) { }

	public EVRTrackedCameraError GetCameraFrameSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref uint pnWidth, ref uint pnHeight, ref uint pnFrameBufferSize) { }

	public EVRTrackedCameraError GetCameraIntrinsics(uint nDeviceIndex, uint nCameraIndex, EVRTrackedCameraFrameType eFrameType, ref HmdVector2_t pFocalLength, ref HmdVector2_t pCenter) { }

	public EVRTrackedCameraError GetCameraProjection(uint nDeviceIndex, uint nCameraIndex, EVRTrackedCameraFrameType eFrameType, float flZNear, float flZFar, ref HmdMatrix44_t pProjection) { }

	public EVRTrackedCameraError GetVideoStreamFrameBuffer(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pFrameBuffer, uint nFrameBufferSize, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize) { }

	public EVRTrackedCameraError GetVideoStreamTextureD3D11(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize) { }

	public EVRTrackedCameraError GetVideoStreamTextureGL(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, ref uint pglTextureId, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize) { }

	public EVRTrackedCameraError GetVideoStreamTextureSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref VRTextureBounds_t pTextureBounds, ref uint pnWidth, ref uint pnHeight) { }

	public EVRTrackedCameraError HasCamera(uint nDeviceIndex, ref bool pHasCamera) { }

	public EVRTrackedCameraError ReleaseVideoStreamingService(ulong hTrackedCamera) { }

	public EVRTrackedCameraError ReleaseVideoStreamTextureGL(ulong hTrackedCamera, uint glTextureId) { }

}

