namespace UnityEngine.UIElements;

public class IMGUIContainer : VisualElement, IDisposable
{
	private struct GUIGlobals
	{
		public Matrix4x4 matrix; //Field offset: 0x0
		public Color color; //Field offset: 0x40
		public Color contentColor; //Field offset: 0x50
		public Color backgroundColor; //Field offset: 0x60
		public bool enabled; //Field offset: 0x70
		public bool changed; //Field offset: 0x71
		public int displayIndex; //Field offset: 0x74

	}

	public static readonly string ussClassName; //Field offset: 0x0
	private Action m_OnGUIHandler; //Field offset: 0x160
	private ObjectGUIState m_ObjectGUIState; //Field offset: 0x168
	internal bool useOwnerObjectGUIState; //Field offset: 0x170
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Rect <lastWorldClip>k__BackingField; //Field offset: 0x174
	private LayoutCache m_Cache; //Field offset: 0x188
	private Rect m_CachedClippingRect; //Field offset: 0x190
	private Matrix4x4 m_CachedTransform; //Field offset: 0x1A0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ContextType <contextType>k__BackingField; //Field offset: 0x1E0
	private bool lostFocus; //Field offset: 0x1E4
	private bool receivedFocus; //Field offset: 0x1E5
	private FocusChangeDirection focusChangeDirection; //Field offset: 0x1E8
	private bool hasFocusableControls; //Field offset: 0x1F0
	private int newKeyboardFocusControlID; //Field offset: 0x1F4
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <focusOnlyIfHasFocusableControls>k__BackingField; //Field offset: 0x1F8
	private GUIGlobals m_GUIGlobals; //Field offset: 0x1FC

	private LayoutCache cache
	{
		private get { } //Length: 118
	}

	public ContextType contextType
	{
		[CompilerGenerated]
		 get { } //Length: 7
	}

	internal bool focusOnlyIfHasFocusableControls
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	internal ObjectGUIState guiState
	{
		internal get { } //Length: 166
	}

	internal Rect lastWorldClip
	{
		[CompilerGenerated]
		internal get { } //Length: 14
	}

	private float layoutMeasuredHeight
	{
		private get { } //Length: 130
	}

	private float layoutMeasuredWidth
	{
		private get { } //Length: 130
	}

	public Action onGUIHandler
	{
		 get { } //Length: 10
	}

	private static IMGUIContainer() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposeManaged) { }

	private void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus = true) { }

	private LayoutCache get_cache() { }

	[CompilerGenerated]
	public ContextType get_contextType() { }

	[CompilerGenerated]
	internal bool get_focusOnlyIfHasFocusableControls() { }

	internal ObjectGUIState get_guiState() { }

	[CompilerGenerated]
	internal Rect get_lastWorldClip() { }

	private float get_layoutMeasuredHeight() { }

	private float get_layoutMeasuredWidth() { }

	public Action get_onGUIHandler() { }

	private static void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, out Matrix4x4 transform, out Rect clipRect) { }

	internal bool HandleIMGUIEvent(Event e, bool canAffectFocus) { }

	internal bool HandleIMGUIEvent(Event e, Action onGUIHandler, bool canAffectFocus) { }

	private bool HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus) { }

	public void MarkDirtyLayout() { }

	private void RestoreGlobals() { }

	private void SaveGlobals() { }

	internal bool SendEventToIMGUI(EventBase evt, bool canAffectFocus = true) { }

}

