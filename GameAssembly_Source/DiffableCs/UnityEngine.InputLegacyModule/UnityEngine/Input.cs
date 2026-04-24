namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class Input
{

	public static Vector3 acceleration
	{
		[FreeFunction]
		 get { } //Length: 62
	}

	[NativeThrows]
	public static bool anyKey
	{
		 get { } //Length: 42
	}

	[NativeThrows]
	public static bool anyKeyDown
	{
		 get { } //Length: 42
	}

	public static Vector2 compositionCursorPos
	{
		 get { } //Length: 61
		 set { } //Length: 52
	}

	public static string compositionString
	{
		 get { } //Length: 42
	}

	public static DeviceOrientation deviceOrientation
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	public static IMECompositionMode imeCompositionMode
	{
		 get { } //Length: 42
		 set { } //Length: 49
	}

	[NativeThrows]
	public static Vector3 mousePosition
	{
		 get { } //Length: 62
	}

	public static bool mousePresent
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	[NativeThrows]
	public static Vector2 mouseScrollDelta
	{
		 get { } //Length: 61
	}

	public static bool multiTouchEnabled
	{
		[FreeFunction]
		 get { } //Length: 42
		[FreeFunction]
		 set { } //Length: 51
	}

	public static bool simulateMouseWithTouches
	{
		 get { } //Length: 42
		 set { } //Length: 51
	}

	public static int touchCount
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	public static Touch[] touches
	{
		 get { } //Length: 297
	}

	public static bool touchPressureSupported
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	public static bool touchSupported
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	[FreeFunction]
	public static Vector3 get_acceleration() { }

	private static void get_acceleration_Injected(out Vector3 ret) { }

	public static bool get_anyKey() { }

	public static bool get_anyKeyDown() { }

	public static Vector2 get_compositionCursorPos() { }

	private static void get_compositionCursorPos_Injected(out Vector2 ret) { }

	public static string get_compositionString() { }

	[FreeFunction]
	public static DeviceOrientation get_deviceOrientation() { }

	public static IMECompositionMode get_imeCompositionMode() { }

	public static Vector3 get_mousePosition() { }

	private static void get_mousePosition_Injected(out Vector3 ret) { }

	[FreeFunction]
	public static bool get_mousePresent() { }

	public static Vector2 get_mouseScrollDelta() { }

	private static void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	[FreeFunction]
	public static bool get_multiTouchEnabled() { }

	public static bool get_simulateMouseWithTouches() { }

	[FreeFunction]
	public static int get_touchCount() { }

	public static Touch[] get_touches() { }

	[FreeFunction]
	public static bool get_touchPressureSupported() { }

	[FreeFunction]
	public static bool get_touchSupported() { }

	[NativeThrows]
	public static float GetAxis(string axisName) { }

	[NativeThrows]
	public static float GetAxisRaw(string axisName) { }

	[NativeThrows]
	public static bool GetButton(string buttonName) { }

	[NativeThrows]
	public static bool GetButtonDown(string buttonName) { }

	[NativeThrows]
	public static bool GetButtonUp(string buttonName) { }

	[NativeThrows]
	public static String[] GetJoystickNames() { }

	public static bool GetKey(KeyCode key) { }

	public static bool GetKeyDown(KeyCode key) { }

	[NativeThrows]
	private static bool GetKeyDownInt(KeyCode key) { }

	[NativeThrows]
	private static bool GetKeyInt(KeyCode key) { }

	public static bool GetKeyUp(KeyCode key) { }

	[NativeThrows]
	private static bool GetKeyUpInt(KeyCode key) { }

	[NativeThrows]
	public static bool GetMouseButton(int button) { }

	[NativeThrows]
	public static bool GetMouseButtonDown(int button) { }

	[NativeThrows]
	public static bool GetMouseButtonUp(int button) { }

	[NativeThrows]
	public static Touch GetTouch(int index) { }

	private static void GetTouch_Injected(int index, out Touch ret) { }

	public static void set_compositionCursorPos(Vector2 value) { }

	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

	public static void set_imeCompositionMode(IMECompositionMode value) { }

	[FreeFunction]
	public static void set_multiTouchEnabled(bool value) { }

	public static void set_simulateMouseWithTouches(bool value) { }

}

