namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class Screen
{

	public static bool autorotateToLandscapeLeft
	{
		 set { } //Length: 56
	}

	public static bool autorotateToLandscapeRight
	{
		 set { } //Length: 56
	}

	public static Resolution currentResolution
	{
		 get { } //Length: 62
	}

	public static float dpi
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 42
	}

	public static bool fullScreen
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 42
	}

	public static FullScreenMode fullScreenMode
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 42
	}

	public static int height
	{
		[NativeMethod]
		 get { } //Length: 42
	}

	public static ScreenOrientation orientation
	{
		 get { } //Length: 42
		 set { } //Length: 128
	}

	[NativeProperty]
	public static int sleepTimeout
	{
		 set { } //Length: 49
	}

	public static int width
	{
		[NativeMethod]
		 get { } //Length: 42
	}

	public static Resolution get_currentResolution() { }

	private static void get_currentResolution_Injected(out Resolution ret) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static float get_dpi() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static bool get_fullScreen() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static FullScreenMode get_fullScreenMode() { }

	[NativeMethod]
	public static int get_height() { }

	public static ScreenOrientation get_orientation() { }

	[NativeMethod]
	public static int get_width() { }

	private static ScreenOrientation GetScreenOrientation() { }

	private static void RequestOrientation(ScreenOrientation orient) { }

	public static void set_autorotateToLandscapeLeft(bool value) { }

	public static void set_autorotateToLandscapeRight(bool value) { }

	public static void set_orientation(ScreenOrientation value) { }

	public static void set_sleepTimeout(int value) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void SetOrientationEnabled(EnabledOrientation orient, bool enabled) { }

	public static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate) { }

}

