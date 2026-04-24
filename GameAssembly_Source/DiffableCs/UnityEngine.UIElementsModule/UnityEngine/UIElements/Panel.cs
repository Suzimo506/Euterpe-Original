namespace UnityEngine.UIElements;

internal class Panel : BaseVisualElementPanel
{
	private static ProfilerMarker s_MarkerPickAll; //Field offset: 0x0
	private VisualElement m_RootContainer; //Field offset: 0x30
	private VisualTreeUpdater m_VisualTreeUpdater; //Field offset: 0x38
	private uint m_Version; //Field offset: 0x40
	private uint m_RepaintVersion; //Field offset: 0x44
	private ProfilerMarker m_MarkerUpdate; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private EventDispatcher <dispatcher>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ScriptableObject <ownerObject>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ContextType <contextType>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private FocusController <focusController>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private EventInterests <IMGUIEventInterests>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int <IMGUIContainersCount>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IMGUIContainer <rootIMGUIContainer>k__BackingField; //Field offset: 0x78
	private bool m_ValidatingLayout; //Field offset: 0x80

	public virtual ContextType contextType
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public virtual EventDispatcher dispatcher
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual FocusController focusController
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual int IMGUIContainersCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public virtual EventInterests IMGUIEventInterests
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual ScriptableObject ownerObject
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual IMGUIContainer rootIMGUIContainer
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal virtual uint version
	{
		internal get { } //Length: 6
	}

	public virtual VisualElement visualTree
	{
		 get { } //Length: 7
	}

	private static Panel() { }

	[CompilerGenerated]
	public virtual ContextType get_contextType() { }

	[CompilerGenerated]
	public virtual EventDispatcher get_dispatcher() { }

	[CompilerGenerated]
	public virtual FocusController get_focusController() { }

	[CompilerGenerated]
	public virtual int get_IMGUIContainersCount() { }

	[CompilerGenerated]
	public virtual EventInterests get_IMGUIEventInterests() { }

	[CompilerGenerated]
	public virtual ScriptableObject get_ownerObject() { }

	[CompilerGenerated]
	public virtual IMGUIContainer get_rootIMGUIContainer() { }

	internal virtual uint get_version() { }

	public virtual VisualElement get_visualTree() { }

	internal virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	private static VisualElement PerformPick(VisualElement root, Vector2 point, List<VisualElement> picked = null) { }

	public virtual VisualElement Pick(Vector2 point) { }

	private static VisualElement PickAll(VisualElement root, Vector2 point, List<VisualElement> picked = null) { }

	public virtual void Repaint(Event e) { }

	private void UpdateForRepaint() { }

	public virtual void ValidateLayout() { }

}

