namespace ZenFulcrum.VR.OpenVRBinding;

public struct IVRTrackedCamera
{
	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _AcquireVideoStreamingService : MulticastDelegate
	{

		public _AcquireVideoStreamingService(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint nDeviceIndex, ref ulong pHandle, AsyncCallback callback, object object) { }

		public override EVRTrackedCameraError EndInvoke(ref ulong pHandle, IAsyncResult result) { }

		public override EVRTrackedCameraError Invoke(uint nDeviceIndex, ref ulong pHandle) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetCameraErrorNameFromEnum : MulticastDelegate
	{

		public _GetCameraErrorNameFromEnum(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EVRTrackedCameraError eCameraError, AsyncCallback callback, object object) { }

		public override IntPtr EndInvoke(IAsyncResult result) { }

		public override IntPtr Invoke(EVRTrackedCameraError eCameraError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetCameraFrameSize : MulticastDelegate
	{

		public _GetCameraFrameSize(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref uint pnWidth, ref uint pnHeight, ref uint pnFrameBufferSize, AsyncCallback callback, object object) { }

		public override EVRTrackedCameraError EndInvoke(ref uint pnWidth, ref uint pnHeight, ref uint pnFrameBufferSize, IAsyncResult result) { }

		public override EVRTrackedCameraError Invoke(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref uint pnWidth, ref uint pnHeight, ref uint pnFrameBufferSize) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetCameraIntrinsics : MulticastDelegate
	{

		public _GetCameraIntrinsics(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint nDeviceIndex, uint nCameraIndex, EVRTrackedCameraFrameType eFrameType, ref HmdVector2_t pFocalLength, ref HmdVector2_t pCenter, AsyncCallback callback, object object) { }

		public override EVRTrackedCameraError EndInvoke(ref HmdVector2_t pFocalLength, ref HmdVector2_t pCenter, IAsyncResult result) { }

		public override EVRTrackedCameraError Invoke(uint nDeviceIndex, uint nCameraIndex, EVRTrackedCameraFrameType eFrameType, ref HmdVector2_t pFocalLength, ref HmdVector2_t pCenter) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetCameraProjection : MulticastDelegate
	{

		public _GetCameraProjection(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint nDeviceIndex, uint nCameraIndex, EVRTrackedCameraFrameType eFrameType, float flZNear, float flZFar, ref HmdMatrix44_t pProjection, AsyncCallback callback, object object) { }

		public override EVRTrackedCameraError EndInvoke(ref HmdMatrix44_t pProjection, IAsyncResult result) { }

		public override EVRTrackedCameraError Invoke(uint nDeviceIndex, uint nCameraIndex, EVRTrackedCameraFrameType eFrameType, float flZNear, float flZFar, ref HmdMatrix44_t pProjection) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetVideoStreamFrameBuffer : MulticastDelegate
	{

		public _GetVideoStreamFrameBuffer(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pFrameBuffer, uint nFrameBufferSize, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize, AsyncCallback callback, object object) { }

		public override EVRTrackedCameraError EndInvoke(ref CameraVideoStreamFrameHeader_t pFrameHeader, IAsyncResult result) { }

		public override EVRTrackedCameraError Invoke(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pFrameBuffer, uint nFrameBufferSize, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetVideoStreamTextureD3D11 : MulticastDelegate
	{

		public _GetVideoStreamTextureD3D11(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize, AsyncCallback callback, object object) { }

		public override EVRTrackedCameraError EndInvoke(ref IntPtr ppD3D11ShaderResourceView, ref CameraVideoStreamFrameHeader_t pFrameHeader, IAsyncResult result) { }

		public override EVRTrackedCameraError Invoke(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetVideoStreamTextureGL : MulticastDelegate
	{

		public _GetVideoStreamTextureGL(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, ref uint pglTextureId, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize, AsyncCallback callback, object object) { }

		public override EVRTrackedCameraError EndInvoke(ref uint pglTextureId, ref CameraVideoStreamFrameHeader_t pFrameHeader, IAsyncResult result) { }

		public override EVRTrackedCameraError Invoke(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, ref uint pglTextureId, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetVideoStreamTextureSize : MulticastDelegate
	{

		public _GetVideoStreamTextureSize(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref VRTextureBounds_t pTextureBounds, ref uint pnWidth, ref uint pnHeight, AsyncCallback callback, object object) { }

		public override EVRTrackedCameraError EndInvoke(ref VRTextureBounds_t pTextureBounds, ref uint pnWidth, ref uint pnHeight, IAsyncResult result) { }

		public override EVRTrackedCameraError Invoke(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref VRTextureBounds_t pTextureBounds, ref uint pnWidth, ref uint pnHeight) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _HasCamera : MulticastDelegate
	{

		public _HasCamera(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint nDeviceIndex, ref bool pHasCamera, AsyncCallback callback, object object) { }

		public override EVRTrackedCameraError EndInvoke(ref bool pHasCamera, IAsyncResult result) { }

		public override EVRTrackedCameraError Invoke(uint nDeviceIndex, ref bool pHasCamera) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ReleaseVideoStreamingService : MulticastDelegate
	{

		public _ReleaseVideoStreamingService(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong hTrackedCamera, AsyncCallback callback, object object) { }

		public override EVRTrackedCameraError EndInvoke(IAsyncResult result) { }

		public override EVRTrackedCameraError Invoke(ulong hTrackedCamera) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ReleaseVideoStreamTextureGL : MulticastDelegate
	{

		public _ReleaseVideoStreamTextureGL(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong hTrackedCamera, uint glTextureId, AsyncCallback callback, object object) { }

		public override EVRTrackedCameraError EndInvoke(IAsyncResult result) { }

		public override EVRTrackedCameraError Invoke(ulong hTrackedCamera, uint glTextureId) { }

	}

	internal _GetCameraErrorNameFromEnum GetCameraErrorNameFromEnum; //Field offset: 0x0
	internal _HasCamera HasCamera; //Field offset: 0x8
	internal _GetCameraFrameSize GetCameraFrameSize; //Field offset: 0x10
	internal _GetCameraIntrinsics GetCameraIntrinsics; //Field offset: 0x18
	internal _GetCameraProjection GetCameraProjection; //Field offset: 0x20
	internal _AcquireVideoStreamingService AcquireVideoStreamingService; //Field offset: 0x28
	internal _ReleaseVideoStreamingService ReleaseVideoStreamingService; //Field offset: 0x30
	internal _GetVideoStreamFrameBuffer GetVideoStreamFrameBuffer; //Field offset: 0x38
	internal _GetVideoStreamTextureSize GetVideoStreamTextureSize; //Field offset: 0x40
	internal _GetVideoStreamTextureD3D11 GetVideoStreamTextureD3D11; //Field offset: 0x48
	internal _GetVideoStreamTextureGL GetVideoStreamTextureGL; //Field offset: 0x50
	internal _ReleaseVideoStreamTextureGL ReleaseVideoStreamTextureGL; //Field offset: 0x58

}

