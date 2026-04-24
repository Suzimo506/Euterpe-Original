//Type is in global namespace

public class GameSceneMainController : SingletonMonoBehaviour<GameSceneMainController>, IPause
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Boolean> <>9__10_0; //Field offset: 0x8
		public static UnityAction<Single> <>9__11_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <GameInit>b__11_0(float t) { }

		internal bool <Start>b__10_0() { }

	}

	[CompilerGenerated]
	private sealed class <Start>d__10 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public GameSceneMainController <>4__this; //Field offset: 0x20

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
		public <Start>d__10(int <>1__state) { }

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

	public static int curResolutionWidth; //Field offset: 0x0
	public static int curResolutionHeight; //Field offset: 0x4
	[CompilerGenerated]
	private TheEastNeverSleepsScreenEffect <screenEffect>k__BackingField; //Field offset: 0x18
	public PnlBattle pnlBattle; //Field offset: 0x20

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public private TheEastNeverSleepsScreenEffect screenEffect
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public GameSceneMainController() { }

	private void Awake() { }

	public void GameInit() { }

	public override bool get_IsGlobal() { }

	[CompilerGenerated]
	public TheEastNeverSleepsScreenEffect get_screenEffect() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnFail() { }

	private void OnShowVictory(object sender, object reciever, Object[] args) { }

	public override void Pause(bool pauseCorountine) { }

	public override void Resume() { }

	[CompilerGenerated]
	private void set_screenEffect(TheEastNeverSleepsScreenEffect value) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator Start() { }

}

