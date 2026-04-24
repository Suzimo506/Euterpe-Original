namespace UI.Welcome;

public class WelcomeProgram : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <Welcome>d__12 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public WelcomeProgram <>4__this; //Field offset: 0x20

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
		public <Welcome>d__12(int <>1__state) { }

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

	public GameObject pnlWelcome; //Field offset: 0x18
	public GameObject pnlHeadsetTip; //Field offset: 0x20
	public GameObject pnlPeroPeroGames; //Field offset: 0x28
	public GameObject pnlLaunch; //Field offset: 0x30
	public GameObject hasuHasuAnimLogo; //Field offset: 0x38
	public GameObject pnlWarning; //Field offset: 0x40
	public GameObject imgXDLogo; //Field offset: 0x48
	public Image imgBlackBoard; //Field offset: 0x50
	public GameObject agreementCanvas; //Field offset: 0x58
	private bool m_ShowXD; //Field offset: 0x60
	private Voice hasuLogoVoices; //Field offset: 0x68

	public WelcomeProgram() { }

	private void Start() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator Welcome() { }

}

