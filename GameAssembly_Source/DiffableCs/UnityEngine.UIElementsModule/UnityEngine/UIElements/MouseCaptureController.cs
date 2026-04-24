namespace UnityEngine.UIElements;

[Extension]
public static class MouseCaptureController
{
	private static bool m_IsMouseCapturedWarningEmitted; //Field offset: 0x0
	private static bool m_ReleaseMouseWarningEmitted; //Field offset: 0x1

	private static MouseCaptureController() { }

	[Extension]
	public static void CaptureMouse(IEventHandler handler) { }

	[Extension]
	public static bool HasMouseCapture(IEventHandler handler) { }

	[Extension]
	public static void ReleaseMouse(IEventHandler handler) { }

}

