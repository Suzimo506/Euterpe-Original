namespace xdsdk.Unity;

public class WebWindow : UIElement
{
	[CompilerGenerated]
	private sealed class <PlayEnter>d__14 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public WebWindow <>4__this; //Field offset: 0x20
		private float <startTime>5__2; //Field offset: 0x28
		private float <endTime>5__3; //Field offset: 0x2C
		private CanvasGroup <canvasGroup>5__4; //Field offset: 0x30

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
		public <PlayEnter>d__14(int <>1__state) { }

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
	private sealed class <PlayExit>d__13 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public WebWindow <>4__this; //Field offset: 0x20
		private float <startTime>5__2; //Field offset: 0x28
		private float <endTime>5__3; //Field offset: 0x2C
		private CanvasGroup <canvasGroup>5__4; //Field offset: 0x30

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
		public <PlayExit>d__13(int <>1__state) { }

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

	public Button close; //Field offset: 0x58
	public Button back; //Field offset: 0x60
	public Browser browser; //Field offset: 0x68
	private string url; //Field offset: 0x70
	private string lastUrl; //Field offset: 0x78
	private string containsUrl; //Field offset: 0x80

	public virtual Dictionary<String, Object> Extra
	{
		 get { } //Length: 5
		 set { } //Length: 327
	}

	public WebWindow() { }

	[CompilerGenerated]
	private void <Awake>b__9_0() { }

	[CompilerGenerated]
	private void <Awake>b__9_1(JSONNode error) { }

	[CompilerGenerated]
	private void <Awake>b__9_2() { }

	private void Awake() { }

	protected virtual void FocusTo(GameObject go) { }

	public virtual Dictionary<String, Object> get_Extra() { }

	private void HandleUrl(string urlStr) { }

	private void OnCloseClicked() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual IEnumerator PlayEnter() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual IEnumerator PlayExit() { }

	public virtual void set_Extra(Dictionary<String, Object> value) { }

}

