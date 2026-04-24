//Type is in global namespace

public class UIBackBtnManager : SerializedMonoBehaviour
{
	[CompilerGenerated]
	private sealed class <StageClicked>d__14 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public UIBackBtnManager <>4__this; //Field offset: 0x20

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
		public <StageClicked>d__14(int <>1__state) { }

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

	public Button btnBackToQuit; //Field offset: 0x58
	public Button btnBackToWelcome; //Field offset: 0x60
	public Button btnBackToHome; //Field offset: 0x68
	public Button btnBackToStage; //Field offset: 0x70
	public AudioClip clickSfx; //Field offset: 0x78
	public Popup pnlQuitGameAsk; //Field offset: 0x80
	public GameObject pnlHome; //Field offset: 0x88
	public GameObject pnlStage; //Field offset: 0x90
	public GameObject pnlPreparation; //Field offset: 0x98

	public UIBackBtnManager() { }

	private void Awake() { }

	private void OnDestroy() { }

	private void OnHomeClicked() { }

	private void OnQuitClicked() { }

	private void OnStageClicked() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator StageClicked() { }

}

