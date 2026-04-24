namespace UnityEngine.UIElements;

internal static class UIElementsUtility
{
	private static Stack<IMGUIContainer> s_ContainerStack; //Field offset: 0x0
	private static Dictionary<Int32, Panel> s_UIElementsCache; //Field offset: 0x8
	private static Event s_EventInstance; //Field offset: 0x10
	internal static Color editorPlayModeTintColor; //Field offset: 0x18
	internal static readonly string s_RepaintProfilerMarkerName; //Field offset: 0x28
	internal static readonly string s_EventProfilerMarkerName; //Field offset: 0x30
	private static readonly ProfilerMarker s_RepaintProfilerMarker; //Field offset: 0x38
	private static readonly ProfilerMarker s_EventProfilerMarker; //Field offset: 0x40

	private static UIElementsUtility() { }

	internal static void BeginContainerGUI(LayoutCache cache, Event evt, IMGUIContainer container) { }

	private static void CleanupRoots() { }

	internal static EventBase CreateEvent(Event systemEvent) { }

	internal static EventBase CreateEvent(Event systemEvent, EventType eventType) { }

	private static bool DoDispatch(BaseVisualElementPanel panel) { }

	internal static void EndContainerGUI(Event evt, Rect layoutSize) { }

	private static bool EndContainerGUIFromException(Exception exception) { }

	internal static void GetAllPanels(List<Panel> panels, ContextType contextType) { }

	internal static Enumerator<Int32, Panel> GetPanelsIterator() { }

	internal static void MakeCurrentIMGUIContainerDirty() { }

	private static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	private static void ReleaseCapture() { }

	public static void RemoveCachedPanel(int instanceID) { }

	private static void TakeCapture() { }

}

