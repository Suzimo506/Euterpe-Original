namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class GUILayoutUtility
{
	[VisibleToOtherModules]
	public sealed class LayoutCache
	{
		[VisibleToOtherModules]
		internal GUILayoutGroup topLevel; //Field offset: 0x10
		internal GenericStack layoutGroups; //Field offset: 0x18
		internal GUILayoutGroup windows; //Field offset: 0x20

		[VisibleToOtherModules]
		internal LayoutCache() { }

	}

	private static readonly Dictionary<Int32, LayoutCache> s_StoredLayouts; //Field offset: 0x0
	private static readonly Dictionary<Int32, LayoutCache> s_StoredWindows; //Field offset: 0x8
	internal static LayoutCache current; //Field offset: 0x10
	internal static readonly Rect kDummyRect; //Field offset: 0x18
	private static GUIStyle s_SpaceStyle; //Field offset: 0x28

	internal static GUIStyle spaceStyle
	{
		internal get { } //Length: 291
	}

	private static GUILayoutUtility() { }

	internal static void Begin(int instanceID) { }

	[VisibleToOtherModules]
	internal static void BeginContainer(LayoutCache cache) { }

	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) { }

	internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType) { }

	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) { }

	private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options) { }

	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	internal static void EndLayoutGroup() { }

	internal static GUIStyle get_spaceStyle() { }

	public static Rect GetLastRect() { }

	public static Rect GetRect(float width, float height, GUIStyle style, GUILayoutOption[] options) { }

	public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	private static Rect Internal_GetWindowRect(int windowID) { }

	private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret) { }

	private static void Internal_MoveWindow(int windowID, Rect r) { }

	private static void Internal_MoveWindow_Injected(int windowID, ref Rect r) { }

	internal static void Layout() { }

	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	[VisibleToOtherModules]
	internal static void LayoutFromContainer(float w, float h) { }

	internal static void LayoutFromEditorWindow() { }

	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	[VisibleToOtherModules]
	internal static LayoutCache SelectIDList(int instanceID, bool isWindow) { }

}

