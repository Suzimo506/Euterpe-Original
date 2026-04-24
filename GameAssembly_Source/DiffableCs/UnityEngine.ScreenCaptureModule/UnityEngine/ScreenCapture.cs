namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public static class ScreenCapture
{
	internal enum StereoScreenCaptureMode
	{
		LeftEye = 1,
		RightEye = 2,
		BothEyes = 3,
	}


	public static void CaptureScreenshot(string filename) { }

	private static void CaptureScreenshot(string filename, int superSize, StereoScreenCaptureMode CaptureMode) { }

}

