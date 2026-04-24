namespace Assets.Scripts.PeroTools.Nice.Actions;

public class ScrollView : Action
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Transform> <>9__49_2; //Field offset: 0x8
		public static Func<Transform, GameObject> <>9__49_3; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <Execute>b__49_2(Transform c) { }

		internal GameObject <Execute>b__49_3(Transform t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_0
	{
		public List<GameObject> submitGameObjects; //Field offset: 0x10
		public RectTransform layoutRt; //Field offset: 0x18
		public float singleSize; //Field offset: 0x20
		public float extra; //Field offset: 0x24
		public Action<Boolean> page; //Field offset: 0x28
		public ScrollView <>4__this; //Field offset: 0x30

		public <>c__DisplayClass49_0() { }

		internal void <Execute>b__10(BaseEventData eventData) { }

		internal void <Execute>b__11(BaseEventData eventData) { }

		internal void <Execute>b__4(BaseEventData eventData) { }

		internal void <Execute>b__5(Vector2 offset) { }

		internal void <Execute>b__8(bool isRightBottom) { }

		internal void <Execute>b__9(int i, float f) { }

	}

	private const float moveSpeed = 1200; //Field offset: 0x0
	private const float moveBackTime = 0.4; //Field offset: 0x0
	private const float speedThreshold = 200; //Field offset: 0x0
	private const Ease moveCurve = 1; //Field offset: 0x0
	private const float elasticity = 0.1; //Field offset: 0x0
	private const float decelerationRate = 0.135; //Field offset: 0x0
	private const Ease stopCurve = 17; //Field offset: 0x0
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_ScrollSpace; //Field offset: 0x10
	[SerializeField]
	private ContentType m_ContentType; //Field offset: 0x18
	[SerializeField]
	private GameObject m_Prefab; //Field offset: 0x20
	[SerializeField]
	private List<GameObject> m_SceneObjects; //Field offset: 0x28
	[SerializeField]
	private ScrollDirection m_Direction; //Field offset: 0x30
	[SerializeField]
	private Scrollbar m_Scrollbar; //Field offset: 0x38
	[SerializeField]
	private float m_ScrollSensitivity; //Field offset: 0x40
	[SerializeField]
	private Vector4 m_Padding; //Field offset: 0x44
	[SerializeField]
	private float m_Spacing; //Field offset: 0x54
	[SerializeField]
	private TextAnchor m_ChildAlignment; //Field offset: 0x58
	[SerializeField]
	private bool m_ChildControlWidth; //Field offset: 0x5C
	[SerializeField]
	private bool m_ChildControlHeight; //Field offset: 0x5D
	[SerializeField]
	private bool m_ChildForceExpandWidth; //Field offset: 0x5E
	[SerializeField]
	private bool m_ChildForceExpandHeight; //Field offset: 0x5F
	[SerializeField]
	private bool m_IsAlign; //Field offset: 0x60
	[SerializeField]
	private float m_MidPosition; //Field offset: 0x64
	[SerializeField]
	private Vector2 m_ScaleRate; //Field offset: 0x68
	[SerializeField]
	private float m_ScaleRange; //Field offset: 0x70
	[SerializeField]
	private Button m_BtnSwitchLeftUp; //Field offset: 0x78
	[SerializeField]
	private Button m_BtnSwitchRightDown; //Field offset: 0x80
	[SerializeField]
	private AudioClip m_AudioClip; //Field offset: 0x88
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Count; //Field offset: 0x90
	[CompilerGenerated]
	private Action<Int32> onIndexChanged; //Field offset: 0x98
	[CompilerGenerated]
	private Action<Vector2> onValueChanged; //Field offset: 0xA0
	[CompilerGenerated]
	private Action<Int32, Single> onScrollTo; //Field offset: 0xA8
	[CompilerGenerated]
	private ScrollRect <scrollRect>k__BackingField; //Field offset: 0xB0
	[HideInInspector]
	public int index; //Field offset: 0xB8
	private List<Transform> m_Children; //Field offset: 0xC0
	private bool m_IsDragging; //Field offset: 0xC8
	private Tweener m_ScrollTwner; //Field offset: 0xD0
	private Tweener m_PageTwner; //Field offset: 0xD8
	private Tweener m_ToTwner; //Field offset: 0xE0
	private GameObject m_Layout; //Field offset: 0xE8

	public event Action<Int32> onIndexChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<Int32, Single> onScrollTo
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<Vector2> onValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public private ScrollRect scrollRect
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public ScrollView() { }

	[CompilerGenerated]
	private void <Execute>b__49_0() { }

	[CompilerGenerated]
	private bool <Execute>b__49_1() { }

	[CompilerGenerated]
	private void <Execute>b__49_12(Transform item) { }

	[CompilerGenerated]
	private void <Execute>b__49_13() { }

	[CompilerGenerated]
	private void <Execute>b__49_14() { }

	[CompilerGenerated]
	private void <Execute>b__49_6(BaseEventData eventData) { }

	[CompilerGenerated]
	private void <Execute>b__49_7(BaseEventData eventData) { }

	[CompilerGenerated]
	public void add_onIndexChanged(Action<Int32> value) { }

	[CompilerGenerated]
	public void add_onScrollTo(Action<Int32, Single> value) { }

	[CompilerGenerated]
	public void add_onValueChanged(Action<Vector2> value) { }

	public virtual void Execute() { }

	[CompilerGenerated]
	public ScrollRect get_scrollRect() { }

	[CompilerGenerated]
	public void remove_onIndexChanged(Action<Int32> value) { }

	[CompilerGenerated]
	public void remove_onScrollTo(Action<Int32, Single> value) { }

	[CompilerGenerated]
	public void remove_onValueChanged(Action<Vector2> value) { }

	public Tweener ScrollToIdx(int i, float time = 0) { }

	[CompilerGenerated]
	private void set_scrollRect(ScrollRect value) { }

}

