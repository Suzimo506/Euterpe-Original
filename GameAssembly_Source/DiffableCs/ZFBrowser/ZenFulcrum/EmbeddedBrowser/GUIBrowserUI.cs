namespace ZenFulcrum.EmbeddedBrowser;

[Obsolete]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class GUIBrowserUI : MonoBehaviour, IBrowserUI, ISelectHandler, IEventSystemHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
	[CompilerGenerated]
	private sealed class <WatchResize>d__6 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public GUIBrowserUI <>4__this; //Field offset: 0x20
		private Rect <currentSize>5__2; //Field offset: 0x28

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
		public <WatchResize>d__6(int <>1__state) { }

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

	protected RawImage myImage; //Field offset: 0x18
	protected Browser browser; //Field offset: 0x20
	public bool enableInput; //Field offset: 0x28
	public bool autoResize; //Field offset: 0x29
	protected List<Event> keyEvents; //Field offset: 0x30
	protected List<Event> keyEventsLast; //Field offset: 0x38
	protected BaseRaycaster raycaster; //Field offset: 0x40
	protected RectTransform rTransform; //Field offset: 0x48
	protected bool _mouseHasFocus; //Field offset: 0x50
	[CompilerGenerated]
	private Vector2 <MousePosition>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private MouseButton <MouseButtons>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private Vector2 <MouseScroll>k__BackingField; //Field offset: 0x60
	protected bool _keyboardHasFocus; //Field offset: 0x68
	[CompilerGenerated]
	private BrowserCursor <BrowserCursor>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private BrowserInputSettings <InputSettings>k__BackingField; //Field offset: 0x78

	public private override BrowserCursor BrowserCursor
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private override BrowserInputSettings InputSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public override bool KeyboardHasFocus
	{
		 get { } //Length: 14
	}

	public override List<Event> KeyEvents
	{
		 get { } //Length: 5
	}

	public private override MouseButton MouseButtons
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override bool MouseHasFocus
	{
		 get { } //Length: 14
	}

	public private override Vector2 MousePosition
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private override Vector2 MouseScroll
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public GUIBrowserUI() { }

	[CompilerGenerated]
	private void <Awake>b__4_0() { }

	protected void Awake() { }

	[CompilerGenerated]
	public override BrowserCursor get_BrowserCursor() { }

	[CompilerGenerated]
	public override BrowserInputSettings get_InputSettings() { }

	public override bool get_KeyboardHasFocus() { }

	public override List<Event> get_KeyEvents() { }

	[CompilerGenerated]
	public override MouseButton get_MouseButtons() { }

	public override bool get_MouseHasFocus() { }

	[CompilerGenerated]
	public override Vector2 get_MousePosition() { }

	[CompilerGenerated]
	public override Vector2 get_MouseScroll() { }

	public override void InputUpdate() { }

	public override void OnDeselect(BaseEventData eventData) { }

	protected void OnEnable() { }

	public void OnGUI() { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public override void OnSelect(BaseEventData eventData) { }

	[CompilerGenerated]
	private void set_BrowserCursor(BrowserCursor value) { }

	[CompilerGenerated]
	private void set_InputSettings(BrowserInputSettings value) { }

	[CompilerGenerated]
	private void set_MouseButtons(MouseButton value) { }

	[CompilerGenerated]
	private void set_MousePosition(Vector2 value) { }

	[CompilerGenerated]
	private void set_MouseScroll(Vector2 value) { }

	protected override void SetCursor(BrowserCursor newCursor) { }

	protected void UpdateTexture(Texture2D texture) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator WatchResize() { }

}

