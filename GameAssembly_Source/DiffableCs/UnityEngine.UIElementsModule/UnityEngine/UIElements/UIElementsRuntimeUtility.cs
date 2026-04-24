namespace UnityEngine.UIElements;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal static class UIElementsRuntimeUtility
{
	private static EventDispatcher s_RuntimeDispatcher; //Field offset: 0x0
	private static bool s_RegisteredPlayerloopCallback; //Field offset: 0x8
	private static List<Panel> panelsIteration; //Field offset: 0x10
	internal static readonly string s_RepaintProfilerMarkerName; //Field offset: 0x18
	private static readonly ProfilerMarker s_RepaintProfilerMarker; //Field offset: 0x20

	private static UIElementsRuntimeUtility() { }

	[RequiredByNativeCode]
	public static void RepaintOverlayPanels() { }

}

