namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class Cursor
{

	public static CursorLockMode lockState
	{
		 get { } //Length: 42
	}

	public static bool visible
	{
		 get { } //Length: 42
		 set { } //Length: 51
	}

	public static CursorLockMode get_lockState() { }

	public static bool get_visible() { }

	public static void set_visible(bool value) { }

	public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode) { }

	private static void SetCursor_Injected(Texture2D texture, ref Vector2 hotspot, CursorMode cursorMode) { }

}

