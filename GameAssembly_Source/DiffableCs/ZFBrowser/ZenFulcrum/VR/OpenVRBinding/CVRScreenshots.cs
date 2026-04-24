namespace ZenFulcrum.VR.OpenVRBinding;

public class CVRScreenshots
{
	private IVRScreenshots FnTable; //Field offset: 0x10

	internal CVRScreenshots(IntPtr pInterface) { }

	public uint GetScreenshotPropertyFilename(uint screenshotHandle, EVRScreenshotPropertyFilenames filenameType, StringBuilder pchFilename, uint cchFilename, ref EVRScreenshotError pError) { }

	public EVRScreenshotType GetScreenshotPropertyType(uint screenshotHandle, ref EVRScreenshotError pError) { }

	public EVRScreenshotError HookScreenshot(EVRScreenshotType[] pSupportedTypes) { }

	public EVRScreenshotError RequestScreenshot(ref uint pOutScreenshotHandle, EVRScreenshotType type, string pchPreviewFilename, string pchVRFilename) { }

	public EVRScreenshotError SubmitScreenshot(uint screenshotHandle, EVRScreenshotType type, string pchSourcePreviewFilename, string pchSourceVRFilename) { }

	public EVRScreenshotError TakeStereoScreenshot(ref uint pOutScreenshotHandle, string pchPreviewFilename, string pchVRFilename) { }

	public EVRScreenshotError UpdateScreenshotProgress(uint screenshotHandle, float flProgress) { }

}

