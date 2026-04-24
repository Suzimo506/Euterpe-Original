namespace Assets.Scripts.PeroTools.Nice.Components;

public class FancyScrollView : SerializedSimplySelectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IPreWarm
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static OnDragBeginDelegate <>9__149_0; //Field offset: 0x8
		public static OnDragDelegate <>9__149_1; //Field offset: 0x10
		public static OnDragEndDelegate <>9__149_2; //Field offset: 0x18
		public static OnPointerDownDelegate <>9__149_3; //Field offset: 0x20
		public static OnPointerDownDelegate <>9__149_4; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal void <InitCommonData>b__149_0() { }

		internal void <InitCommonData>b__149_1() { }

		internal void <InitCommonData>b__149_2() { }

		internal void <InitCommonData>b__149_3() { }

		internal void <InitCommonData>b__149_4() { }

	}

	[CompilerGenerated]
	private sealed class <PlayScrollTo>d__116 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public FancyScrollView <>4__this; //Field offset: 0x20
		public int dataIndex; //Field offset: 0x28
		public float duration; //Field offset: 0x2C
		public bool timeRelToDis; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <PlayScrollTo>d__116(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum DeadAreaDir
	{
		None = 0,
		Vertical = 1,
		Horizontal = 2,
	}

	internal enum MovementType
	{
		Loop = 0,
		Elastic = 1,
		Clamped = 2,
	}

	internal sealed class OnProcessBarBeginDrag : MulticastDelegate
	{

		public OnProcessBarBeginDrag(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnProcessBarEndDrag : MulticastDelegate
	{

		public OnProcessBarEndDrag(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal enum ScrollDirection
	{
		Vertical = 0,
		Horizontal = 1,
	}

	internal enum SortType
	{
		None = -1,
		LeftToRight = 0,
		MiddleToSide = 1,
		RightToLeft = 2,
		Custom = 999,
	}

	internal enum SourceType
	{
		Prefabs = 0,
		Children = 1,
	}

	internal enum State
	{
		Static = 0,
		Dynamic = 1,
	}

	public bool showAdvanceOptions; //Field offset: 0x68
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public RectTransform content; //Field offset: 0x70
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public SourceType sourceType; //Field offset: 0x78
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public GameObject cellPrefabs; //Field offset: 0x80
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public IVariable cellCount; //Field offset: 0x88
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float cellInterval; //Field offset: 0x90
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public IVariable cellPlaceholderPrefabs; //Field offset: 0x98
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public IVariable minCellCount; //Field offset: 0xA0
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float cellOffset; //Field offset: 0xA8
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public IVariable startIndex; //Field offset: 0xB0
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool dontInit; //Field offset: 0xB8
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool initOnPrewarm; //Field offset: 0xB9
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool disableAutoCache; //Field offset: 0xBA
	public bool enableDeadArea; //Field offset: 0xBB
	public DeadAreaDir deadAreaDir; //Field offset: 0xBC
	public float m_DeadDistance; //Field offset: 0xC0
	private Vector2 m_MousePosition; //Field offset: 0xC4
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public RectTransform viewPort; //Field offset: 0xD0
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string animName; //Field offset: 0xD8
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public SortType sortType; //Field offset: 0xE0
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float highestPos; //Field offset: 0xE4
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Scrollbar processBar; //Field offset: 0xE8
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public AudioClip audioClip; //Field offset: 0xF0
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Volume; //Field offset: 0xF8
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public AudioClip errorAudioClip; //Field offset: 0x100
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public ScrollDirection dragDirection; //Field offset: 0x108
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public MovementType movementType; //Field offset: 0x10C
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float scrollSensitivity; //Field offset: 0x110
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool inertia; //Field offset: 0x114
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Button btnPrevious; //Field offset: 0x118
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Button btnNext; //Field offset: 0x120
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float switchDuration; //Field offset: 0x128
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float longPressTriggerTime; //Field offset: 0x12C
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float borderMaxOffset; //Field offset: 0x130
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool disableButtonWhenReachBorder; //Field offset: 0x134
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool disableDrag; //Field offset: 0x135
	[CompilerGenerated]
	private float <velocity>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private bool <dragging>k__BackingField; //Field offset: 0x13C
	[CompilerGenerated]
	private float <currentScrollPosition>k__BackingField; //Field offset: 0x140
	private float m_PrevScrollPosition; //Field offset: 0x144
	[CompilerGenerated]
	private int <selectItemIndex>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private State <state>k__BackingField; //Field offset: 0x14C
	[CompilerGenerated]
	private UnityAction<Int32> onFinalItemIndexChange; //Field offset: 0x150
	[CompilerGenerated]
	private UnityAction<Int32> onItemIndexChange; //Field offset: 0x158
	[CompilerGenerated]
	private UnityAction<Single> onUpdatePosition; //Field offset: 0x160
	[CompilerGenerated]
	private Action<State> OnStateChange; //Field offset: 0x168
	public OnProcessBarBeginDrag onProcessBarBeginDrag; //Field offset: 0x170
	public OnProcessBarEndDrag onProcessBarEndDrag; //Field offset: 0x178
	private Vector2 m_PointerStartLocalPosition; //Field offset: 0x180
	private float m_DragStartScrollPosition; //Field offset: 0x188
	private int m_FinalSelectItemIndex; //Field offset: 0x18C
	private bool m_LongPressing; //Field offset: 0x190
	private bool m_AutoScrolling; //Field offset: 0x191
	private bool m_KeepAutoScrolling; //Field offset: 0x192
	private bool m_ShouldBorderAutoScroll; //Field offset: 0x193
	private float m_AutoScrollDuration; //Field offset: 0x194
	private float m_AutoScrollStartTime; //Field offset: 0x198
	private float m_AutoScrollPosition; //Field offset: 0x19C
	private bool m_HasInit; //Field offset: 0x1A0
	private bool m_FirstInit; //Field offset: 0x1A1
	[HideInInspector]
	[SerializeField]
	private int m_AnimNameHash; //Field offset: 0x1A4
	[HideInInspector]
	[SerializeField]
	private float m_DragMulFactor; //Field offset: 0x1A8
	private int m_CellCount; //Field offset: 0x1AC
	private readonly Dictionary<Int32, OnFancyScrollViewCellUpdate> m_Cells; //Field offset: 0x1B0
	private FastPool m_PoolPrefabs; //Field offset: 0x1B8
	private FastPool m_PoolPlaceHoldPrefabs; //Field offset: 0x1C0
	private bool isScrollBarDrag; //Field offset: 0x1C8
	private float m_ScrollBarPointDownTimer; //Field offset: 0x1CC
	private bool m_ScrollBarIsPointDown; //Field offset: 0x1D0
	private bool m_ScrollBarPlayPointDownAnim; //Field offset: 0x1D1
	private bool m_PointerDownToScroll; //Field offset: 0x1D2

	public event UnityAction<Int32> onFinalItemIndexChange
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event UnityAction<Int32> onItemIndexChange
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<State> OnStateChange
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event UnityAction<Single> onUpdatePosition
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public private float currentScrollPosition
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private bool dragging
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public float expectCurrentScollPosition
	{
		 get { } //Length: 27
	}

	public int itemCount
	{
		 get { } //Length: 7
	}

	public bool loop
	{
		 get { } //Length: 11
	}

	public int selectItemIndex
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public State state
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public private float velocity
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public FancyScrollView() { }

	[CompilerGenerated]
	private bool <PlayScrollTo>b__116_0() { }

	[CompilerGenerated]
	private int <UpdatePosition>b__141_0(Transform transform1, Transform transform2) { }

	[CompilerGenerated]
	private int <UpdatePositionWithScrollBar>b__148_0(Transform transform1, Transform transform2) { }

	[CompilerGenerated]
	public void add_onFinalItemIndexChange(UnityAction<Int32> value) { }

	[CompilerGenerated]
	public void add_onItemIndexChange(UnityAction<Int32> value) { }

	[CompilerGenerated]
	public void add_OnStateChange(Action<State> value) { }

	[CompilerGenerated]
	public void add_onUpdatePosition(UnityAction<Single> value) { }

	private float CalculateClosestPosition(float scrollPosition, int dictTendFlag) { }

	private float CalculateOffset(float position) { }

	private int CalculateTarget(float currentPosition, float velocity, float delta) { }

	private OnFancyScrollViewCellUpdate CreateNewCell(int dataIndex) { }

	private void DestroyAllChildren() { }

	private float EaseInOutCubic(float start, float end, float value) { }

	[CompilerGenerated]
	public float get_currentScrollPosition() { }

	[CompilerGenerated]
	public bool get_dragging() { }

	public float get_expectCurrentScollPosition() { }

	public int get_itemCount() { }

	public bool get_loop() { }

	[CompilerGenerated]
	public int get_selectItemIndex() { }

	[CompilerGenerated]
	public State get_state() { }

	[CompilerGenerated]
	public float get_velocity() { }

	public OnFancyScrollViewCellUpdate GetCell(int dataIndex) { }

	public OnFancyScrollViewCellUpdate GetCellByIndex(int index) { }

	public int GetLoop(float pos) { }

	public int GetLoopIndex(int index) { }

	public float GetLoopPosition(float position) { }

	public int GetUnloopIndex(int dataIndex) { }

	public float GetUnloopPosition(float loopPos) { }

	private float GetViewportSize() { }

	private void InitCommonData() { }

	private void InitData() { }

	private void LongPressNextUp() { }

	private void LongPressPreviousUp() { }

	private void LongPressToNext(bool isLongPress = true) { }

	private void LongPressToPrevious(bool isLongPress = true) { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	protected virtual void OnDestroy() { }

	protected virtual void OnDisable() { }

	public override void OnDrag(PointerEventData eventData) { }

	protected virtual void OnEnable() { }

	public override void OnEndDrag(PointerEventData eventData) { }

	private void OnPointerDownScrollBar() { }

	private void OnPointerUpScrollBar() { }

	private void OnScrollBarDragBegin() { }

	private void OnScrollBarDragEnd() { }

	private void OnScrollBarValueChange() { }

	private OnFancyScrollViewCellUpdate PackageCellGo(GameObject cellGo) { }

	private OnFancyScrollViewCellUpdate PackagePlaceHolderCellGo(GameObject cellGo) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public IEnumerator PlayScrollTo(int dataIndex, float duration, bool timeRelToDis = true) { }

	public override void PreWarm(int slice) { }

	public void Rebuild(GameObject prefabs) { }

	public void Rebuild(GameObject[] childrens) { }

	public void Rebuild() { }

	private void RebuildChildren() { }

	private void RebuildPrefabs() { }

	private void ReleaseAllCell() { }

	private void ReleaseCell(int cellIndex) { }

	[CompilerGenerated]
	public void remove_onFinalItemIndexChange(UnityAction<Int32> value) { }

	[CompilerGenerated]
	public void remove_onItemIndexChange(UnityAction<Int32> value) { }

	[CompilerGenerated]
	public void remove_OnStateChange(Action<State> value) { }

	[CompilerGenerated]
	public void remove_onUpdatePosition(UnityAction<Single> value) { }

	private float RubberDelta(float overStretching, float viewSize) { }

	public void ScrollTo(float position, float duration, bool timeRelToDis = true, int dirTendFlag = 0) { }

	public void ScrollToDataIndex(int dataIndex, float duration, bool timeRelToDis = true, int dirTendFlag = 0) { }

	public void ScrollToDataUid(string uid, float duration, bool timeRelToDis = true, int dirTendFlag = 0) { }

	public void ScrollToNext(float time) { }

	public void ScrollToPrevious(float time) { }

	[CompilerGenerated]
	private void set_currentScrollPosition(float value) { }

	[CompilerGenerated]
	private void set_dragging(bool value) { }

	[CompilerGenerated]
	public void set_selectItemIndex(int value) { }

	[CompilerGenerated]
	public void set_state(State value) { }

	[CompilerGenerated]
	private void set_velocity(float value) { }

	protected virtual void Start() { }

	private void Update() { }

	private void UpdateCellData(OnFancyScrollViewCellUpdate cell, int dataIndex) { }

	private void UpdateCellVisibleByIndex(OnFancyScrollViewCellUpdate cell, int cellIndex) { }

	private void UpdateHighestPos() { }

	private void UpdatePosition(float position) { }

	private void UpdatePositionWithScrollBar(float position) { }

	private void UpdateState() { }

}

