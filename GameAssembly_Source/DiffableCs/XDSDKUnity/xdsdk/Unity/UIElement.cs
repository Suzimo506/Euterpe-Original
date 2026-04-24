namespace xdsdk.Unity;

[DisallowMultipleComponent]
public class UIElement : UIBase
{
	[CompilerGenerated]
	private sealed class <PlayEnter>d__23 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public UIElement <>4__this; //Field offset: 0x20
		private float <startTime>5__2; //Field offset: 0x28
		private float <endTime>5__3; //Field offset: 0x2C
		private CanvasGroup <canvasGroup>5__4; //Field offset: 0x30
		private RectTransform <rectTransform>5__5; //Field offset: 0x38
		private float <targetX>5__6; //Field offset: 0x40

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
		public <PlayEnter>d__23(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <PlayExit>d__22 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public UIElement <>4__this; //Field offset: 0x20
		private float <startTime>5__2; //Field offset: 0x28
		private float <endTime>5__3; //Field offset: 0x2C
		private CanvasGroup <canvasGroup>5__4; //Field offset: 0x30
		private RectTransform <rectTransform>5__5; //Field offset: 0x38
		private float <targetX>5__6; //Field offset: 0x40

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
		public <PlayExit>d__22(int <>1__state) { }

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

	private static readonly int animType; //Field offset: 0x0
	protected Dictionary<String, Object> extra; //Field offset: 0x18
	[CompilerGenerated]
	private Action<Int32, Object> Callback; //Field offset: 0x20
	protected bool animationLaunched; //Field offset: 0x28
	protected float transitionDurationTime; //Field offset: 0x2C
	protected Selectable defaultSelected; //Field offset: 0x30
	protected List<Selectable> selectableItems; //Field offset: 0x38
	protected Action onEscPress; //Field offset: 0x40
	private GameObject m_CurrentSelected; //Field offset: 0x48
	public Image focus; //Field offset: 0x50

	public event Action<Int32, Object> Callback
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public override Dictionary<String, Object> Extra
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	private static UIElement() { }

	public UIElement() { }

	[CompilerGenerated]
	public void add_Callback(Action<Int32, Object> value) { }

	protected void ChangeImageSprite(Image image, string spriteName) { }

	public void ClearCallback() { }

	protected override void ClearFocus(GameObject go) { }

	private int CurrentSelectedIndex() { }

	protected private override float DoEnterAnimation() { }

	protected private override float DoExitAnimation() { }

	protected private override float DoPauseAnimation() { }

	protected private override float DoResumeAnimation() { }

	private void FocusOnDefaultOnDemand() { }

	protected override void FocusTo(GameObject go) { }

	public override Dictionary<String, Object> get_Extra() { }

	protected SDKManager GetSDKManager() { }

	protected override void OnCallback(int code, object data) { }

	protected override void OnDeselected(GameObject go) { }

	protected override void OnDown(GameObject go) { }

	private void OnEnable() { }

	protected override void OnSelected(GameObject go) { }

	protected override void OnUp(GameObject go) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override IEnumerator PlayEnter() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override IEnumerator PlayExit() { }

	protected void RegisterEventTriggerListener(GameObject go) { }

	[CompilerGenerated]
	public void remove_Callback(Action<Int32, Object> value) { }

	public override void set_Extra(Dictionary<String, Object> value) { }

	private void Update() { }

}

