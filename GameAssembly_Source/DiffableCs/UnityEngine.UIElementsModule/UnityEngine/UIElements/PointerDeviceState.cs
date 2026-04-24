namespace UnityEngine.UIElements;

internal static class PointerDeviceState
{
	private static Vector2[] m_Positions; //Field offset: 0x0
	private static IPanel[] m_Panels; //Field offset: 0x8
	private static Int32[] m_PressedButtons; //Field offset: 0x10

	private static PointerDeviceState() { }

	public static Vector2 GetPointerPosition(int pointerId) { }

	public static int GetPressedButtons(int pointerId) { }

	internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId) { }

	public static void PressButton(int pointerId, int buttonId) { }

	public static void ReleaseAllButtons(int pointerId) { }

	public static void ReleaseButton(int pointerId, int buttonId) { }

	public static void SavePointerPosition(int pointerId, Vector2 position, IPanel panel) { }

}

