namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequiredByNativeCode]
public sealed class GUIStyle
{
	internal static bool showKeyboardFocus; //Field offset: 0x0
	private static GUIStyle s_None; //Field offset: 0x8
	internal IntPtr m_Ptr; //Field offset: 0x10
	private GUIStyleState m_Normal; //Field offset: 0x18
	private GUIStyleState m_Hover; //Field offset: 0x20
	private GUIStyleState m_Active; //Field offset: 0x28
	private GUIStyleState m_Focused; //Field offset: 0x30
	private GUIStyleState m_OnNormal; //Field offset: 0x38
	private GUIStyleState m_OnHover; //Field offset: 0x40
	private GUIStyleState m_OnActive; //Field offset: 0x48
	private GUIStyleState m_OnFocused; //Field offset: 0x50
	private RectOffset m_Border; //Field offset: 0x58
	private RectOffset m_Padding; //Field offset: 0x60
	private RectOffset m_Margin; //Field offset: 0x68
	private RectOffset m_Overflow; //Field offset: 0x70
	private string m_Name; //Field offset: 0x78

	public GUIStyleState active
	{
		 get { } //Length: 112
	}

	[NativeProperty]
	public TextAnchor alignment
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[NativeProperty]
	public TextClipping clipping
	{
		 set { } //Length: 64
	}

	[NativeProperty]
	public Vector2 contentOffset
	{
		 get { } //Length: 70
		 set { } //Length: 61
	}

	[NativeProperty]
	public float fixedHeight
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	[NativeProperty]
	public float fixedWidth
	{
		 get { } //Length: 51
	}

	[NativeProperty]
	public Font font
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeProperty]
	public int fontSize
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[NativeProperty]
	public FontStyle fontStyle
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public GUIStyleState hover
	{
		 get { } //Length: 112
	}

	[NativeProperty]
	public ImagePosition imagePosition
	{
		 get { } //Length: 51
	}

	[NativeProperty]
	internal Vector2 Internal_clipOffset
	{
		internal set { } //Length: 61
	}

	public bool isHeightDependantOnWidth
	{
		 get { } //Length: 157
	}

	public float lineHeight
	{
		 get { } //Length: 162
	}

	public RectOffset margin
	{
		 get { } //Length: 175
		 set { } //Length: 83
	}

	public string name
	{
		 get { } //Length: 93
		 set { } //Length: 79
	}

	public static GUIStyle none
	{
		 get { } //Length: 179
	}

	public GUIStyleState normal
	{
		 get { } //Length: 109
	}

	public RectOffset padding
	{
		 get { } //Length: 175
		 set { } //Length: 83
	}

	[NativeProperty]
	internal string rawName
	{
		internal get { } //Length: 51
		internal set { } //Length: 66
	}

	[NativeProperty]
	public bool richText
	{
		 set { } //Length: 66
	}

	[NativeProperty]
	public bool stretchHeight
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeProperty]
	public bool stretchWidth
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeProperty]
	public bool wordWrap
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	private static GUIStyle() { }

	public GUIStyle() { }

	public GUIStyle(GUIStyle other) { }

	[FreeFunction]
	private void AssignRectOffset(int idx, IntPtr srcRectOffset) { }

	public float CalcHeight(GUIContent content, float width) { }

	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	public Vector2 CalcSize(GUIContent content) { }

	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	public void Draw(Rect position, GUIContent content, int controlID, bool on) { }

	public void Draw(Rect position, GUIContent content, int controlID) { }

	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	public void DrawCursor(Rect position, GUIContent content, int controlID, int character) { }

	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }

	internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) { }

	internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) { }

	protected virtual void Finalize() { }

	public GUIStyleState get_active() { }

	public TextAnchor get_alignment() { }

	public Vector2 get_contentOffset() { }

	private void get_contentOffset_Injected(out Vector2 ret) { }

	public float get_fixedHeight() { }

	public float get_fixedWidth() { }

	public Font get_font() { }

	public int get_fontSize() { }

	public FontStyle get_fontStyle() { }

	public GUIStyleState get_hover() { }

	public ImagePosition get_imagePosition() { }

	public bool get_isHeightDependantOnWidth() { }

	public float get_lineHeight() { }

	public RectOffset get_margin() { }

	public string get_name() { }

	public static GUIStyle get_none() { }

	public GUIStyleState get_normal() { }

	public RectOffset get_padding() { }

	internal string get_rawName() { }

	public bool get_stretchHeight() { }

	public bool get_stretchWidth() { }

	public bool get_wordWrap() { }

	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	[FreeFunction]
	private IntPtr GetRectOffsetPtr(int idx) { }

	[FreeFunction]
	private IntPtr GetStyleStatePtr(int idx) { }

	[FreeFunction]
	private float Internal_CalcHeight(GUIContent content, float width) { }

	[FreeFunction]
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret) { }

	[FreeFunction]
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	private void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret) { }

	[FreeFunction]
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret) { }

	[FreeFunction]
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	[FreeFunction]
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunction]
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunction]
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[FreeFunction]
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on) { }

	[FreeFunction]
	private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor) { }

	private void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor) { }

	[FreeFunction]
	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	private void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor) { }

	[FreeFunction]
	private static float Internal_GetCursorFlashOffset() { }

	[FreeFunction]
	internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	private void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret) { }

	[FreeFunction]
	internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	private int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition) { }

	[FreeFunction]
	private static float Internal_GetLineHeight(IntPtr target) { }

	[FreeFunction]
	internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	private string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	public static GUIStyle op_Implicit(string str) { }

	public void set_alignment(TextAnchor value) { }

	public void set_clipping(TextClipping value) { }

	public void set_contentOffset(Vector2 value) { }

	private void set_contentOffset_Injected(ref Vector2 value) { }

	public void set_fixedHeight(float value) { }

	public void set_font(Font value) { }

	public void set_fontSize(int value) { }

	public void set_fontStyle(FontStyle value) { }

	internal void set_Internal_clipOffset(Vector2 value) { }

	private void set_Internal_clipOffset_Injected(ref Vector2 value) { }

	public void set_margin(RectOffset value) { }

	public void set_name(string value) { }

	public void set_padding(RectOffset value) { }

	internal void set_rawName(string value) { }

	public void set_richText(bool value) { }

	public void set_stretchHeight(bool value) { }

	public void set_stretchWidth(bool value) { }

	public void set_wordWrap(bool value) { }

	[FreeFunction]
	internal static void SetDefaultFont(Font font) { }

	[FreeFunction]
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect) { }

	public virtual string ToString() { }

}

