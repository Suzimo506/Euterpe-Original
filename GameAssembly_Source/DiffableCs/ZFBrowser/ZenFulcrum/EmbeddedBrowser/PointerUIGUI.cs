namespace ZenFulcrum.EmbeddedBrowser;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class PointerUIGUI : PointerUIBase, IBrowserUI, ISelectHandler, IEventSystemHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
	[CompilerGenerated]
	private sealed class <WatchResize>d__5 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PointerUIGUI <>4__this; //Field offset: 0x20
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
		public <WatchResize>d__5(int <>1__state) { }

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

	protected RawImage myImage; //Field offset: 0xC8
	public bool enableInput; //Field offset: 0xD0
	public bool automaticResize; //Field offset: 0xD1
	protected BaseRaycaster raycaster; //Field offset: 0xD8
	protected RectTransform rTransform; //Field offset: 0xE0
	protected bool _mouseHasFocus; //Field offset: 0xE8
	protected bool _keyboardHasFocus; //Field offset: 0xE9

	public virtual bool KeyboardHasFocus
	{
		 get { } //Length: 32
	}

	public virtual bool MouseHasFocus
	{
		 get { } //Length: 20
		 set { } //Length: 7
	}

	public PointerUIGUI() { }

	public virtual void Awake() { }

	public virtual bool get_KeyboardHasFocus() { }

	public virtual bool get_MouseHasFocus() { }

	public virtual void GetCurrentHitLocation(out Vector3 pos, out Quaternion rot) { }

	protected virtual Vector2 MapPointerToBrowser(Vector2 screenPosition, int pointerId) { }

	protected virtual Vector2 MapRayToBrowser(Ray worldRay, int pointerId) { }

	public override void OnDeselect(BaseEventData eventData) { }

	protected void OnEnable() { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public override void OnSelect(BaseEventData eventData) { }

	protected virtual void set_MouseHasFocus(bool value) { }

	protected void UpdateTexture(Texture2D texture) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator WatchResize() { }

}

