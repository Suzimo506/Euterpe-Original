//Type is in global namespace

public class PnlVictory : MonoBehaviour, IPreWarm
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public string uid; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal bool <SetScore>b__0(IData s) { }

	}

	[CompilerGenerated]
	private sealed class <ScoreRoll>d__16 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PnlVictory <>4__this; //Field offset: 0x20
		public int targetScore; //Field offset: 0x28
		private float <timeBuffer>5__2; //Field offset: 0x2C

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
		public <ScoreRoll>d__16(int <>1__state) { }

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

	public float scoreRollTime; //Field offset: 0x18
	public GameObject pnlVictory; //Field offset: 0x20
	public AudioClip victoryBgm; //Field offset: 0x28
	public AudioClip sfxClip; //Field offset: 0x30
	public PnlVictoryTypes[] pnlControls; //Field offset: 0x38
	private PnlVictoryControls m_CurControls; //Field offset: 0x40

	public PnlVictory() { }

	[CompilerGenerated]
	private void <InitEvent>b__6_0(bool isOn) { }

	private void InitControl() { }

	private void InitEvent() { }

	private void OnContinueClicked() { }

	private void OnResetClicked() { }

	private void OnTglAdvJudgmentValueChanged(bool isOn, float normalizeTime = 0) { }

	private void OnVictory(object sender, object rev, Object[] pars) { }

	public override void PreWarm(int slice) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator ScoreRoll(int targetScore) { }

	private void SetDetailInfo() { }

	private void SetScore() { }

	private void UpdateState() { }

}

