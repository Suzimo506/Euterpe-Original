namespace UnityEngine.UIElements;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class VisualElement : Focusable, ITransform, IResolvedStyle
{
	[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal struct Hierarchy
	{
		private readonly VisualElement m_Owner; //Field offset: 0x0

		public int childCount
		{
			 get { } //Length: 70
		}

		public VisualElement Item
		{
			 get { } //Length: 100
		}

		public VisualElement parent
		{
			 get { } //Length: 29
		}

		public bool Equals(Hierarchy other) { }

		public virtual bool Equals(object obj) { }

		public int get_childCount() { }

		public VisualElement get_Item(int key) { }

		public VisualElement get_parent() { }

		public virtual int GetHashCode() { }

		public static bool op_Equality(Hierarchy x, Hierarchy y) { }

	}

	private static List<String> s_EmptyClassList; //Field offset: 0x0
	internal static readonly PropertyName userDataPropertyKey; //Field offset: 0x8
	public static readonly string disabledUssClassName; //Field offset: 0x10
	private static readonly Rect s_InfiniteRect; //Field offset: 0x18
	private static readonly List<VisualElement> s_EmptyList; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <isCompositeRoot>k__BackingField; //Field offset: 0x20
	private Vector3 m_Position; //Field offset: 0x24
	private Quaternion m_Rotation; //Field offset: 0x30
	private Vector3 m_Scale; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <isLayoutManual>k__BackingField; //Field offset: 0x4C
	private Rect m_Layout; //Field offset: 0x50
	internal bool isBoundingBoxDirty; //Field offset: 0x60
	private Rect m_BoundingBox; //Field offset: 0x64
	internal bool isWorldBoundingBoxDirty; //Field offset: 0x74
	private Rect m_WorldBoundingBox; //Field offset: 0x78
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <isWorldTransformDirty>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <isWorldTransformInverseDirty>k__BackingField; //Field offset: 0x89
	private Matrix4x4 m_WorldTransformCache; //Field offset: 0x8C
	private Matrix4x4 m_WorldTransformInverseCache; //Field offset: 0xCC
	private PseudoStates m_PseudoStates; //Field offset: 0x10C
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private PickingMode <pickingMode>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private YogaNode <yogaNode>k__BackingField; //Field offset: 0x118
	internal VisualElementStylesData m_Style; //Field offset: 0x120
	private InheritedStylesData m_InheritedStylesData; //Field offset: 0x128
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ComputedStyle <computedStyle>k__BackingField; //Field offset: 0x130
	internal int imguiContainerDescendantCount; //Field offset: 0x138
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Hierarchy <hierarchy>k__BackingField; //Field offset: 0x140
	private VisualElement m_PhysicalParent; //Field offset: 0x148
	private List<VisualElement> m_Children; //Field offset: 0x150
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private BaseVisualElementPanel <elementPanel>k__BackingField; //Field offset: 0x158

	internal Rect boundingBox
	{
		internal get { } //Length: 63
	}

	internal ComputedStyle computedStyle
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	internal BaseVisualElementPanel elementPanel
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	public bool enabledInHierarchy
	{
		 get { } //Length: 16
	}

	public virtual FocusController focusController
	{
		 get { } //Length: 79
	}

	public Hierarchy hierarchy
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	internal InheritedStylesData inheritedStyle
	{
		internal get { } //Length: 10
	}

	internal bool isCompositeRoot
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal bool isLayoutManual
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal bool isWorldTransformDirty
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	internal bool isWorldTransformInverseDirty
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	public Rect layout
	{
		 get { } //Length: 212
	}

	public IPanel panel
	{
		 get { } //Length: 10
	}

	public PickingMode pickingMode
	{
		[CompilerGenerated]
		 get { } //Length: 7
	}

	internal PseudoStates pseudoStates
	{
		internal get { } //Length: 9
	}

	internal Rect rect
	{
		internal get { } //Length: 168
	}

	public IResolvedStyle resolvedStyle
	{
		 get { } //Length: 6
	}

	internal VisualElementStylesData specifiedStyle
	{
		internal get { } //Length: 10
	}

	public ITransform transform
	{
		 get { } //Length: 6
	}

	private override DisplayStyle UnityEngine.UIElements.IResolvedStyle.display
	{
		private get { } //Length: 202
	}

	private override Visibility UnityEngine.UIElements.IResolvedStyle.visibility
	{
		private get { } //Length: 249
	}

	private override Matrix4x4 UnityEngine.UIElements.ITransform.matrix
	{
		private get { } //Length: 264
	}

	public bool visible
	{
		 get { } //Length: 74
	}

	public Rect worldBound
	{
		 get { } //Length: 388
	}

	internal Rect worldBoundingBox
	{
		internal get { } //Length: 348
	}

	public Matrix4x4 worldTransform
	{
		 get { } //Length: 110
	}

	internal Matrix4x4 worldTransformInverse
	{
		internal get { } //Length: 250
	}

	internal YogaNode yogaNode
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	private static VisualElement() { }

	public override bool ContainsPoint(Vector2 localPoint) { }

	internal Rect get_boundingBox() { }

	[CompilerGenerated]
	internal ComputedStyle get_computedStyle() { }

	[CompilerGenerated]
	internal BaseVisualElementPanel get_elementPanel() { }

	public bool get_enabledInHierarchy() { }

	public virtual FocusController get_focusController() { }

	[CompilerGenerated]
	public Hierarchy get_hierarchy() { }

	internal InheritedStylesData get_inheritedStyle() { }

	[CompilerGenerated]
	internal bool get_isCompositeRoot() { }

	[CompilerGenerated]
	internal bool get_isLayoutManual() { }

	[CompilerGenerated]
	internal bool get_isWorldTransformDirty() { }

	[CompilerGenerated]
	internal bool get_isWorldTransformInverseDirty() { }

	public Rect get_layout() { }

	public IPanel get_panel() { }

	[CompilerGenerated]
	public PickingMode get_pickingMode() { }

	internal PseudoStates get_pseudoStates() { }

	internal Rect get_rect() { }

	public IResolvedStyle get_resolvedStyle() { }

	internal VisualElementStylesData get_specifiedStyle() { }

	public ITransform get_transform() { }

	public bool get_visible() { }

	public Rect get_worldBound() { }

	internal Rect get_worldBoundingBox() { }

	public Matrix4x4 get_worldTransform() { }

	internal Matrix4x4 get_worldTransformInverse() { }

	[CompilerGenerated]
	internal YogaNode get_yogaNode() { }

	internal void IncrementVersion(VersionChangeType changeType) { }

	internal static Vector2 MultiplyMatrix44Point2(Matrix4x4 lhs, Vector2 point) { }

	internal VisualElement RetargetElement(VisualElement retargetAgainst) { }

	public virtual void SendEvent(EventBase e) { }

	[CompilerGenerated]
	internal void set_isWorldTransformDirty(bool value) { }

	[CompilerGenerated]
	internal void set_isWorldTransformInverseDirty(bool value) { }

	internal bool ShouldClip() { }

	internal static Rect TransformAlignedRect(Matrix4x4 lhc, Rect rect) { }

	private override DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display() { }

	private override Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility() { }

	private override Matrix4x4 UnityEngine.UIElements.ITransform.get_matrix() { }

	internal void UpdateBoundingBox() { }

	internal void UpdateWorldBoundingBox() { }

	private void UpdateWorldTransform() { }

}

