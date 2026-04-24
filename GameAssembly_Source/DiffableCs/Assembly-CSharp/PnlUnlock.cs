//Type is in global namespace

public class PnlUnlock : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<IData> <>9__10_0; //Field offset: 0x8
		public static Predicate<IData> <>9__11_0; //Field offset: 0x10
		public static Predicate<IData> <>9__12_0; //Field offset: 0x18
		public static Predicate<IData> <>9__12_1; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal bool <OnLevelUp>b__11_0(IData t) { }

		internal bool <OnStageUnlockOrNot>b__12_0(IData msg) { }

		internal bool <OnStageUnlockOrNot>b__12_1(IData t) { }

		internal bool <PnlUnlockStageDisableCallback>b__10_0(IData t) { }

	}

	[CompilerGenerated]
	private sealed class <FreezeInput>d__13 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float freezeTime; //Field offset: 0x20

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
		public <FreezeInput>d__13(int <>1__state) { }

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

	public PnlLevelUpAward pnlLevelUpAward; //Field offset: 0x18
	public PnlItemAward pnlItemAward; //Field offset: 0x20
	public PnlUnlockStage pnlUnlockStage; //Field offset: 0x28
	public GameObject pnlAwardFly; //Field offset: 0x30
	public GameObject parFlyAwardCoin; //Field offset: 0x38

	public PnlUnlock() { }

	[CompilerGenerated]
	private void <OnLevelUp>b__11_1() { }

	public void Awake() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator FreezeInput(float freezeTime) { }

	private void OnDestroy() { }

	private void OnFinishMessage(object sender, object rev, Object[] pars) { }

	private void OnLevelUp(object sender, object rev, Object[] args) { }

	private void OnStageUnlockOrNot() { }

	private void PnlItemAwardDisableCallback() { }

	private void PnlLevelUpAwardDisableCallback() { }

	private void PnlUnlockStageDisableCallback() { }

}

