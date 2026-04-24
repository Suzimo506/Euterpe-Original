//Type is in global namespace

public class PnlUnlockStage : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <OnMaskBtnClicked>d__12 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PnlUnlockStage <>4__this; //Field offset: 0x20

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
		public <OnMaskBtnClicked>d__12(int <>1__state) { }

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

	public AudioClip unlockClip; //Field offset: 0x18
	public Button btnMask; //Field offset: 0x20
	public Animator unlockAnimator; //Field offset: 0x28
	public Image unlockCover; //Field offset: 0x30
	public Text unlockText; //Field offset: 0x38
	public Text musicTitle; //Field offset: 0x40
	public Text authorTitle; //Field offset: 0x48
	[CompilerGenerated]
	private Action onDisable; //Field offset: 0x50
	private IData m_CurNewSong; //Field offset: 0x58

	public event Action onDisable
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public string newSongUid
	{
		 get { } //Length: 112
	}

	public PnlUnlockStage() { }

	[CompilerGenerated]
	private void <Awake>b__11_0() { }

	[CompilerGenerated]
	public void add_onDisable(Action value) { }

	private void Awake() { }

	public string get_newSongUid() { }

	private void OnDisable() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator OnMaskBtnClicked() { }

	[CompilerGenerated]
	public void remove_onDisable(Action value) { }

	public void UnlockNewSong(IData newSong) { }

}

