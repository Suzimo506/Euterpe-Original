namespace ZenFulcrum.VR.OpenVRBinding;

public struct IVRScreenshots
{
	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetScreenshotPropertyFilename : MulticastDelegate
	{

		public _GetScreenshotPropertyFilename(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint screenshotHandle, EVRScreenshotPropertyFilenames filenameType, StringBuilder pchFilename, uint cchFilename, ref EVRScreenshotError pError, AsyncCallback callback, object object) { }

		public override uint EndInvoke(ref EVRScreenshotError pError, IAsyncResult result) { }

		public override uint Invoke(uint screenshotHandle, EVRScreenshotPropertyFilenames filenameType, StringBuilder pchFilename, uint cchFilename, ref EVRScreenshotError pError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetScreenshotPropertyType : MulticastDelegate
	{

		public _GetScreenshotPropertyType(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint screenshotHandle, ref EVRScreenshotError pError, AsyncCallback callback, object object) { }

		public override EVRScreenshotType EndInvoke(ref EVRScreenshotError pError, IAsyncResult result) { }

		public override EVRScreenshotType Invoke(uint screenshotHandle, ref EVRScreenshotError pError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _HookScreenshot : MulticastDelegate
	{

		public _HookScreenshot(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(out EVRScreenshotType[] pSupportedTypes, int numTypes, AsyncCallback callback, object object) { }

		public override EVRScreenshotError EndInvoke(IAsyncResult result) { }

		public override EVRScreenshotError Invoke(out EVRScreenshotType[] pSupportedTypes, int numTypes) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _RequestScreenshot : MulticastDelegate
	{

		public _RequestScreenshot(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref uint pOutScreenshotHandle, EVRScreenshotType type, string pchPreviewFilename, string pchVRFilename, AsyncCallback callback, object object) { }

		public override EVRScreenshotError EndInvoke(ref uint pOutScreenshotHandle, IAsyncResult result) { }

		public override EVRScreenshotError Invoke(ref uint pOutScreenshotHandle, EVRScreenshotType type, string pchPreviewFilename, string pchVRFilename) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SubmitScreenshot : MulticastDelegate
	{

		public _SubmitScreenshot(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint screenshotHandle, EVRScreenshotType type, string pchSourcePreviewFilename, string pchSourceVRFilename, AsyncCallback callback, object object) { }

		public override EVRScreenshotError EndInvoke(IAsyncResult result) { }

		public override EVRScreenshotError Invoke(uint screenshotHandle, EVRScreenshotType type, string pchSourcePreviewFilename, string pchSourceVRFilename) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _TakeStereoScreenshot : MulticastDelegate
	{

		public _TakeStereoScreenshot(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref uint pOutScreenshotHandle, string pchPreviewFilename, string pchVRFilename, AsyncCallback callback, object object) { }

		public override EVRScreenshotError EndInvoke(ref uint pOutScreenshotHandle, IAsyncResult result) { }

		public override EVRScreenshotError Invoke(ref uint pOutScreenshotHandle, string pchPreviewFilename, string pchVRFilename) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _UpdateScreenshotProgress : MulticastDelegate
	{

		public _UpdateScreenshotProgress(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint screenshotHandle, float flProgress, AsyncCallback callback, object object) { }

		public override EVRScreenshotError EndInvoke(IAsyncResult result) { }

		public override EVRScreenshotError Invoke(uint screenshotHandle, float flProgress) { }

	}

	internal _RequestScreenshot RequestScreenshot; //Field offset: 0x0
	internal _HookScreenshot HookScreenshot; //Field offset: 0x8
	internal _GetScreenshotPropertyType GetScreenshotPropertyType; //Field offset: 0x10
	internal _GetScreenshotPropertyFilename GetScreenshotPropertyFilename; //Field offset: 0x18
	internal _UpdateScreenshotProgress UpdateScreenshotProgress; //Field offset: 0x20
	internal _TakeStereoScreenshot TakeStereoScreenshot; //Field offset: 0x28
	internal _SubmitScreenshot SubmitScreenshot; //Field offset: 0x30

}

