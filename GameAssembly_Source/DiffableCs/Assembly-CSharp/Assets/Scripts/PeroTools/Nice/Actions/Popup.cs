namespace Assets.Scripts.PeroTools.Nice.Actions;

public class Popup : Action
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<CanvasScaler, Boolean> <>9__40_0; //Field offset: 0x8
		public static Comparison<Tweener> <>9__40_4; //Field offset: 0x10
		public static Comparison<Tweener> <>9__46_1; //Field offset: 0x18
		public static Action<Tweener> <>9__46_3; //Field offset: 0x20
		public static Action<Tweener> <>9__49_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal void <KillAllTwns>b__49_0(Tweener t) { }

		internal int <Leave>b__46_1(Tweener l, Tweener r) { }

		internal void <Leave>b__46_3(Tweener t) { }

		internal bool <Play>b__40_0(CanvasScaler c) { }

		internal int <Play>b__40_4(Tweener l, Tweener r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public Popup <>4__this; //Field offset: 0x10
		public Button cancelBtn; //Field offset: 0x18

		public <>c__DisplayClass40_0() { }

		internal void <Play>b__1() { }

		internal void <Play>b__2(Button b) { }

		internal void <Play>b__3(Button b) { }

		internal void <Play>b__5() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public bool enable; //Field offset: 0x10

		public <>c__DisplayClass41_0() { }

		internal void <SetShutButtonEnable>b__0(Button b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public bool isShutAll; //Field offset: 0x10
		public DBUi dbUi; //Field offset: 0x18
		public bool disablePopupNext; //Field offset: 0x20

		public <>c__DisplayClass45_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_1
	{
		public PlayPopuper peek; //Field offset: 0x10
		public <>c__DisplayClass45_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass45_1() { }

		internal void <OnShutButtonClick>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public Popup <>4__this; //Field offset: 0x10
		public GameObject gameObject; //Field offset: 0x18
		public Action callback; //Field offset: 0x20
		public Action finishCallback; //Field offset: 0x28

		public <>c__DisplayClass46_0() { }

		internal void <Leave>b__0() { }

		internal void <Leave>b__2() { }

	}

	[CompilerGenerated]
	private Action onShutClicked; //Field offset: 0x10
	[SerializeField]
	private GameObject m_Panel; //Field offset: 0x18
	[SerializeField]
	private float m_InTime; //Field offset: 0x20
	[SerializeField]
	private float m_InDistance; //Field offset: 0x24
	[SerializeField]
	private Ease m_MoveInEase; //Field offset: 0x28
	[SerializeField]
	private bool m_IsFadeIn; //Field offset: 0x2C
	[SerializeField]
	private Ease m_FadeInEase; //Field offset: 0x30
	[SerializeField]
	private float m_OutTime; //Field offset: 0x34
	[SerializeField]
	private float m_OutDistance; //Field offset: 0x38
	[SerializeField]
	private Ease m_MoveOutEase; //Field offset: 0x3C
	[SerializeField]
	private bool m_IsFadeOut; //Field offset: 0x40
	[SerializeField]
	private Ease m_FadeOutEase; //Field offset: 0x44
	[SerializeField]
	private Color m_MaskColor; //Field offset: 0x48
	[SerializeField]
	private bool m_Shut; //Field offset: 0x58
	[SerializeField]
	private bool m_ShutAll; //Field offset: 0x59
	[SerializeField]
	private PopupType m_Type; //Field offset: 0x5C
	[SerializeField]
	private List<Button> m_ShutButtons; //Field offset: 0x60
	[SerializeField]
	private List<Button> m_ShutAllShutButtons; //Field offset: 0x68
	[SerializeField]
	private AudioClip m_ShutClip; //Field offset: 0x70
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Volume; //Field offset: 0x78
	private Vector3 m_OriginPos; //Field offset: 0x80
	private bool m_Flag; //Field offset: 0x8C
	private GameObject m_BtnCancell; //Field offset: 0x90
	private List<Tweener> m_Twners; //Field offset: 0x98
	private CanvasGroup m_CanvasGroup; //Field offset: 0xA0
	private Tweener m_CurrentObjTweener; //Field offset: 0xA8
	private Tweener m_CurrentObjMoveTweener; //Field offset: 0xB0
	private Tweener m_CurrentImgTweener; //Field offset: 0xB8
	[CompilerGenerated]
	private bool <isClickShut>k__BackingField; //Field offset: 0xC0

	public event Action onShutClicked
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public private bool isClickShut
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool isShut
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public Popup() { }

	[CompilerGenerated]
	private bool <Exit>b__39_0(PlayPopuper p) { }

	[CompilerGenerated]
	public void add_onShutClicked(Action value) { }

	private void CheckImgTweenPause() { }

	private void CheckObjTweenPause() { }

	public virtual void Enter() { }

	public virtual void Execute() { }

	public virtual void Exit() { }

	[CompilerGenerated]
	public bool get_isClickShut() { }

	public bool get_isShut() { }

	private void ImgLoop(float time) { }

	private void KillAllTwns() { }

	public void Leave(Action callback) { }

	private void ObjLoop(float time) { }

	public void OnBgShutButtonClick() { }

	public void OnShutAllShutButtonsClick() { }

	public void OnShutButtonClick(bool isShutAll = false, bool disablePopupNext = false) { }

	public void OnShutButtonsClick() { }

	public void Play() { }

	private void Push() { }

	[CompilerGenerated]
	public void remove_onShutClicked(Action value) { }

	private void ResetFlag() { }

	[CompilerGenerated]
	private void set_isClickShut(bool value) { }

	public void set_isShut(bool value) { }

	private void SetShutButtonEnable(bool enable) { }

}

