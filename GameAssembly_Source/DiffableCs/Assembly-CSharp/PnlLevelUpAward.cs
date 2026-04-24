//Type is in global namespace

public class PnlLevelUpAward : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <PlayAnimator>d__12 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PnlLevelUpAward <>4__this; //Field offset: 0x20

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
		public <PlayAnimator>d__12(int <>1__state) { }

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
	private sealed class <PnlEnable>d__16 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

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
		public <PnlEnable>d__16(int <>1__state) { }

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

	public AudioClip levelUpClip; //Field offset: 0x18
	public AudioClip levelUpVoice; //Field offset: 0x20
	public AudioClip clickSfx; //Field offset: 0x28
	public Button btnCancel; //Field offset: 0x30
	public GameObject chipGrid; //Field offset: 0x38
	public Animator levelUpAnimator; //Field offset: 0x40
	[CompilerGenerated]
	private Action onDisable; //Field offset: 0x48
	public Chip[] chips; //Field offset: 0x50

	public event Action onDisable
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public PnlLevelUpAward() { }

	[CompilerGenerated]
	public void add_onDisable(Action value) { }

	private void Awake() { }

	private void OnCancelClicked() { }

	private void OnDisable() { }

	public void OnLevelUp() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator PlayAnimator() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator PnlEnable() { }

	[CompilerGenerated]
	public void remove_onDisable(Action value) { }

	private void SetChips(List<IData> rewardItems) { }

}

