namespace UnityEngine.Windows.WebCam;

[MovedFrom(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class VideoCapture : IDisposable
{
	internal enum CaptureResultType
	{
		Success = 0,
		UnknownError = 1,
	}

	internal sealed class OnStartedRecordingVideoCallback : MulticastDelegate
	{

		public OnStartedRecordingVideoCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(VideoCaptureResult result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(VideoCaptureResult result) { }

	}

	internal sealed class OnStoppedRecordingVideoCallback : MulticastDelegate
	{

		public OnStoppedRecordingVideoCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(VideoCaptureResult result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(VideoCaptureResult result) { }

	}

	internal sealed class OnVideoCaptureResourceCreatedCallback : MulticastDelegate
	{

		public OnVideoCaptureResourceCreatedCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(VideoCapture captureObject, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(VideoCapture captureObject) { }

	}

	internal sealed class OnVideoModeStartedCallback : MulticastDelegate
	{

		public OnVideoModeStartedCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(VideoCaptureResult result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(VideoCaptureResult result) { }

	}

	internal sealed class OnVideoModeStoppedCallback : MulticastDelegate
	{

		public OnVideoModeStoppedCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(VideoCaptureResult result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(VideoCaptureResult result) { }

	}

	internal struct VideoCaptureResult
	{
		public CaptureResultType resultType; //Field offset: 0x0
		public long hResult; //Field offset: 0x8

	}

	private static readonly long HR_SUCCESS; //Field offset: 0x0
	internal IntPtr m_NativePtr; //Field offset: 0x10

	private static VideoCapture() { }

	private VideoCapture(IntPtr nativeCaptureObject) { }

	public override void Dispose() { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[NativeMethod]
	private void Dispose_Internal() { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[NativeMethod]
	[ThreadAndSerializationSafe]
	private void DisposeThreaded_Internal() { }

	protected virtual void Finalize() { }

	[RequiredByNativeCode]
	private static void InvokeOnCreatedVideoCaptureResourceDelegate(OnVideoCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	[RequiredByNativeCode]
	private static void InvokeOnStartedRecordingVideoToDiskDelegate(OnStartedRecordingVideoCallback callback, long hResult) { }

	[RequiredByNativeCode]
	private static void InvokeOnStoppedRecordingVideoToDiskDelegate(OnStoppedRecordingVideoCallback callback, long hResult) { }

	[RequiredByNativeCode]
	private static void InvokeOnVideoModeStartedDelegate(OnVideoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCode]
	private static void InvokeOnVideoModeStoppedDelegate(OnVideoModeStoppedCallback callback, long hResult) { }

	private static VideoCaptureResult MakeCaptureResult(long hResult) { }

}

