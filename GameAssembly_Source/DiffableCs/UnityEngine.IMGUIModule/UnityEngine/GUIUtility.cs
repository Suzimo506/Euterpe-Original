namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class GUIUtility
{
	[VisibleToOtherModules]
	internal static int s_SkinMode; //Field offset: 0x0
	[VisibleToOtherModules]
	internal static int s_OriginalID; //Field offset: 0x4
	[VisibleToOtherModules]
	internal static Action takeCapture; //Field offset: 0x8
	[VisibleToOtherModules]
	internal static Action releaseCapture; //Field offset: 0x10
	[VisibleToOtherModules]
	internal static Func<Int32, IntPtr, Boolean> processEvent; //Field offset: 0x18
	[VisibleToOtherModules]
	internal static Action cleanupRoots; //Field offset: 0x20
	[VisibleToOtherModules]
	internal static Func<Exception, Boolean> endContainerGUIFromException; //Field offset: 0x28
	[VisibleToOtherModules]
	internal static Action guiChanged; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static bool <guiIsExiting>k__BackingField; //Field offset: 0x38
	internal static Func<Boolean> s_HasCurrentWindowKeyFocusFunc; //Field offset: 0x40

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal static Vector2 compositionCursorPos
	{
		[VisibleToOtherModules]
		internal set { } //Length: 52
	}

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal static string compositionString
	{
		[VisibleToOtherModules]
		internal get { } //Length: 42
	}

	[NativeProperty]
	internal static int guiDepth
	{
		[VisibleToOtherModules]
		internal get { } //Length: 42
	}

	internal static bool guiIsExiting
	{
		[CompilerGenerated]
		internal set { } //Length: 59
	}

	public static int hotControl
	{
		 get { } //Length: 42
		 set { } //Length: 49
	}

	public static int keyboardControl
	{
		 get { } //Length: 42
		 set { } //Length: 49
	}

	[NativeProperty]
	internal static bool mouseUsed
	{
		internal set { } //Length: 51
	}

	[NativeProperty]
	internal static float pixelsPerPoint
	{
		[VisibleToOtherModules]
		internal get { } //Length: 42
	}

	public static string systemCopyBuffer
	{
		[FreeFunction]
		 get { } //Length: 42
		[FreeFunction]
		 set { } //Length: 51
	}

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal static bool textFieldInput
	{
		internal set { } //Length: 51
	}

	[VisibleToOtherModules]
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	[VisibleToOtherModules]
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	[RequiredByNativeCode]
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[VisibleToOtherModules]
	internal static int CheckForTabEvent(Event evt) { }

	internal static void CheckOnGUI() { }

	[VisibleToOtherModules]
	internal static void EndContainer() { }

	[RequiredByNativeCode]
	internal static bool EndContainerGUIFromException(Exception exception) { }

	[RequiredByNativeCode]
	internal static void EndGUI(int layoutType) { }

	[RequiredByNativeCode]
	internal static bool EndGUIFromException(Exception exception) { }

	public static void ExitGUI() { }

	[VisibleToOtherModules]
	internal static string get_compositionString() { }

	[VisibleToOtherModules]
	internal static int get_guiDepth() { }

	public static int get_hotControl() { }

	public static int get_keyboardControl() { }

	[VisibleToOtherModules]
	internal static float get_pixelsPerPoint() { }

	[FreeFunction]
	public static string get_systemCopyBuffer() { }

	public static int GetControlID(FocusType focus) { }

	public static int GetControlID(int hint, FocusType focus) { }

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	private static int GetControlID_Injected(int hint, FocusType focusType, ref Rect rect) { }

	internal static GUISkin GetDefaultSkin() { }

	public static object GetStateObject(Type t, int controlID) { }

	[VisibleToOtherModules]
	internal static bool HasFocusableControls() { }

	internal static bool HasKeyFocus(int controlID) { }

	internal static bool HitTest(Rect rect, Event evt) { }

	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	[NativeMethod]
	internal static void Internal_EndContainer() { }

	private static void Internal_ExitGUI() { }

	private static object Internal_GetDefaultSkin(int skinMode) { }

	private static int Internal_GetHotControl() { }

	private static int Internal_GetKeyboardControl() { }

	private static void Internal_SetHotControl(int value) { }

	private static void Internal_SetKeyboardControl(int value) { }

	[VisibleToOtherModules]
	internal static bool IsExitGUIException(Exception exception) { }

	[RequiredByNativeCode]
	private static void MarkGUIChanged() { }

	[VisibleToOtherModules]
	internal static bool OwnsId(int id) { }

	[RequiredByNativeCode]
	internal static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	[RequiredByNativeCode]
	internal static void RemoveCapture() { }

	[VisibleToOtherModules]
	internal static void ResetGlobalState() { }

	[VisibleToOtherModules]
	internal static void set_compositionCursorPos(Vector2 value) { }

	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

	[CompilerGenerated]
	internal static void set_guiIsExiting(bool value) { }

	public static void set_hotControl(int value) { }

	public static void set_keyboardControl(int value) { }

	internal static void set_mouseUsed(bool value) { }

	[FreeFunction]
	public static void set_systemCopyBuffer(string value) { }

	internal static void set_textFieldInput(bool value) { }

	[VisibleToOtherModules]
	internal static void SetKeyboardControlToFirstControlId() { }

	[VisibleToOtherModules]
	internal static void SetKeyboardControlToLastControlId() { }

	[VisibleToOtherModules]
	internal static bool ShouldRethrowException(Exception exception) { }

	[RequiredByNativeCode]
	internal static void TakeCapture() { }

}

