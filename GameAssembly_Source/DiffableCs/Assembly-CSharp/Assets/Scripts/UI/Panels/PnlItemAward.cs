namespace Assets.Scripts.UI.Panels;

public class PnlItemAward : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IData, Int32> <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <OnEnable>b__11_0(IData i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public string type; //Field offset: 0x10
		public int index; //Field offset: 0x18
		public IData item; //Field offset: 0x20

		public <>c__DisplayClass11_0() { }

		internal bool <OnEnable>b__1(IData t) { }

		internal bool <OnEnable>b__2(IData t) { }

	}

	[CompilerGenerated]
	private sealed class <PlayAnimator>d__10 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PnlItemAward <>4__this; //Field offset: 0x20

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
		public <PlayAnimator>d__10(int <>1__state) { }

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

	public GameObject chipGrid; //Field offset: 0x18
	public Animator itemAwardAnimator; //Field offset: 0x20
	public Button btnCancel; //Field offset: 0x28
	public AudioClip clickSfx; //Field offset: 0x30
	public Chip[] chips; //Field offset: 0x38
	[CompilerGenerated]
	private Action onDisable; //Field offset: 0x40

	public event Action onDisable
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public PnlItemAward() { }

	[CompilerGenerated]
	public void add_onDisable(Action value) { }

	private void Awake() { }

	private void OnCancelClicked() { }

	private void OnDisable() { }

	public void OnEnable() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator PlayAnimator() { }

	[CompilerGenerated]
	public void remove_onDisable(Action value) { }

	private void SetChips(List<IData> rewardItems) { }

}

