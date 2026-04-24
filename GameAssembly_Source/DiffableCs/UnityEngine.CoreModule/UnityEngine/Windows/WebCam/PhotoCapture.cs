namespace UnityEngine.Windows.WebCam;

[MovedFrom(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class PhotoCapture : IDisposable
{
	internal enum CaptureResultType
	{
		Success = 0,
		UnknownError = 1,
	}

	internal sealed class OnCapturedToDiskCallback : MulticastDelegate
	{

		public OnCapturedToDiskCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PhotoCaptureResult result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PhotoCaptureResult result) { }

	}

	internal sealed class OnCapturedToMemoryCallback : MulticastDelegate
	{

		public OnCapturedToMemoryCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame) { }

	}

	internal sealed class OnCaptureResourceCreatedCallback : MulticastDelegate
	{

		public OnCaptureResourceCreatedCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PhotoCapture captureObject, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PhotoCapture captureObject) { }

	}

	internal sealed class OnPhotoModeStartedCallback : MulticastDelegate
	{

		public OnPhotoModeStartedCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PhotoCaptureResult result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PhotoCaptureResult result) { }

	}

	internal sealed class OnPhotoModeStoppedCallback : MulticastDelegate
	{

		public OnPhotoModeStoppedCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PhotoCaptureResult result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PhotoCaptureResult result) { }

	}

	internal struct PhotoCaptureResult
	{
		public CaptureResultType resultType; //Field offset: 0x0
		public long hResult; //Field offset: 0x8

	}

	private static readonly long HR_SUCCESS; //Field offset: 0x0
	internal IntPtr m_NativePtr; //Field offset: 0x10

	private static PhotoCapture() { }

	private PhotoCapture(IntPtr nativeCaptureObject) { }

	public override void Dispose() { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void Dispose_Internal() { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[ThreadAndSerializationSafe]
	private void DisposeThreaded_Internal() { }

	protected virtual void Finalize() { }

	[RequiredByNativeCode]
	private static void InvokeOnCapturedPhotoToDiskDelegate(OnCapturedToDiskCallback callback, long hResult) { }

	[RequiredByNativeCode]
	private static void InvokeOnCapturedPhotoToMemoryDelegate(OnCapturedToMemoryCallback callback, long hResult, IntPtr photoCaptureFramePtr) { }

	[RequiredByNativeCode]
	private static void InvokeOnCreatedResourceDelegate(OnCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	[RequiredByNativeCode]
	private static void InvokeOnPhotoModeStartedDelegate(OnPhotoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCode]
	private static void InvokeOnPhotoModeStoppedDelegate(OnPhotoModeStoppedCallback callback, long hResult) { }

	private static PhotoCaptureResult MakeCaptureResult(long hResult) { }

}

