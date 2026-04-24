namespace UnityEngine;

public class GUILayout
{
	private sealed class LayoutedWindow
	{
		private readonly WindowFunction m_Func; //Field offset: 0x10
		private readonly Rect m_ScreenRect; //Field offset: 0x18
		private readonly GUILayoutOption[] m_Options; //Field offset: 0x28
		private readonly GUIStyle m_Style; //Field offset: 0x30

		internal LayoutedWindow(WindowFunction f, Rect screenRect, GUIContent content, GUILayoutOption[] options, GUIStyle style) { }

		public void DoWindow(int windowID) { }

	}


	public static void BeginArea(Rect screenRect) { }

	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }

	public static void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	public static void BeginHorizontal(GUILayoutOption[] options) { }

	public static Vector2 BeginScrollView(Vector2 scrollPosition, GUILayoutOption[] options) { }

	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, GUILayoutOption[] options) { }

	public static void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	public static void BeginVertical(GUILayoutOption[] options) { }

	public static void BeginVertical(GUIStyle style, GUILayoutOption[] options) { }

	public static void Box(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	public static bool Button(string text, GUILayoutOption[] options) { }

	private static void DoBox(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options) { }

	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	private static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options) { }

	private static bool DoToggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	private static Rect DoWindow(int id, Rect screenRect, WindowFunction func, GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	public static void EndArea() { }

	public static void EndHorizontal() { }

	internal static void EndScrollView(bool handleScrollWheel) { }

	public static void EndScrollView() { }

	public static void EndVertical() { }

	public static GUILayoutOption ExpandHeight(bool expand) { }

	public static GUILayoutOption ExpandWidth(bool expand) { }

	public static void FlexibleSpace() { }

	public static GUILayoutOption Height(float height) { }

	public static float HorizontalSlider(float value, float leftValue, float rightValue, GUILayoutOption[] options) { }

	public static void Label(string text, GUIStyle style, GUILayoutOption[] options) { }

	public static void Label(string text, GUILayoutOption[] options) { }

	public static GUILayoutOption MaxHeight(float maxHeight) { }

	public static GUILayoutOption MaxWidth(float maxWidth) { }

	public static GUILayoutOption MinHeight(float minHeight) { }

	public static GUILayoutOption MinWidth(float minWidth) { }

	public static void Space(float pixels) { }

	public static string TextArea(string text, GUILayoutOption[] options) { }

	public static string TextField(string text, GUILayoutOption[] options) { }

	public static bool Toggle(bool value, string text, GUIStyle style, GUILayoutOption[] options) { }

	public static bool Toggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	public static bool Toggle(bool value, string text, GUILayoutOption[] options) { }

	public static GUILayoutOption Width(float width) { }

	public static Rect Window(int id, Rect screenRect, WindowFunction func, string text, GUILayoutOption[] options) { }

}

